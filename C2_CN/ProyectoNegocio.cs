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
    public class ProyectoNegocio
    {
        private GestionEntityFramework<Proyecto> _gestionDatos = new GestionEntityFramework<Proyecto>();

        public ProyectoNegocio()
        {
            
        }

        public async Task<bool> CrearProyecto(string nombreProyecto, float costoTotal, bool descuento, string estadoPago, string fechaInicio, string FechaFinal)
        {
            Proyecto proyecto = new Proyecto(nombreProyecto, costoTotal, descuento, estadoPago, Convert.ToDateTime(fechaInicio), Convert.ToDateTime(FechaFinal));
            bool state = await _gestionDatos.CreateAsync(proyecto);
            if (state)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Proyecto>> ListarProyectos()
        {
            return await _gestionDatos.GetAsync();
        }

        public async Task<bool> ActualizarProyecto(int id, string atributo, object valor)
        {
            Proyecto proyecto = new Proyecto();
            PropertyInfo propiedad = proyecto.GetType().GetProperty(atributo);
            if (propiedad != null)
            {
                propiedad.SetValue(proyecto, valor);
                bool state = await _gestionDatos.UpdateByIdAsync(id, proyecto);
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
