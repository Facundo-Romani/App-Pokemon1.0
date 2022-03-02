﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        // Lectura desde el exterior.
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // Constructor para la (CONEXION).
        public AccesoDatos ()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true ");
            comando = new SqlCommand();
        }

        // Metodo para la consulta (COMANDO).
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;    
        }

        // Metodo de lectura.
        public void ejecurtarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        // Cerrar conexion.
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
                conexion.Close();
        }
    }
}