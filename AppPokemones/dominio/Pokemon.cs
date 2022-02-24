using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {

        // Metodos Publicos de la clase pokemon.
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public  string UrlImagen { get; set; }
        public Elemento Tipo { get; set; } // Objeto de tipo Elemento.
        public Elemento Debilidad { get; set; }
    }
}
