using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace AppPokemon
{
    public partial class Form1 : Form
    {   
        // Propiedad privada para manejar la lista con la carga de imagenes.
        private List<Pokemon> listapokemon;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Descripción");
        }
            
        // Selecciona el Pokemon de la Fila que demos click.
        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
            
        }

        // Método para cargar imagen manejando Exception por si se realiza un update en base de datos.
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBox1.Load("https://w7.pngwing.com/pngs/848/297/png-transparent-white-graphy-color-empty-banner-blue-angle-white.png");
                throw ex;
            }

        }

        private void cargar()
        {
            // Generar instacia de objeto data base.
            PokemonDataBase pokemon = new PokemonDataBase();
            try
            {
                listapokemon = pokemon.listar();
                dgvPokemon.DataSource = listapokemon;
                ocultarColumnas();
                cargarImagen(listapokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void ocultarColumnas()
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            dgvPokemon.Columns["Id"].Visible = false;
        }

        // LLamar a ventana FrmAltaPokemon.
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon alta = new FrmAltaPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

            FrmAltaPokemon modificar = new FrmAltaPokemon(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool logico = false)
        {
            PokemonDataBase database = new PokemonDataBase();
            Pokemon seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (logico)
                        database.eliminarLogico(seleccionado.Id);
                    else
                        database.eliminar(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex < 0) 
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }

            if (cboCampo.SelectedItem.ToString() == "Número")
            
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }

                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            PokemonDataBase bdd = new PokemonDataBase();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvPokemon.DataSource = bdd.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        // FindAll funciona como un foreach para filtrar.
        // TextChanged evento para busqueda de filtro rápido.
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listapokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listapokemon;
            }

            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
            ocultarColumnas();
        }

       // Filtro lógico par Bdd.
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Número")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("termina con");
                cboCriterio.Items.Add("Contine");
            }
        }
    }
}
