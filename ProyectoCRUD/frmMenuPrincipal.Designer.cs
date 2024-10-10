namespace ProyectoCRUD
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelSubMenuProyectos = new System.Windows.Forms.Panel();
            this.panelSubMenuCliente = new System.Windows.Forms.Panel();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelBarraTareas = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerProyectos = new System.Windows.Forms.Button();
            this.btnCrearProyecto = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelSubMenuProyectos.SuspendLayout();
            this.panelSubMenuCliente.SuspendLayout();
            this.panelBarraTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.panelLateral.Controls.Add(this.panelSubMenuProyectos);
            this.panelLateral.Controls.Add(this.panelSubMenuCliente);
            this.panelLateral.Controls.Add(this.btnProyectos);
            this.panelLateral.Controls.Add(this.btnClientes);
            this.panelLateral.Controls.Add(this.panelLogo);
            this.panelLateral.Location = new System.Drawing.Point(0, 30);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(402, 994);
            this.panelLateral.TabIndex = 1;
            // 
            // panelSubMenuProyectos
            // 
            this.panelSubMenuProyectos.Controls.Add(this.btnVerProyectos);
            this.panelSubMenuProyectos.Controls.Add(this.btnCrearProyecto);
            this.panelSubMenuProyectos.Location = new System.Drawing.Point(0, 436);
            this.panelSubMenuProyectos.Name = "panelSubMenuProyectos";
            this.panelSubMenuProyectos.Size = new System.Drawing.Size(402, 143);
            this.panelSubMenuProyectos.TabIndex = 2;
            this.panelSubMenuProyectos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubMenuProyectos_Paint);
            // 
            // panelSubMenuCliente
            // 
            this.panelSubMenuCliente.Controls.Add(this.btnVerClientes);
            this.panelSubMenuCliente.Controls.Add(this.btnRegistrarCliente);
            this.panelSubMenuCliente.Location = new System.Drawing.Point(0, 361);
            this.panelSubMenuCliente.Name = "panelSubMenuCliente";
            this.panelSubMenuCliente.Size = new System.Drawing.Size(402, 143);
            this.panelSubMenuCliente.TabIndex = 2;
            this.panelSubMenuCliente.Visible = false;
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProyectos.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProyectos.Location = new System.Drawing.Point(0, 367);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(402, 70);
            this.btnProyectos.TabIndex = 1;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.UseVisualStyleBackColor = false;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClientes.Location = new System.Drawing.Point(0, 291);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(402, 70);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBarraTareas
            // 
            this.panelBarraTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelBarraTareas.Controls.Add(this.pictureBox2);
            this.panelBarraTareas.Controls.Add(this.pictureBox1);
            this.panelBarraTareas.Location = new System.Drawing.Point(0, 1);
            this.panelBarraTareas.Name = "panelBarraTareas";
            this.panelBarraTareas.Size = new System.Drawing.Size(1422, 30);
            this.panelBarraTareas.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoCRUD.Properties.Resources.info__1_;
            this.pictureBox2.Location = new System.Drawing.Point(39, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1382, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVerProyectos
            // 
            this.btnVerProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnVerProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerProyectos.FlatAppearance.BorderSize = 0;
            this.btnVerProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerProyectos.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProyectos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnVerProyectos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerProyectos.Image")));
            this.btnVerProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerProyectos.Location = new System.Drawing.Point(0, 69);
            this.btnVerProyectos.Name = "btnVerProyectos";
            this.btnVerProyectos.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btnVerProyectos.Size = new System.Drawing.Size(402, 70);
            this.btnVerProyectos.TabIndex = 3;
            this.btnVerProyectos.Text = "Ver Proyectos";
            this.btnVerProyectos.UseVisualStyleBackColor = false;
            this.btnVerProyectos.Click += new System.EventHandler(this.btnVerProyectos_Click);
            this.btnVerProyectos.MouseEnter += new System.EventHandler(this.btnVerProyectos_MouseEnter);
            this.btnVerProyectos.MouseLeave += new System.EventHandler(this.btnVerProyectos_MouseLeave);
            // 
            // btnCrearProyecto
            // 
            this.btnCrearProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnCrearProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearProyecto.FlatAppearance.BorderSize = 0;
            this.btnCrearProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearProyecto.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProyecto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCrearProyecto.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearProyecto.Image")));
            this.btnCrearProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearProyecto.Location = new System.Drawing.Point(0, 0);
            this.btnCrearProyecto.Name = "btnCrearProyecto";
            this.btnCrearProyecto.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btnCrearProyecto.Size = new System.Drawing.Size(402, 70);
            this.btnCrearProyecto.TabIndex = 2;
            this.btnCrearProyecto.Text = "Nuevo Proyecto";
            this.btnCrearProyecto.UseVisualStyleBackColor = false;
            this.btnCrearProyecto.Click += new System.EventHandler(this.btnCrearProyecto_Click);
            this.btnCrearProyecto.MouseEnter += new System.EventHandler(this.btnCrearProyecto_MouseEnter);
            this.btnCrearProyecto.MouseLeave += new System.EventHandler(this.btnCrearProyecto_MouseLeave);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnVerClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerClientes.FlatAppearance.BorderSize = 0;
            this.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerClientes.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerClientes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnVerClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnVerClientes.Image")));
            this.btnVerClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerClientes.Location = new System.Drawing.Point(0, 69);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btnVerClientes.Size = new System.Drawing.Size(402, 70);
            this.btnVerClientes.TabIndex = 3;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = false;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCliente.Image")));
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.btnRegistrarCliente.Size = new System.Drawing.Size(402, 70);
            this.btnRegistrarCliente.TabIndex = 2;
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Location = new System.Drawing.Point(0, -26);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(402, 316);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panelContenedor.Location = new System.Drawing.Point(402, 32);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1020, 992);
            this.panelContenedor.TabIndex = 3;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1422, 1024);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarraTareas);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelSubMenuProyectos.ResumeLayout(false);
            this.panelSubMenuCliente.ResumeLayout(false);
            this.panelBarraTareas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnCrearProyecto;
        private System.Windows.Forms.Button btnVerProyectos;
        private System.Windows.Forms.Panel panelSubMenuProyectos;
        private System.Windows.Forms.Panel panelSubMenuCliente;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Panel panelBarraTareas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

