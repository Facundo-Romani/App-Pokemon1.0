using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Pokemon
    {
        // Metodos Publicos de la clase pokemon.
        public int Id { get; set; } 

        [DisplayName("Número")]
        public int Numero { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public  string UrlImagen { get; set; }
        public Elemento Tipo { get; set; } // Objeto de tipo Elemento.
        public Elemento Debilidad { get; set; }
    }
}
