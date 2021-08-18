
namespace GestionDeColegiados
{
    partial class frmCambiarPartido
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
            this.lblEquipoVisitante = new System.Windows.Forms.Label();
            this.lblEquipoLocal = new System.Windows.Forms.Label();
            this.lblvs = new System.Windows.Forms.Label();
            this.ptbEquipoVisitante = new System.Windows.Forms.PictureBox();
            this.ptbEquipoLocal = new System.Windows.Forms.PictureBox();
            this.cmbEncuentros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.cmbEquipoLocal = new System.Windows.Forms.ComboBox();
            this.cmbEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.lblCambiar1 = new System.Windows.Forms.Label();
            this.lblCambiar2 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEquipoVisitante
            // 
            this.lblEquipoVisitante.AutoSize = true;
            this.lblEquipoVisitante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoVisitante.Location = new System.Drawing.Point(435, 312);
            this.lblEquipoVisitante.Name = "lblEquipoVisitante";
            this.lblEquipoVisitante.Size = new System.Drawing.Size(138, 20);
            this.lblEquipoVisitante.TabIndex = 48;
            this.lblEquipoVisitante.Text = "equipoVisitante";
            // 
            // lblEquipoLocal
            // 
            this.lblEquipoLocal.AutoSize = true;
            this.lblEquipoLocal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoLocal.Location = new System.Drawing.Point(99, 312);
            this.lblEquipoLocal.Name = "lblEquipoLocal";
            this.lblEquipoLocal.Size = new System.Drawing.Size(110, 20);
            this.lblEquipoLocal.TabIndex = 47;
            this.lblEquipoLocal.Text = "equipoLocal";
            // 
            // lblvs
            // 
            this.lblvs.AutoSize = true;
            this.lblvs.BackColor = System.Drawing.Color.Transparent;
            this.lblvs.Font = new System.Drawing.Font("Impact", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvs.ForeColor = System.Drawing.Color.Black;
            this.lblvs.Location = new System.Drawing.Point(293, 281);
            this.lblvs.Name = "lblvs";
            this.lblvs.Size = new System.Drawing.Size(73, 56);
            this.lblvs.TabIndex = 46;
            this.lblvs.Text = "VS";
            // 
            // ptbEquipoVisitante
            // 
            this.ptbEquipoVisitante.Image = global::GestionDeColegiados.Properties.Resources.visitante;
            this.ptbEquipoVisitante.Location = new System.Drawing.Point(389, 258);
            this.ptbEquipoVisitante.Name = "ptbEquipoVisitante";
            this.ptbEquipoVisitante.Size = new System.Drawing.Size(242, 135);
            this.ptbEquipoVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEquipoVisitante.TabIndex = 45;
            this.ptbEquipoVisitante.TabStop = false;
            // 
            // ptbEquipoLocal
            // 
            this.ptbEquipoLocal.Image = global::GestionDeColegiados.Properties.Resources.Local;
            this.ptbEquipoLocal.Location = new System.Drawing.Point(33, 258);
            this.ptbEquipoLocal.Name = "ptbEquipoLocal";
            this.ptbEquipoLocal.Size = new System.Drawing.Size(242, 135);
            this.ptbEquipoLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEquipoLocal.TabIndex = 44;
            this.ptbEquipoLocal.TabStop = false;
            // 
            // cmbEncuentros
            // 
            this.cmbEncuentros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncuentros.FormattingEnabled = true;
            this.cmbEncuentros.Location = new System.Drawing.Point(223, 175);
            this.cmbEncuentros.Name = "cmbEncuentros";
            this.cmbEncuentros.Size = new System.Drawing.Size(373, 24);
            this.cmbEncuentros.TabIndex = 43;
            this.cmbEncuentros.SelectedIndexChanged += new System.EventHandler(this.cmbEncuentros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 42;
            this.label2.Text = "PARTIDOS:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(163, 58);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 32);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "ACTUALIZAR PARTIDO";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrden.Location = new System.Drawing.Point(86, 118);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(487, 24);
            this.lblOrden.TabIndex = 59;
            this.lblOrden.Text = "SELECCIONE EL ENCUENTRO QUE DESEA CAMBIAR";
            // 
            // cmbEquipoLocal
            // 
            this.cmbEquipoLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoLocal.FormattingEnabled = true;
            this.cmbEquipoLocal.Location = new System.Drawing.Point(33, 436);
            this.cmbEquipoLocal.Name = "cmbEquipoLocal";
            this.cmbEquipoLocal.Size = new System.Drawing.Size(242, 24);
            this.cmbEquipoLocal.TabIndex = 60;
            this.cmbEquipoLocal.SelectionChangeCommitted += new System.EventHandler(this.cmbEquipoLocal_SelectionChangeCommitted);
            // 
            // cmbEquipoVisitante
            // 
            this.cmbEquipoVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoVisitante.FormattingEnabled = true;
            this.cmbEquipoVisitante.Location = new System.Drawing.Point(389, 436);
            this.cmbEquipoVisitante.Name = "cmbEquipoVisitante";
            this.cmbEquipoVisitante.Size = new System.Drawing.Size(242, 24);
            this.cmbEquipoVisitante.TabIndex = 61;
            this.cmbEquipoVisitante.SelectionChangeCommitted += new System.EventHandler(this.cmbEquipoVisitante_SelectionChangeCommitted);
            // 
            // lblCambiar1
            // 
            this.lblCambiar1.AutoSize = true;
            this.lblCambiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCambiar1.Location = new System.Drawing.Point(31, 409);
            this.lblCambiar1.Name = "lblCambiar1";
            this.lblCambiar1.Size = new System.Drawing.Size(94, 24);
            this.lblCambiar1.TabIndex = 62;
            this.lblCambiar1.Text = "CAMBIAR";
            // 
            // lblCambiar2
            // 
            this.lblCambiar2.AutoSize = true;
            this.lblCambiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCambiar2.Location = new System.Drawing.Point(385, 409);
            this.lblCambiar2.Name = "lblCambiar2";
            this.lblCambiar2.Size = new System.Drawing.Size(94, 24);
            this.lblCambiar2.TabIndex = 63;
            this.lblCambiar2.Text = "CAMBIAR";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(254, 552);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(145, 49);
            this.btnGuardarCambios.TabIndex = 64;
            this.btnGuardarCambios.Text = "GUARDAR";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // frmCambiarPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(656, 764);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblCambiar2);
            this.Controls.Add(this.lblCambiar1);
            this.Controls.Add(this.cmbEquipoVisitante);
            this.Controls.Add(this.cmbEquipoLocal);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblEquipoVisitante);
            this.Controls.Add(this.lblEquipoLocal);
            this.Controls.Add(this.lblvs);
            this.Controls.Add(this.ptbEquipoVisitante);
            this.Controls.Add(this.ptbEquipoLocal);
            this.Controls.Add(this.cmbEncuentros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarPartido";
            this.Text = "frmCambiarPartido";
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipoVisitante;
        private System.Windows.Forms.Label lblEquipoLocal;
        private System.Windows.Forms.Label lblvs;
        private System.Windows.Forms.PictureBox ptbEquipoVisitante;
        private System.Windows.Forms.PictureBox ptbEquipoLocal;
        private System.Windows.Forms.ComboBox cmbEncuentros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.ComboBox cmbEquipoLocal;
        private System.Windows.Forms.ComboBox cmbEquipoVisitante;
        private System.Windows.Forms.Label lblCambiar1;
        private System.Windows.Forms.Label lblCambiar2;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}