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
    internal class ServicioNegocio
    {
        private GestionEntityFramework<Servicio> _gestionDatos;

        public ServicioNegocio(GestionEntityFramework<Servicio> gestionDatos)
        {
            _gestionDatos = gestionDatos;
        }

        public async Task<bool> CrearServicio(string nombreServicio, float precio)
        {
            Servicio servicio = new Servicio(nombreServicio, precio);
            bool state = await _gestionDatos.CreateAsync(servicio);
            if (state)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Servicio>> ListarServicios()
        {
            return await _gestionDatos.GetAsync();
        }

        public async Task<bool> ActualizarServicio(int id, string atributo, object valor)
        {
            Servicio servicio = new Servicio();
            PropertyInfo propiedad = servicio.GetType().GetProperty(atributo);
            if (propiedad != null)
            {
                propiedad.SetValue(servicio, valor);
                bool state = await _gestionDatos.UpdateByIdAsync(id, servicio);
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

        public async Task<bool> EliminarServicio(int id)
        {
            return await _gestionDatos.DeleteByIdAsync(id);
        }
    }
}
