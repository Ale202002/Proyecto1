using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_EN
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreArtistico { get; set; }
        public string Telefono { get; set; }
        public string Url { get; set; }
        public DateTime FechaRegistro { get; set; }
        
        public Cliente()
        {

        }
        public Cliente(string nombre, string apellido, string nombreArtistico, string telefono, string url)
        {
            Nombre = nombre;
            Apellido = apellido;
            NombreArtistico = nombreArtistico;
            Telefono = telefono;
            Url = url;
        }
    }
}
