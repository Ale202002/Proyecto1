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
    public partial class formCrearProyecto : Form
    {
        ProyectoNegocio _proyectoNegocio = new ProyectoNegocio();
        public formCrearProyecto()
        {
            InitializeComponent();
        }

        private void formCrearProyecto_Load(object sender, EventArgs e)
        {

        }

        private async void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                bool x;
                float salida;
                x = float.TryParse(txtCostoProyectoFCP.Text, out salida);
                if (txtNombreProyectoFCP.Text != string.Empty && comboBox1.Text != string.Empty && txtNombreClienteFCP.Text != string.Empty
                    && x && comboBox2.Text != string.Empty && txtInicioProyectoFCP.Text != string.Empty && txtCierreProyectoFCP.Text != string.Empty)
                {
                    bool state = await _proyectoNegocio.CrearProyecto(txtNombreProyectoFCP.Text, comboBox1.Text, txtNombreClienteFCP.Text,
                    float.Parse(txtCostoProyectoFCP.Text), checkBoxDescuentoFCP.Checked, comboBox2.Text, txtInicioProyectoFCP.Text, txtCierreProyectoFCP.Text);
                    MessageBox.Show("Proyecto creado correctamente");
                    limpiarControles();
                }
                else { MessageBox.Show("Debe de llenar todos los campos"); }

            }
            catch (Exception x)
            {
                MessageBox.Show("A ocurrido un error, intentelo de nuevo");
                MessageBox.Show(x.Message);
                limpiarControles();
            }
        }
        private void txtNombreProyectoFCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreClienteFCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCostoProyectoFCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void limpiarControles()
        {
            txtNombreProyectoFCP.Text = "";
            txtCostoProyectoFCP.Text = "";
            checkBoxDescuentoFCP.Checked = false;
            comboBox2.Text = "";
            txtInicioProyectoFCP.Text = "";
            txtCierreProyectoFCP.Text = "";
            comboBox1.Text = "";
        }

        private void btnBorrarDatosProyectoFCP_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }
    }
}
