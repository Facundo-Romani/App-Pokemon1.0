using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class PokemonDataBase
    {
       
        // Metodo para agregar un poke nuevo.
        public void agregarPokemon(Pokemon nuevo)
        {   
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo)values(" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1)");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            } 
            finally
            {
                datos.cerrarConexion();
            }
        }

        // Modificar un poke.
        public void modificarPokemon(Pokemon modificar)
        {

        }
    }
}

//public List<Pokemon> listar() // Método para establecer conexión con base de datos.
//{
//    Instanciar lista de objeto Pokemon.
//    List<Pokemon> lista = new List<Pokemon>();
//    Al inluir la libreria using System.Data.SqlClient puedo crear los siguientes objetos.
//    SqlConnection conexion = new SqlConnection();
//    SqlCommand comando = new SqlCommand();
//    SqlDataReader lectura;


//    Manejo de Exception errores.
//    try
//    {
//         Cadena de conexion.
//        conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true ";
//        comando.CommandType = System.Data.CommandType.Text;
//        comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
//        comando.Connection = conexion;

//        Abrir conexion.
//        conexion.Open();
//        lectura = comando.ExecuteReader();

//        Si hay una lectura de datos entra al while.
//        while (lectura.Read())
//        {
//             Mapeo.
//            Pokemon aux = new Pokemon(); // Objeto pokemon.
//            aux.Numero = lectura.GetInt32(0);
//            aux.Nombre = (string)lectura["Nombre"];
//            aux.Descripcion = (string)lectura["descripcion"];
//            aux.UrlImagen = (string)lectura["urlImagen"];
//            aux.Tipo = new Elemento();
//            aux.Tipo.Descripcion = (string)lectura["tipo"];
//            aux.Debilidad = new Elemento();
//            aux.Debilidad.Descripcion = (string)lectura["debilidad"];

//            lista.Add(aux); // A la lista le agrego los datos de aux.
//        }

//        conexion.Close(); // Cerrar la conexion con la base de datos.
//        return lista;
//    }
//    catch (Exception ex)
//    {

//        throw ex;
//    }

//}
