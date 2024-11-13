using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.DTOs
{
    public class ClienteDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreArtistico { get; set; }
        public string Telefono { get; set; }
        public string Url { get; set; }
        public ClienteDTO() { }
    }
}
