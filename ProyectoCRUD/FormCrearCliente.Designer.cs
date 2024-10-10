namespace ProyectoCRUD
{
    partial class FormCrearCliente
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            txtTelefonoFCC = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            txtRedesSocialesFCC = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            txtApellidoFCC = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            txtNombreArtisticoFCC = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            txtNombreClienteFCC = new System.Windows.Forms.TextBox();
            lblNombreProyecto = new System.Windows.Forms.Label();
            btnAgregarDatosCliente = new System.Windows.Forms.Button();
            btnBorrarDatosCliente = new System.Windows.Forms.Button();
            listBoxCrearCliente = new System.Windows.Forms.ListBox();
            btnGuardarClienteFCC = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnAgregarDatosCliente);
            groupBox1.Controls.Add(btnBorrarDatosCliente);
            groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            groupBox1.Location = new System.Drawing.Point(10, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(854, 530);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menú Crear Cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(230, 71);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(380, 330);
            panel1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtTelefonoFCC);
            panel5.Controls.Add(label3);
            panel5.Location = new System.Drawing.Point(0, 179);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(380, 72);
            panel5.TabIndex = 5;
            // 
            // txtTelefonoFCC
            // 
            txtTelefonoFCC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtTelefonoFCC.ForeColor = System.Drawing.SystemColors.Control;
            txtTelefonoFCC.Location = new System.Drawing.Point(0, 32);
            txtTelefonoFCC.Name = "txtTelefonoFCC";
            txtTelefonoFCC.Size = new System.Drawing.Size(380, 23);
            txtTelefonoFCC.TabIndex = 4;
            txtTelefonoFCC.KeyPress += txtTelefonoFCC_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label3.Location = new System.Drawing.Point(3, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 17);
            label3.TabIndex = 3;
            label3.Text = "Telefono:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtRedesSocialesFCC);
            panel6.Controls.Add(label4);
            panel6.Location = new System.Drawing.Point(0, 248);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(380, 55);
            panel6.TabIndex = 5;
            // 
            // txtRedesSocialesFCC
            // 
            txtRedesSocialesFCC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtRedesSocialesFCC.ForeColor = System.Drawing.SystemColors.Control;
            txtRedesSocialesFCC.Location = new System.Drawing.Point(0, 28);
            txtRedesSocialesFCC.Name = "txtRedesSocialesFCC";
            txtRedesSocialesFCC.Size = new System.Drawing.Size(380, 23);
            txtRedesSocialesFCC.TabIndex = 2;
            txtRedesSocialesFCC.KeyPress += txtRedesSocialesFCC_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label4.Location = new System.Drawing.Point(3, 6);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 17);
            label4.TabIndex = 3;
            label4.Text = "Redes Sociales:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtApellidoFCC);
            panel3.Controls.Add(label1);
            panel3.Location = new System.Drawing.Point(0, 61);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(380, 64);
            panel3.TabIndex = 5;
            // 
            // txtApellidoFCC
            // 
            txtApellidoFCC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtApellidoFCC.ForeColor = System.Drawing.SystemColors.Control;
            txtApellidoFCC.Location = new System.Drawing.Point(0, 32);
            txtApellidoFCC.Name = "txtApellidoFCC";
            txtApellidoFCC.Size = new System.Drawing.Size(380, 23);
            txtApellidoFCC.TabIndex = 8;
            txtApellidoFCC.KeyPress += txtApellidoFCC_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label1.Location = new System.Drawing.Point(3, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 17);
            label1.TabIndex = 3;
            label1.Text = "Apellido:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtNombreArtisticoFCC);
            panel4.Location = new System.Drawing.Point(0, 121);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(380, 52);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.Location = new System.Drawing.Point(3, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 17);
            label2.TabIndex = 7;
            label2.Text = "Nombre Artistico:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreArtisticoFCC
            // 
            txtNombreArtisticoFCC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtNombreArtisticoFCC.ForeColor = System.Drawing.SystemColors.Control;
            txtNombreArtisticoFCC.Location = new System.Drawing.Point(0, 28);
            txtNombreArtisticoFCC.Name = "txtNombreArtisticoFCC";
            txtNombreArtisticoFCC.Size = new System.Drawing.Size(380, 23);
            txtNombreArtisticoFCC.TabIndex = 2;
            txtNombreArtisticoFCC.KeyPress += txtNombreArtisticoFCC_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNombreClienteFCC);
            panel2.Controls.Add(lblNombreProyecto);
            panel2.Location = new System.Drawing.Point(0, 6);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(380, 58);
            panel2.TabIndex = 4;
            // 
            // txtNombreClienteFCC
            // 
            txtNombreClienteFCC.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            txtNombreClienteFCC.ForeColor = System.Drawing.SystemColors.Control;
            txtNombreClienteFCC.Location = new System.Drawing.Point(0, 28);
            txtNombreClienteFCC.Name = "txtNombreClienteFCC";
            txtNombreClienteFCC.Size = new System.Drawing.Size(380, 23);
            txtNombreClienteFCC.TabIndex = 2;
            txtNombreClienteFCC.KeyPress += txtNombreClienteFCC_KeyPress;
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.AutoSize = true;
            lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblNombreProyecto.Location = new System.Drawing.Point(3, 4);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new System.Drawing.Size(132, 17);
            lblNombreProyecto.TabIndex = 3;
            lblNombreProyecto.Text = "Nombre del Cliente:";
            lblNombreProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregarDatosCliente
            // 
            btnAgregarDatosCliente.BackColor = System.Drawing.Color.DimGray;
            btnAgregarDatosCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregarDatosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAgregarDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAgregarDatosCliente.Location = new System.Drawing.Point(230, 407);
            btnAgregarDatosCliente.Name = "btnAgregarDatosCliente";
            btnAgregarDatosCliente.Size = new System.Drawing.Size(153, 42);
            btnAgregarDatosCliente.TabIndex = 1;
            btnAgregarDatosCliente.Text = "Agregar Datos";
            btnAgregarDatosCliente.UseVisualStyleBackColor = false;
            btnAgregarDatosCliente.Click += btnAgregarDatosCliente_Click;
            // 
            // btnBorrarDatosCliente
            // 
            btnBorrarDatosCliente.BackColor = System.Drawing.Color.DimGray;
            btnBorrarDatosCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBorrarDatosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBorrarDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBorrarDatosCliente.Location = new System.Drawing.Point(457, 407);
            btnBorrarDatosCliente.Name = "btnBorrarDatosCliente";
            btnBorrarDatosCliente.Size = new System.Drawing.Size(153, 42);
            btnBorrarDatosCliente.TabIndex = 0;
            btnBorrarDatosCliente.Text = "Borrar Datos";
            btnBorrarDatosCliente.UseVisualStyleBackColor = false;
            btnBorrarDatosCliente.Click += btnBorrarDatosCliente_Click;
            // 
            // listBoxCrearCliente
            // 
            listBoxCrearCliente.BackColor = System.Drawing.Color.FromArgb(64, 63, 62);
            listBoxCrearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            listBoxCrearCliente.ForeColor = System.Drawing.Color.White;
            listBoxCrearCliente.FormattingEnabled = true;
            listBoxCrearCliente.Location = new System.Drawing.Point(10, 558);
            listBoxCrearCliente.Name = "listBoxCrearCliente";
            listBoxCrearCliente.Size = new System.Drawing.Size(854, 116);
            listBoxCrearCliente.TabIndex = 2;
            // 
            // btnGuardarClienteFCC
            // 
            btnGuardarClienteFCC.BackColor = System.Drawing.Color.DimGray;
            btnGuardarClienteFCC.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardarClienteFCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGuardarClienteFCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnGuardarClienteFCC.ForeColor = System.Drawing.Color.White;
            btnGuardarClienteFCC.Location = new System.Drawing.Point(354, 702);
            btnGuardarClienteFCC.Name = "btnGuardarClienteFCC";
            btnGuardarClienteFCC.Size = new System.Drawing.Size(153, 42);
            btnGuardarClienteFCC.TabIndex = 6;
            btnGuardarClienteFCC.Text = "Guardar Cliente";
            btnGuardarClienteFCC.UseVisualStyleBackColor = false;
            // 
            // FormCrearCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
            ClientSize = new System.Drawing.Size(875, 739);
            Controls.Add(btnGuardarClienteFCC);
            Controls.Add(listBoxCrearCliente);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FormCrearCliente";
            Text = "FormCrearCliente";
            Load += FormCrearCliente_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtRedesSocialesFCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreArtisticoFCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombreClienteFCC;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Button btnAgregarDatosCliente;
        private System.Windows.Forms.Button btnBorrarDatosCliente;
        private System.Windows.Forms.ListBox listBoxCrearCliente;
        private System.Windows.Forms.Button btnGuardarClienteFCC;
        private System.Windows.Forms.TextBox txtTelefonoFCC;
        private System.Windows.Forms.TextBox txtApellidoFCC;
    }
}