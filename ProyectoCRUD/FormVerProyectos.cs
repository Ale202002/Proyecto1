using C2_CN;
using C4_EN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class FormVerProyectos : Form
    {
        List<Proyecto> listProyecto = new List<Proyecto>();
        ProyectoNegocio _proyectoNegocio = new ProyectoNegocio();
        public FormVerProyectos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarDatosProyecto_Click(object sender, EventArgs e)
        {

        }

        private async void FormVerProyectos_Load(object sender, EventArgs e)
        {
            listProyecto = await _proyectoNegocio.ListarProyectos();
            dGVProyectosFVP.DataSource = listProyecto;
            for (int i = 0; i < dGVProyectosFVP.Columns.Count; i++)
            {
                dGVProyectosFVP.Columns[dGVProyectosFVP.Columns[i].DataPropertyName.Trim()].HeaderText = dGVProyectosFVP.Columns[i].DataPropertyName
                    .Replace("NombreProyecto", "Nombre Proyecto").Replace("TipoServicio", "Tipo Servicio")
                    .Replace("NombreCliente", "Nombre Cliente").Replace("CostoTotal", "Costo Total")
                    .Replace("EstadoPago", "Estado Pago").Replace("FechaInicio", "Fecha Inicio")
                    .Replace("FechaFinal", "Fecha Final");
            }
        }

        private async void btnEliminarProyectoFVP_Click(object sender, EventArgs e)
        {
            if (listProyecto != null)
            {
                int rowIndex = dGVProyectosFVP.CurrentRow.Index;
                if (rowIndex >= 0 && rowIndex < listProyecto.Count)
                {
                    bool state = await _proyectoNegocio.EliminarCliente(rowIndex);
                    listProyecto.RemoveAt(rowIndex);
                    dGVProyectosFVP.DataSource = null;
                    dGVProyectosFVP.DataSource = listProyecto;
                }
            }
        }
    }
}
