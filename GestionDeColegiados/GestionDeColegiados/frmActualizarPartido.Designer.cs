
using System.Windows.Forms;

namespace GestionDeColegiados
{
    partial class frmCambiarEstadioPartido
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEncuentros = new System.Windows.Forms.ComboBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.cmbEstadios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGrupoColegiado = new System.Windows.Forms.ComboBox();
            this.dtpFechaEncuentro = new System.Windows.Forms.DateTimePicker();
            this.lblEquipoVisitante = new System.Windows.Forms.Label();
            this.lblEquipoLocal = new System.Windows.Forms.Label();
            this.lblvs = new System.Windows.Forms.Label();
            this.ptbEquipoVisitante = new System.Windows.Forms.PictureBox();
            this.ptbEquipoLocal = new System.Windows.Forms.PictureBox();
            this.lblFechaMenor = new System.Windows.Forms.Label();
            this.txtColegiados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(309, 120);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ACTUALIZAR PARTIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(178, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "PARTIDOS:";
            // 
            // cmbEncuentros
            // 
            this.cmbEncuentros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncuentros.FormattingEnabled = true;
            this.cmbEncuentros.Location = new System.Drawing.Point(360, 199);
            this.cmbEncuentros.Name = "cmbEncuentros";
            this.cmbEncuentros.Size = new System.Drawing.Size(373, 24);
            this.cmbEncuentros.TabIndex = 4;
            this.cmbEncuentros.SelectedIndexChanged += new System.EventHandler(this.cmbEncuentros_SelectedIndexChanged);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(397, 639);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(145, 49);
            this.btnGuardarCambios.TabIndex = 23;
            this.btnGuardarCambios.Text = "GUARDAR";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // cmbEstadios
            // 
            this.cmbEstadios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadios.FormattingEnabled = true;
            this.cmbEstadios.Location = new System.Drawing.Point(447, 571);
            this.cmbEstadios.Name = "cmbEstadios";
            this.cmbEstadios.Size = new System.Drawing.Size(121, 24);
            this.cmbEstadios.TabIndex = 38;
            this.cmbEstadios.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(335, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Estadio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(257, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Hora Encuentro:";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(447, 442);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(200, 22);
            this.dtpHora.TabIndex = 35;
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHoraEncuentro_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(214, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Grupo de Colegiado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(213, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fecha de Encuentro:";
            // 
            // cmbGrupoColegiado
            // 
            this.cmbGrupoColegiado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoColegiado.FormattingEnabled = true;
            this.cmbGrupoColegiado.Location = new System.Drawing.Point(447, 490);
            this.cmbGrupoColegiado.Name = "cmbGrupoColegiado";
            this.cmbGrupoColegiado.Size = new System.Drawing.Size(121, 24);
            this.cmbGrupoColegiado.TabIndex = 32;
            this.cmbGrupoColegiado.SelectedIndexChanged += new System.EventHandler(this.cmbColegiados_SelectedIndexChanged);
            // 
            // dtpFechaEncuentro
            // 
            this.dtpFechaEncuentro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEncuentro.Location = new System.Drawing.Point(447, 386);
            this.dtpFechaEncuentro.Name = "dtpFechaEncuentro";
            this.dtpFechaEncuentro.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEncuentro.TabIndex = 31;
            this.dtpFechaEncuentro.ValueChanged += new System.EventHandler(this.dtpFechaEncuentro_ValueChanged);
            // 
            // lblEquipoVisitante
            // 
            this.lblEquipoVisitante.AutoSize = true;
            this.lblEquipoVisitante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoVisitante.Location = new System.Drawing.Point(537, 286);
            this.lblEquipoVisitante.Name = "lblEquipoVisitante";
            this.lblEquipoVisitante.Size = new System.Drawing.Size(138, 20);
            this.lblEquipoVisitante.TabIndex = 30;
            this.lblEquipoVisitante.Text = "equipoVisitante";
            // 
            // lblEquipoLocal
            // 
            this.lblEquipoLocal.AutoSize = true;
            this.lblEquipoLocal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoLocal.Location = new System.Drawing.Point(250, 286);
            this.lblEquipoLocal.Name = "lblEquipoLocal";
            this.lblEquipoLocal.Size = new System.Drawing.Size(110, 20);
            this.lblEquipoLocal.TabIndex = 29;
            this.lblEquipoLocal.Text = "equipoLocal";
            // 
            // lblvs
            // 
            this.lblvs.AutoSize = true;
            this.lblvs.BackColor = System.Drawing.Color.Transparent;
            this.lblvs.Font = new System.Drawing.Font("Impact", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvs.ForeColor = System.Drawing.Color.Black;
            this.lblvs.Location = new System.Drawing.Point(420, 255);
            this.lblvs.Name = "lblvs";
            this.lblvs.Size = new System.Drawing.Size(73, 56);
            this.lblvs.TabIndex = 28;
            this.lblvs.Text = "VS";
            // 
            // ptbEquipoVisitante
            // 
            this.ptbEquipoVisitante.Image = global::GestionDeColegiados.Properties.Resources.visitante;
            this.ptbEquipoVisitante.Location = new System.Drawing.Point(491, 232);
            this.ptbEquipoVisitante.Name = "ptbEquipoVisitante";
            this.ptbEquipoVisitante.Size = new System.Drawing.Size(242, 135);
            this.ptbEquipoVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEquipoVisitante.TabIndex = 27;
            this.ptbEquipoVisitante.TabStop = false;
            // 
            // ptbEquipoLocal
            // 
            this.ptbEquipoLocal.Image = global::GestionDeColegiados.Properties.Resources.Local;
            this.ptbEquipoLocal.Location = new System.Drawing.Point(184, 232);
            this.ptbEquipoLocal.Name = "ptbEquipoLocal";
            this.ptbEquipoLocal.Size = new System.Drawing.Size(242, 135);
            this.ptbEquipoLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEquipoLocal.TabIndex = 26;
            this.ptbEquipoLocal.TabStop = false;
            // 
            // lblFechaMenor
            // 
            this.lblFechaMenor.AutoSize = true;
            this.lblFechaMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMenor.ForeColor = System.Drawing.Color.Orange;
            this.lblFechaMenor.Location = new System.Drawing.Point(215, 366);
            this.lblFechaMenor.Name = "lblFechaMenor";
            this.lblFechaMenor.Size = new System.Drawing.Size(332, 18);
            this.lblFechaMenor.TabIndex = 40;
            this.lblFechaMenor.Text = "Por favor seleccione una fecha mayor a la actual.";
            this.lblFechaMenor.Visible = false;
            // 
            // txtColegiados
            // 
            this.txtColegiados.Enabled = false;
            this.txtColegiados.Location = new System.Drawing.Point(581, 489);
            this.txtColegiados.Multiline = true;
            this.txtColegiados.Name = "txtColegiados";
            this.txtColegiados.Size = new System.Drawing.Size(168, 75);
            this.txtColegiados.TabIndex = 41;
            // 
            // frmCambiarEstadioPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(959, 892);
            this.Controls.Add(this.txtColegiados);
            this.Controls.Add(this.lblFechaMenor);
            this.Controls.Add(this.cmbEstadios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGrupoColegiado);
            this.Controls.Add(this.dtpFechaEncuentro);
            this.Controls.Add(this.lblEquipoVisitante);
            this.Controls.Add(this.lblEquipoLocal);
            this.Controls.Add(this.lblvs);
            this.Controls.Add(this.ptbEquipoVisitante);
            this.Controls.Add(this.ptbEquipoLocal);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.cmbEncuentros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarEstadioPartido";
            this.Text = "frmCambiarGrupoColegiados";
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipoLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEncuentros;
        private System.Windows.Forms.Button btnGuardarCambios;
        private ComboBox cmbEstadios;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpHora;
        private Label label7;
        private Label label8;
        private ComboBox cmbGrupoColegiado;
        private DateTimePicker dtpFechaEncuentro;
        private Label lblEquipoVisitante;
        private Label lblEquipoLocal;
        private Label lblvs;
        private PictureBox ptbEquipoVisitante;
        private PictureBox ptbEquipoLocal;
        private Label lblFechaMenor;
        private TextBox txtColegiados;

        public ComboBox CmbEncuentros { get => cmbEncuentros; set => cmbEncuentros = value; }
    }
}