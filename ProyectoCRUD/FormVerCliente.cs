using Azure.Core;
using C4_EN;
using C2_CN;
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
    public partial class FormVerCliente : Form
    {
        List<Cliente> listCliente = new List<Cliente>();
        ClienteNegocio _clienteNegocio = new ClienteNegocio();
        public FormVerCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreProyecto_Click(object sender, EventArgs e)
        {

        }

        private async void FormVerCliente_Load(object sender, EventArgs e)
        {
            listCliente = await _clienteNegocio.ListarClientes();
            dGVFormVerClientes.DataSource = listCliente;
            for (int i = 0; i < dGVFormVerClientes.Columns.Count; i++)
            {
                dGVFormVerClientes.Columns[dGVFormVerClientes.Columns[i].DataPropertyName.Trim()].HeaderText = dGVFormVerClientes.Columns[i].DataPropertyName.Replace("NombreArtistico", "Nombre Artistico").Replace("FechaRegistro", "Fecha Registro");
            }
        }

        private async void btnEliminarFVC_Click(object sender, EventArgs e)
        {
            if (listCliente != null)
            {
                int rowIndex = dGVFormVerClientes.CurrentRow.Index;
                if (rowIndex >= 0 && rowIndex < listCliente.Count)
                {
                    bool state = await _clienteNegocio.EliminarCliente(rowIndex);
                    listCliente.RemoveAt(rowIndex);
                    dGVFormVerClientes.DataSource = null;
                    dGVFormVerClientes.DataSource = listCliente;
                }
            }
        }
    }
}
