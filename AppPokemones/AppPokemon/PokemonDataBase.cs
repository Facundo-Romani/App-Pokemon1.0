using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppPokemon
{
    internal class PokemonDataBase
    {
        public List<Pokemon> listar() // Método para establecer conexión con base de datos.
        {   
            // Instanciar lista de objeto Pokemon.
            List<Pokemon> lista = new List<Pokemon>();
            // Al inluir la libreria using System.Data.SqlClient puedo crear los siguientes objetos.
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lectura;


            // Manejo de Exception errores.
            try
            {   
                // Cadena de conexion.
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre , descripcion, UrlImagen from POKEMONS";
                comando.Connection = conexion;

                // Abrir conexion.
                conexion.Open();
                lectura = comando.ExecuteReader();

                // Si hay una lectura de datos entra al while.
                while (lectura.Read())
                {
                    Pokemon aux = new Pokemon(); // Objeto pokemon.
                    aux.numero = lectura.GetInt32(0);
                    aux.nombre = (string)lectura["Nombre"];
                    aux.descripcion = (string)lectura["descripcion"];
                    aux.UrlImagen = (string)lectura["urlImagen"];

                    lista.Add(aux); // A la lista le agrego los datos de aux.
                }

                conexion.Close(); // Cerrar la conexion con la base de datos.
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
