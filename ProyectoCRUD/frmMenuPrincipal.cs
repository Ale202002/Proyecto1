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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            customizeDesign();
        }
        
        private void customizeDesign()
        {
            panelSubMenuCliente.Visible = false;
            panelSubMenuProyectos.Visible = false;
        }

         private void hideSubMenu() 
         {
             if (panelSubMenuCliente.Visible == true)
                 panelSubMenuCliente.Visible = false;
             if (panelSubMenuProyectos.Visible == true)
                 panelSubMenuProyectos.Visible = false;

         }

         private void showSubmenu(Panel subMenu)
         {
             if (panelSubMenuCliente.Visible == false)
             {
                hideSubMenu();
                 subMenu.Visible = true;
             }
             else
             {
                 subMenu.Visible = false;
             }
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //  Pintar Botones

        private void btnCrearProyecto_MouseEnter(object sender, EventArgs e)
        {
            
            btnCrearProyecto.BackColor = ColorTranslator.FromHtml("#BF491F");
        }

        private void btnCrearProyecto_MouseLeave(object sender, EventArgs e)

        {

            btnCrearProyecto.BackColor = ColorTranslator.FromHtml("#D9D7D7");
        }

        private void btnVerProyectos_MouseEnter(object sender, EventArgs e)
        {

            btnVerProyectos.BackColor = ColorTranslator.FromHtml("#BF491F");
        }

        private void btnVerProyectos_MouseLeave(object sender, EventArgs e)

        {

            btnVerProyectos.BackColor = ColorTranslator.FromHtml("#D9D7D7");
        }

        private void panelSubMenuProyectos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuProyectos);
        }


        private void btnVerProyectos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormVerProyectos());
            hideSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formCrearProyecto());
            hideSubMenu();
        }

        private void AbrirFormEnPanel(Form formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formhija.TopLevel = false;
            formhija.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formhija);
            this.panelContenedor.Tag = formhija;
            formhija.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubMenuCliente);
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
           AbrirFormEnPanel(new FormCrearCliente());
            hideSubMenu();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormVerCliente());
            hideSubMenu();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
           // this.WindowState = FormWindowState.Normal;
            //pictureMaximizar.Visible = true;
           // pictureRestaurar.Visible = false;
        }
    }
}
