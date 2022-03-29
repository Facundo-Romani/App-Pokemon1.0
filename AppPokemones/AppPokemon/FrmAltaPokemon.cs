using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace AppPokemon
{
    public partial class FrmAltaPokemon : Form
    {   
        // Atributo privado asignado a null para manejar el evento modificar.
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
        public FrmAltaPokemon()
        {
            InitializeComponent();
            Text = "Nuevo Pokemon";
        }
        public FrmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        // BtnCancelar cerrar la ventana.
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // BtnAceptar para agregar el pokemon nuevo.
        private void BtnAceptar_Click(object sender, EventArgs e)
        {   
            PokemonDataBase bdd = new PokemonDataBase();

            try
            {
                // Validar null.
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(TxtNumero.Text);
                pokemon.Nombre = TxtNombre.Text;
                pokemon.Descripcion = TxtDescipcion.Text;
                pokemon.UrlImagen = txtUrlimagen.Text;
                pokemon.Tipo = (Elemento)cmbTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cmbDebilidad.SelectedItem;               
                
                if (pokemon.Id != 0)
                {
                    bdd.modificarPokemon(pokemon);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    bdd.agregarPokemon(pokemon);
                    MessageBox.Show("Agregado Exitosamente");
                }

                // Guardo img si la levanto localmente.
                if (archivo != null && !(txtUrlimagen.Text.ToUpper().Contains("HTTP")))
                {
                    // Guardar Imagen.
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }
                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Evento Load ventana AltaPokemon.
        private void FrmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cmbTipo.DataSource = elementoNegocio.listar();
                cmbTipo.ValueMember = "Id";
                cmbTipo.DisplayMember = "Descripcion";
                cmbDebilidad.DataSource = elementoNegocio.listar();
                cmbDebilidad.ValueMember = "Id";
                cmbDebilidad.DisplayMember = "Descripcion";

                // Validación para modificar y precargar los datos.
                if(pokemon != null)
                {
                    TxtNumero.Text = pokemon.Numero.ToString();
                    TxtNombre.Text = pokemon.Nombre;
                    TxtDescipcion.Text = pokemon.Descripcion;
                    txtUrlimagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cmbTipo.SelectedValue = pokemon.Tipo.Id;
                    cmbDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Cargar URL imagen.
        private void txtUrlimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlimagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaPoke.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAltaPoke.Load("https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.pngwing.com%2Fes%2Fsearch%3Fq%3Dimagen%2Bvac%25C3%25ADa&psig=AOvVaw1FoOSG31HgQQwzafMdY2dq&ust=1647718359028000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCLCi5q2z0PYCFQAAAAAdAAAAABAD");
            }
        }

        // Levantar y cargar imagen.
        private void btnAltaImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*. jpg| png|*. png" ;
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlimagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
            
        }
    }
}
