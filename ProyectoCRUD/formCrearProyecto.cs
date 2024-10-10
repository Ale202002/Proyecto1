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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void formCrearProyecto_Load(object sender, EventArgs e)
        {

        }

        private async void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            bool state = await _proyectoNegocio.CrearProyecto(txtNombreProyectoFCP.Text, float.Parse(txtCostoProyectoFCP.Text), checkBoxDescuentoFCP.Checked, comboBox2.Text, txtInicioProyectoFCP.Text, txtCierreProyectoFCP.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
