
namespace GestionDeColegiados.FrmsArbitro
{
    partial class FrmRegistrarResultado
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
            this.cmbEncuentros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblGolVisitante = new System.Windows.Forms.Label();
            this.lblGolLocal = new System.Windows.Forms.Label();
            this.lblPuntosLocal1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntosVisitante = new System.Windows.Forms.Label();
            this.txtGolesLocal = new System.Windows.Forms.TextBox();
            this.txtGolesVisitante = new System.Windows.Forms.TextBox();
            this.lblPuntosLocalResultado = new System.Windows.Forms.Label();
            this.lblPuntosVisitanteResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbEquipoVisitante = new System.Windows.Forms.PictureBox();
            this.ptbEquipoLocal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEquipoVisitante
            // 
            this.lblEquipoVisitante.AutoSize = true;
            this.lblEquipoVisitante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoVisitante.Location = new System.Drawing.Point(470, 261);
            this.lblEquipoVisitante.Name = "lblEquipoVisitante";
            this.lblEquipoVisitante.Size = new System.Drawing.Size(138, 20);
            this.lblEquipoVisitante.TabIndex = 38;
            this.lblEquipoVisitante.Text = "equipoVisitante";
            // 
            // lblEquipoLocal
            // 
            this.lblEquipoLocal.AutoSize = true;
            this.lblEquipoLocal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoLocal.Location = new System.Drawing.Point(183, 261);
            this.lblEquipoLocal.Name = "lblEquipoLocal";
            this.lblEquipoLocal.Size = new System.Drawing.Size(110, 20);
            this.lblEquipoLocal.TabIndex = 37;
            this.lblEquipoLocal.Text = "equipoLocal";
            // 
            // lblvs
            // 
            this.lblvs.AutoSize = true;
            this.lblvs.BackColor = System.Drawing.Color.Transparent;
            this.lblvs.Font = new System.Drawing.Font("Impact", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvs.ForeColor = System.Drawing.Color.Black;
            this.lblvs.Location = new System.Drawing.Point(353, 230);
            this.lblvs.Name = "lblvs";
            this.lblvs.Size = new System.Drawing.Size(73, 56);
            this.lblvs.TabIndex = 36;
            this.lblvs.Text = "VS";
            // 
            // cmbEncuentros
            // 
            this.cmbEncuentros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncuentros.FormattingEnabled = true;
            this.cmbEncuentros.Location = new System.Drawing.Point(293, 174);
            this.cmbEncuentros.Name = "cmbEncuentros";
            this.cmbEncuentros.Size = new System.Drawing.Size(373, 24);
            this.cmbEncuentros.TabIndex = 33;
            this.cmbEncuentros.SelectedIndexChanged += new System.EventHandler(this.cmbEncuentros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(111, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "PARTIDOS:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(101, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(581, 32);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "REGISTRAR RESULTADO DEL PARTIDO";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(319, 589);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(145, 49);
            this.btnGuardarCambios.TabIndex = 39;
            this.btnGuardarCambios.Text = "GUARDAR";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblGolVisitante
            // 
            this.lblGolVisitante.AutoSize = true;
            this.lblGolVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGolVisitante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGolVisitante.Location = new System.Drawing.Point(171, 415);
            this.lblGolVisitante.Name = "lblGolVisitante";
            this.lblGolVisitante.Size = new System.Drawing.Size(215, 25);
            this.lblGolVisitante.TabIndex = 40;
            this.lblGolVisitante.Text = "Goles Equipo Visitante:";
            // 
            // lblGolLocal
            // 
            this.lblGolLocal.AutoSize = true;
            this.lblGolLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGolLocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGolLocal.Location = new System.Drawing.Point(199, 374);
            this.lblGolLocal.Name = "lblGolLocal";
            this.lblGolLocal.Size = new System.Drawing.Size(187, 25);
            this.lblGolLocal.TabIndex = 41;
            this.lblGolLocal.Text = "Goles Equipo Local:";
            // 
            // lblPuntosLocal1
            // 
            this.lblPuntosLocal1.AutoSize = true;
            this.lblPuntosLocal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPuntosLocal1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntosLocal1.Location = new System.Drawing.Point(189, 452);
            this.lblPuntosLocal1.Name = "lblPuntosLocal1";
            this.lblPuntosLocal1.Size = new System.Drawing.Size(197, 25);
            this.lblPuntosLocal1.TabIndex = 42;
            this.lblPuntosLocal1.Text = "Puntos Equipo Local:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(323, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "COPA ";
            // 
            // lblPuntosVisitante
            // 
            this.lblPuntosVisitante.AutoSize = true;
            this.lblPuntosVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPuntosVisitante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntosVisitante.Location = new System.Drawing.Point(161, 489);
            this.lblPuntosVisitante.Name = "lblPuntosVisitante";
            this.lblPuntosVisitante.Size = new System.Drawing.Size(225, 25);
            this.lblPuntosVisitante.TabIndex = 44;
            this.lblPuntosVisitante.Text = "Puntos Equipo Visitante:";
            // 
            // txtGolesLocal
            // 
            this.txtGolesLocal.Location = new System.Drawing.Point(393, 376);
            this.txtGolesLocal.Name = "txtGolesLocal";
            this.txtGolesLocal.Size = new System.Drawing.Size(71, 22);
            this.txtGolesLocal.TabIndex = 45;
            this.txtGolesLocal.TextChanged += new System.EventHandler(this.txtGolesLocal_TextChanged);
            // 
            // txtGolesVisitante
            // 
            this.txtGolesVisitante.Location = new System.Drawing.Point(392, 419);
            this.txtGolesVisitante.Name = "txtGolesVisitante";
            this.txtGolesVisitante.Size = new System.Drawing.Size(72, 22);
            this.txtGolesVisitante.TabIndex = 46;
            this.txtGolesVisitante.TextChanged += new System.EventHandler(this.txtGolesVisitante_TextChanged);
            // 
            // lblPuntosLocalResultado
            // 
            this.lblPuntosLocalResultado.AutoSize = true;
            this.lblPuntosLocalResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPuntosLocalResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuntosLocalResultado.Location = new System.Drawing.Point(388, 452);
            this.lblPuntosLocalResultado.Name = "lblPuntosLocalResultado";
            this.lblPuntosLocalResultado.Size = new System.Drawing.Size(22, 25);
            this.lblPuntosLocalResultado.TabIndex = 47;
            this.lblPuntosLocalResultado.Text = "  ";
            // 
            // lblPuntosVisitanteResultado
            // 
            this.lblPuntosVisitanteResultado.AutoSize = true;
            this.lblPuntosVisitanteResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPuntosVisitanteResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuntosVisitanteResultado.Location = new System.Drawing.Point(392, 489);
            this.lblPuntosVisitanteResultado.Name = "lblPuntosVisitanteResultado";
            this.lblPuntosVisitanteResultado.Size = new System.Drawing.Size(22, 25);
            this.lblPuntosVisitanteResultado.TabIndex = 48;
            this.lblPuntosVisitanteResultado.Text = "  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(404, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(408, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "  ";
            // 
            // ptbEquipoVisitante
            // 
            this.ptbEquipoVisitante.Image = global::GestionDeColegiados.Properties.Resources.visitante;
            this.ptbEquipoVisitante.Location = new System.Drawing.Point(424, 207);
            this.ptbEquipoVisitante.Name = "ptbEquipoVisitante";
            this.ptbEquipoVisitante.Size = new System.Drawing.Size(242, 135);
            this.ptbEquipoVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEquipoVisitante.TabIndex = 35;
            this.ptbEquipoVisitante.TabStop = false;
            // 
            // ptbEquipoLocal
            // 
            this.ptbEquipoLocal.Image = global::GestionDeColegiados.Properties.Resources.Local;
            this.ptbEquipoLocal.Location = new System.Drawing.Point(117, 207);
            this.ptbEquipoLocal.Name = "ptbEquipoLocal";
            this.ptbEquipoLocal.Size = new System.Drawing.Size(242, 135);
            this.ptbEquipoLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEquipoLocal.TabIndex = 34;
            this.ptbEquipoLocal.TabStop = false;
            // 
            // FrmRegistrarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(777, 762);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPuntosVisitanteResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuntosLocalResultado);
            this.Controls.Add(this.txtGolesVisitante);
            this.Controls.Add(this.txtGolesLocal);
            this.Controls.Add(this.lblPuntosVisitante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntosLocal1);
            this.Controls.Add(this.lblGolLocal);
            this.Controls.Add(this.lblGolVisitante);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblEquipoVisitante);
            this.Controls.Add(this.lblEquipoLocal);
            this.Controls.Add(this.lblvs);
            this.Controls.Add(this.ptbEquipoVisitante);
            this.Controls.Add(this.ptbEquipoLocal);
            this.Controls.Add(this.cmbEncuentros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarResultado";
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
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblGolVisitante;
        private System.Windows.Forms.Label lblGolLocal;
        private System.Windows.Forms.Label lblPuntosLocal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntosVisitante;
        private System.Windows.Forms.TextBox txtGolesLocal;
        private System.Windows.Forms.TextBox txtGolesVisitante;
        private System.Windows.Forms.Label lblPuntosLocalResultado;
        private System.Windows.Forms.Label lblPuntosVisitanteResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}