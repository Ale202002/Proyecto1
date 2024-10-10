namespace ProyectoCRUD
{
    partial class FormVerCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBuscarClienteFVC = new System.Windows.Forms.TextBox();
            labelTitulo = new System.Windows.Forms.Label();
            dGVFormVerClientes = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel10 = new System.Windows.Forms.Panel();
            btnEditarFVC = new System.Windows.Forms.Button();
            btnGuardarFVC = new System.Windows.Forms.Button();
            btnCancelarFVC = new System.Windows.Forms.Button();
            btnEliminarFVC = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            txtRedesFVC = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            txtTelefonoFVC = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            txtApellidoFVC = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            txtNombreArtisticoFVC = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            txtNombreFVC = new System.Windows.Forms.TextBox();
            lblNombreProyecto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dGVFormVerClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscarClienteFVC
            // 
            txtBuscarClienteFVC.Location = new System.Drawing.Point(429, 16);
            txtBuscarClienteFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBuscarClienteFVC.Name = "txtBuscarClienteFVC";
            txtBuscarClienteFVC.Size = new System.Drawing.Size(201, 27);
            txtBuscarClienteFVC.TabIndex = 6;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = System.Drawing.Color.White;
            labelTitulo.Location = new System.Drawing.Point(284, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(116, 21);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "Buscar Cliente";
            // 
            // dGVFormVerClientes
            // 
            dGVFormVerClientes.BackgroundColor = System.Drawing.Color.FromArgb(64, 63, 62);
            dGVFormVerClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dGVFormVerClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVFormVerClientes.Location = new System.Drawing.Point(12, 60);
            dGVFormVerClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dGVFormVerClientes.Name = "dGVFormVerClientes";
            dGVFormVerClientes.RowHeadersWidth = 51;
            dGVFormVerClientes.RowTemplate.Height = 24;
            dGVFormVerClientes.Size = new System.Drawing.Size(976, 310);
            dGVFormVerClientes.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search__2_;
            pictureBox1.Location = new System.Drawing.Point(639, 20);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(16, 16);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel10);
            groupBox1.Controls.Add(panel1);
            groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            groupBox1.Location = new System.Drawing.Point(12, 386);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(976, 618);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            panel10.Controls.Add(btnEditarFVC);
            panel10.Controls.Add(btnGuardarFVC);
            panel10.Controls.Add(btnCancelarFVC);
            panel10.Controls.Add(btnEliminarFVC);
            panel10.Location = new System.Drawing.Point(627, 141);
            panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(233, 364);
            panel10.TabIndex = 7;
            // 
            // btnEditarFVC
            // 
            btnEditarFVC.BackColor = System.Drawing.Color.DimGray;
            btnEditarFVC.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditarFVC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEditarFVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnEditarFVC.Location = new System.Drawing.Point(29, 32);
            btnEditarFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEditarFVC.Name = "btnEditarFVC";
            btnEditarFVC.Size = new System.Drawing.Size(175, 56);
            btnEditarFVC.TabIndex = 6;
            btnEditarFVC.Text = "Editar";
            btnEditarFVC.UseVisualStyleBackColor = false;
            // 
            // btnGuardarFVC
            // 
            btnGuardarFVC.BackColor = System.Drawing.Color.DimGray;
            btnGuardarFVC.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardarFVC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGuardarFVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnGuardarFVC.Location = new System.Drawing.Point(29, 204);
            btnGuardarFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGuardarFVC.Name = "btnGuardarFVC";
            btnGuardarFVC.Size = new System.Drawing.Size(175, 56);
            btnGuardarFVC.TabIndex = 5;
            btnGuardarFVC.Text = "Guardar";
            btnGuardarFVC.UseVisualStyleBackColor = false;
            // 
            // btnCancelarFVC
            // 
            btnCancelarFVC.BackColor = System.Drawing.Color.DimGray;
            btnCancelarFVC.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelarFVC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancelarFVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelarFVC.Location = new System.Drawing.Point(29, 286);
            btnCancelarFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelarFVC.Name = "btnCancelarFVC";
            btnCancelarFVC.Size = new System.Drawing.Size(175, 56);
            btnCancelarFVC.TabIndex = 0;
            btnCancelarFVC.Text = "Cancelar";
            btnCancelarFVC.UseVisualStyleBackColor = false;
            // 
            // btnEliminarFVC
            // 
            btnEliminarFVC.BackColor = System.Drawing.Color.DimGray;
            btnEliminarFVC.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminarFVC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEliminarFVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnEliminarFVC.Location = new System.Drawing.Point(29, 120);
            btnEliminarFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminarFVC.Name = "btnEliminarFVC";
            btnEliminarFVC.Size = new System.Drawing.Size(175, 56);
            btnEliminarFVC.TabIndex = 1;
            btnEliminarFVC.Text = "Eliminar";
            btnEliminarFVC.UseVisualStyleBackColor = false;
            btnEliminarFVC.Click += btnEliminarFVC_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(98, 141);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(434, 369);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtRedesFVC);
            panel6.Controls.Add(label4);
            panel6.Location = new System.Drawing.Point(0, 286);
            panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(434, 70);
            panel6.TabIndex = 5;
            // 
            // txtRedesFVC
            // 
            txtRedesFVC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtRedesFVC.ForeColor = System.Drawing.SystemColors.Control;
            txtRedesFVC.Location = new System.Drawing.Point(0, 38);
            txtRedesFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtRedesFVC.Name = "txtRedesFVC";
            txtRedesFVC.Size = new System.Drawing.Size(434, 27);
            txtRedesFVC.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.Location = new System.Drawing.Point(3, 8);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 20);
            label4.TabIndex = 3;
            label4.Text = "Redes Sociales:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtTelefonoFVC);
            panel5.Controls.Add(label3);
            panel5.Location = new System.Drawing.Point(0, 216);
            panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(434, 70);
            panel5.TabIndex = 5;
            // 
            // txtTelefonoFVC
            // 
            txtTelefonoFVC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtTelefonoFVC.ForeColor = System.Drawing.SystemColors.Control;
            txtTelefonoFVC.Location = new System.Drawing.Point(0, 41);
            txtTelefonoFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefonoFVC.Name = "txtTelefonoFVC";
            txtTelefonoFVC.Size = new System.Drawing.Size(434, 27);
            txtTelefonoFVC.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(3, 8);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Teléfono:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtApellidoFVC);
            panel3.Controls.Add(label1);
            panel3.Location = new System.Drawing.Point(0, 70);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(434, 70);
            panel3.TabIndex = 5;
            // 
            // txtApellidoFVC
            // 
            txtApellidoFVC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtApellidoFVC.ForeColor = System.Drawing.SystemColors.Control;
            txtApellidoFVC.Location = new System.Drawing.Point(0, 38);
            txtApellidoFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtApellidoFVC.Name = "txtApellidoFVC";
            txtApellidoFVC.Size = new System.Drawing.Size(434, 27);
            txtApellidoFVC.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(3, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellido:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtNombreArtisticoFVC);
            panel4.Location = new System.Drawing.Point(0, 148);
            panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(434, 70);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.Location = new System.Drawing.Point(3, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre Artistico:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreArtisticoFVC
            // 
            txtNombreArtisticoFVC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtNombreArtisticoFVC.ForeColor = System.Drawing.SystemColors.Control;
            txtNombreArtisticoFVC.Location = new System.Drawing.Point(0, 38);
            txtNombreArtisticoFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombreArtisticoFVC.Name = "txtNombreArtisticoFVC";
            txtNombreArtisticoFVC.Size = new System.Drawing.Size(434, 27);
            txtNombreArtisticoFVC.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNombreFVC);
            panel2.Controls.Add(lblNombreProyecto);
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(434, 70);
            panel2.TabIndex = 4;
            // 
            // txtNombreFVC
            // 
            txtNombreFVC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtNombreFVC.ForeColor = System.Drawing.SystemColors.Control;
            txtNombreFVC.Location = new System.Drawing.Point(0, 38);
            txtNombreFVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombreFVC.Name = "txtNombreFVC";
            txtNombreFVC.Size = new System.Drawing.Size(434, 27);
            txtNombreFVC.TabIndex = 2;
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.AutoSize = true;
            lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblNombreProyecto.Location = new System.Drawing.Point(3, 5);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new System.Drawing.Size(73, 20);
            lblNombreProyecto.TabIndex = 3;
            lblNombreProyecto.Text = "Nombre:";
            lblNombreProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblNombreProyecto.Click += lblNombreProyecto_Click;
            // 
            // FormVerCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
            ClientSize = new System.Drawing.Size(1000, 1019);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscarClienteFVC);
            Controls.Add(labelTitulo);
            Controls.Add(dGVFormVerClientes);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormVerCliente";
            Text = "FormVerCliente";
            Load += FormVerCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dGVFormVerClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarClienteFVC;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dGVFormVerClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnEditarFVC;
        private System.Windows.Forms.Button btnGuardarFVC;
        private System.Windows.Forms.Button btnCancelarFVC;
        private System.Windows.Forms.Button btnEliminarFVC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtRedesFVC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTelefonoFVC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtApellidoFVC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreArtisticoFVC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombreFVC;
        private System.Windows.Forms.Label lblNombreProyecto;
    }
}