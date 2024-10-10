using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_EN
{
    public class Servicio
    {
        public int Id { get; set; }
        public string NombreServicio { get; set; }
        public float Precio { get; set; }

        public Servicio()
        {

        }

        public Servicio(string nombreServicio, float precio)
        {
            NombreServicio = nombreServicio;
            Precio = precio;
        }
    }
}
