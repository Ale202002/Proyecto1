using C3_CD;
using C4_EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C2_CN
{
    public class ClienteNegocio
    {
        private GestionEntityFramework<Cliente> _gestionDatos = new GestionEntityFramework<Cliente>();

        public ClienteNegocio() //GestionEntityFramework<Cliente> gestionDatos
        {
            //_gestionDatos = gestionDatos;
        }

        public async Task<bool> CrearCliente(string nombre, string apellido, string nombreArtistico, string telefono, string url)
        {
            Cliente cliente = new Cliente(nombre, apellido, nombreArtistico, telefono, url);
            bool state = await _gestionDatos.CreateAsync(cliente);
            if (state)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            return await _gestionDatos.GetAsync();
        }

        public async Task<bool> ActualizarCliente(int id, string atributo, object valor)
        {
            Cliente cliente = new Cliente();
            PropertyInfo propiedad = cliente.GetType().GetProperty(atributo);
            if (propiedad != null)
            {
                propiedad.SetValue(cliente, valor);
                bool state = await _gestionDatos.UpdateByIdAsync(id, cliente);
                if (state)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> EliminarCliente(int id)
        {
            return await _gestionDatos.DeleteByIdAsync(id);
        }
    }
}
