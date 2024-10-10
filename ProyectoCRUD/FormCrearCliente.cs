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
    public partial class FormCrearCliente : Form
    {
        ClienteNegocio _clienteNegocio = new ClienteNegocio();
        public FormCrearCliente()
        {
            InitializeComponent();
        }

        private void FormCrearCliente_Load(object sender, EventArgs e)
        {

        }

        private async void btnAgregarDatosCliente_Click(object sender, EventArgs e)
        {
            bool state = await _clienteNegocio.CrearCliente(txtNombreClienteFCC.Text, txtApellidoFCC.Text, txtNombreArtisticoFCC.Text, txtTelefonoFCC.Text, txtRedesSocialesFCC.Text);
        }

        private void btnBorrarDatosCliente_Click(object sender, EventArgs e)
        {
            txtNombreArtisticoFCC.Text = "";
        }
    }
}
