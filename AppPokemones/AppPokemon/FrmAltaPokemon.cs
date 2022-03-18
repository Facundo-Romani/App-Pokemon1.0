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
    public partial class FrmAltaPokemon : Form
    {
        public FrmAltaPokemon()
        {
            InitializeComponent();
        }

        // BtnCancelar cerrar la ventana.
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // BtnAceptar para agregar el pokemon nuevo.
        private void BtnAceptar_Click(object sender, EventArgs e)
        {   
            Pokemon pokeNuevo = new Pokemon();
            PokemonDataBase bdd = new PokemonDataBase();

            try
            {
                pokeNuevo.Numero = int.Parse(TxtNumero.Text);
                pokeNuevo.Nombre = TxtNombre.Text;
                pokeNuevo.Descripcion = TxtDescipcion.Text;
                pokeNuevo.UrlImagen = txtUrlimagen.Text;
                pokeNuevo.Tipo = (Elemento)cmbTipo.SelectedItem;
                pokeNuevo.Debilidad = (Elemento)cmbDebilidad.SelectedItem;

                bdd.agregarPokemon(pokeNuevo);
                MessageBox.Show("Agregado Exitosamente");
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
                cmbDebilidad.DataSource = elementoNegocio.listar();
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
    }
}
