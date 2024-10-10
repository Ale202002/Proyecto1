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
            try
            {
                if (txtNombreClienteFCC.Text != string.Empty && txtApellidoFCC.Text != string.Empty &&
                     txtNombreArtisticoFCC.Text != string.Empty && txtTelefonoFCC.Text != string.Empty && txtRedesSocialesFCC.Text != string.Empty)
                {
                    bool state = await _clienteNegocio.CrearCliente
                    (txtNombreClienteFCC.Text, txtApellidoFCC.Text, txtNombreArtisticoFCC.Text
                    , txtTelefonoFCC.Text, txtRedesSocialesFCC.Text);
                    MessageBox.Show("Registro de cliente completado");
                    limpiarControles();
                }
                else { MessageBox.Show("Debe de llenar todos los campos");}
            }
            catch (Exception x)
            {
                MessageBox.Show("A ocurrido un error, intentelo de nuevo");
                MessageBox.Show(x.Message);
                limpiarControles();
            }
        }

        private void btnBorrarDatosCliente_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }
        private void limpiarControles()
        {
            txtNombreClienteFCC.Text = "";
            txtNombreArtisticoFCC.Text = "";
            txtApellidoFCC.Text = "";
            txtApellidoFCC.Text = "";
            txtRedesSocialesFCC.Text = "";
            txtTelefonoFCC.Text = "";
        }

        private void txtNombreClienteFCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoFCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoFCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
