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
                bool state = await _clienteNegocio.CrearCliente
                    (txtNombreClienteFCC.Text, txtApellidoFCC.Text, txtNombreArtisticoFCC.Text
                    , txtTelefonoFCC.Text, txtRedesSocialesFCC.Text);
                MessageBox.Show("Registro de cliente completado");
            }
            catch (Exception x )
            {
                limpiarControles();
                MessageBox.Show("A ocurrido un error");
                MessageBox.Show(x.Message);
            }
            finally
            {
                limpiarControles();
            }
        }
        private void btnBorrarDatosCliente_Click(object sender, EventArgs e)
        {
            limpiarControles();
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
        private void txtNombreArtisticoFCC_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtRedesSocialesFCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }  
}

