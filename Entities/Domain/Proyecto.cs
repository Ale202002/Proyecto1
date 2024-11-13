using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string NombreProyecto { get; set; }
        public string TipoServicio { get; set; }
        public string NombreCliente { get; set; }
        public float CostoTotal { get; set; }
        public bool Descuento { get; set; }
        public string EstadoPago { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Proyecto(){}
    }
}
