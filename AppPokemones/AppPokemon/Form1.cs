﻿using System;
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
            // Generar instacia de objeto data base.
            ElementoNegocio pokemon = new ElementoNegocio();
            listapokemon = pokemon.listar();
            dgvPokemon.DataSource = listapokemon;
            dgvPokemon.Columns["UrlImagen"].Visible = false; 
            cargarImagen(listapokemon[0].UrlImagen);
        }

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
    }
}
