using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_EN
{
    public class Cliente
    {
        private int id;
        private string name;
        private string apellido;
        private string nombreArtistico;
        private int telefono;
        private string url;

        public Cliente()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NombreArtistico { get => nombreArtistico; set => nombreArtistico = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Url { get => url; set => url = value; }
    }
}
