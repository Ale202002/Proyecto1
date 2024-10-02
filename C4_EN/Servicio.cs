using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_EN
{
    public class Servicio
    {
        private int id;
        private string nombreServicio;
        private float precio;

        public Servicio()
        {

        }

        public string NombreServicio { get => nombreServicio; set => nombreServicio = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Id { get => id; set => id = value; }
    }
}
