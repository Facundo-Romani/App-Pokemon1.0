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
    }
}
