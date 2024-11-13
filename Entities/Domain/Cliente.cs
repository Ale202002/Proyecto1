using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Domain
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
        public Cliente(){}


    }
}
