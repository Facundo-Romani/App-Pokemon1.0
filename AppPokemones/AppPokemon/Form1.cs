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
        }
            
        // Selecciona el Pokemon de la Fila que demos click.
        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
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
                dgvPokemon.Columns["UrlImagen"].Visible = false;
                dgvPokemon.Columns["Id"].Visible = false;
                cargarImagen(listapokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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
    }
}
