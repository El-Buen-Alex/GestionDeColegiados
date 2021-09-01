namespace GestionDeColegiados.FrmsColegiado {
    partial class frmElimAgregarArbitro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.PanelBarraTitulo.Controls.Add(this.pbCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(507, 28);
            this.PanelBarraTitulo.TabIndex = 95;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::GestionDeColegiados.Properties.Resources.cerrarVentana;
            this.pbCerrar.Location = new System.Drawing.Point(475, 4);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(26, 20);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 2;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            this.pbCerrar.MouseEnter += new System.EventHandler(this.pbCerrar_MouseEnter);
            this.pbCerrar.MouseLeave += new System.EventHandler(this.pbCerrar_MouseLeave);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(97, 128);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(218, 20);
            this.lblAgregar.TabIndex = 110;
            this.lblAgregar.Text = "Usted está agregando un ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Silver;
            this.btnAgregar.Location = new System.Drawing.Point(308, 502);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 31);
            this.btnAgregar.TabIndex = 109;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 108;
            this.label7.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 107;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 106;
            this.label9.Text = "Domicilio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(89, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 105;
            this.label10.Text = "Apellido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(89, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 104;
            this.label11.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "Cédula:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(186, 446);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(222, 20);
            this.txtTelefono.TabIndex = 102;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumeros_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 395);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 101;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(186, 341);
            this.txtDomicilio.MaxLength = 25;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(223, 20);
            this.txtDomicilio.TabIndex = 100;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarLetras_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(186, 288);
            this.txtApellido.MaxLength = 25;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(223, 20);
            this.txtApellido.TabIndex = 99;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarLetras_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 237);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 20);
            this.txtNombre.TabIndex = 98;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarLetras_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(186, 187);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(222, 20);
            this.txtCedula.TabIndex = 97;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumeros_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 26);
            this.label2.TabIndex = 96;
            this.label2.Text = "AGREGAR ÁRBITRO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.Location = new System.Drawing.Point(87, 502);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 31);
            this.btnCancelar.TabIndex = 111;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(322, 133);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 13);
            this.lblID.TabIndex = 112;
            this.lblID.Text = "id";
            this.lblID.Visible = false;
            // 
            // frmElimAgregarArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(507, 566);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelBarraTitulo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmElimAgregarArbitro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmElimAgregarArbitro";
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblID;
    }
}