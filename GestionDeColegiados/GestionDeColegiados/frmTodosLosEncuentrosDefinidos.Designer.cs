
namespace GestionDeColegiados
{
    partial class frmTodosLosEncuentrosDefinidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEncuentros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEquipoVisitante = new System.Windows.Forms.Label();
            this.lblEquipoLocal = new System.Windows.Forms.Label();
            this.pbTupla = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.lblColegiados = new System.Windows.Forms.Label();
            this.lblTituloColegiados = new System.Windows.Forms.Label();
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarBajaEncuentroDefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbTupla)).BeginInit();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCUENTROS DEFINIDOS\r\nPOR JUGAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbEncuentros
            // 
            this.cmbEncuentros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncuentros.FormattingEnabled = true;
            this.cmbEncuentros.Location = new System.Drawing.Point(220, 176);
            this.cmbEncuentros.Name = "cmbEncuentros";
            this.cmbEncuentros.Size = new System.Drawing.Size(318, 24);
            this.cmbEncuentros.TabIndex = 6;
            this.cmbEncuentros.SelectedIndexChanged += new System.EventHandler(this.cmbEncuentros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "PARTIDOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(142, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "ESCOJA EL PARTIDO AL CUAL DESEA \r\nVISUALIZAR SU INFORMACIÓN\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEquipoVisitante
            // 
            this.lblEquipoVisitante.AutoSize = true;
            this.lblEquipoVisitante.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoVisitante.Location = new System.Drawing.Point(405, 315);
            this.lblEquipoVisitante.Name = "lblEquipoVisitante";
            this.lblEquipoVisitante.Size = new System.Drawing.Size(123, 20);
            this.lblEquipoVisitante.TabIndex = 12;
            this.lblEquipoVisitante.Text = "equipoVisitante";
            this.lblEquipoVisitante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEquipoLocal
            // 
            this.lblEquipoLocal.AutoSize = true;
            this.lblEquipoLocal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoLocal.Location = new System.Drawing.Point(89, 315);
            this.lblEquipoLocal.Name = "lblEquipoLocal";
            this.lblEquipoLocal.Size = new System.Drawing.Size(99, 20);
            this.lblEquipoLocal.TabIndex = 11;
            this.lblEquipoLocal.Text = "equipoLocal";
            this.lblEquipoLocal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbTupla
            // 
            this.pbTupla.Image = global::GestionDeColegiados.Properties.Resources.tupla;
            this.pbTupla.Location = new System.Drawing.Point(1, 206);
            this.pbTupla.Name = "pbTupla";
            this.pbTupla.Size = new System.Drawing.Size(621, 272);
            this.pbTupla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTupla.TabIndex = 13;
            this.pbTupla.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(150, 363);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 18);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "FECHA";
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstadio.Location = new System.Drawing.Point(262, 266);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(95, 20);
            this.lblEstadio.TabIndex = 21;
            this.lblEstadio.Text = " ESTADIO";
            this.lblEstadio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblColegiados
            // 
            this.lblColegiados.AutoSize = true;
            this.lblColegiados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColegiados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColegiados.Location = new System.Drawing.Point(200, 481);
            this.lblColegiados.Name = "lblColegiados";
            this.lblColegiados.Size = new System.Drawing.Size(71, 20);
            this.lblColegiados.TabIndex = 22;
            this.lblColegiados.Text = "FECHA";
            // 
            // lblTituloColegiados
            // 
            this.lblTituloColegiados.AutoSize = true;
            this.lblTituloColegiados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColegiados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTituloColegiados.Location = new System.Drawing.Point(198, 426);
            this.lblTituloColegiados.Name = "lblTituloColegiados";
            this.lblTituloColegiados.Size = new System.Drawing.Size(220, 32);
            this.lblTituloColegiados.TabIndex = 23;
            this.lblTituloColegiados.Text = "COLEGIADOS:";
            // 
            // msAdmin
            // 
            this.msAdmin.Dock = System.Windows.Forms.DockStyle.None;
            this.msAdmin.Enabled = false;
            this.msAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem});
            this.msAdmin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msAdmin.Location = new System.Drawing.Point(495, 9);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(276, 28);
            this.msAdmin.TabIndex = 36;
            this.msAdmin.Text = "menuStrip1";
            // 
            // aDMINISTRARToolStripMenuItem
            // 
            this.aDMINISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DarBajaEncuentroDefToolStripMenuItem});
            this.aDMINISTRARToolStripMenuItem.Name = "aDMINISTRARToolStripMenuItem";
            this.aDMINISTRARToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.aDMINISTRARToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // DarBajaEncuentroDefToolStripMenuItem
            // 
            this.DarBajaEncuentroDefToolStripMenuItem.Name = "DarBajaEncuentroDefToolStripMenuItem";
            this.DarBajaEncuentroDefToolStripMenuItem.Size = new System.Drawing.Size(360, 26);
            this.DarBajaEncuentroDefToolStripMenuItem.Text = "DAR DE BAJA ENCUENTROS DEFINIDOS";
            this.DarBajaEncuentroDefToolStripMenuItem.Click += new System.EventHandler(this.DarBajaEncuentroDefToolStripMenuItem_Click);
            // 
            // frmTodosLosEncuentrosDefinidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(625, 683);
            this.Controls.Add(this.msAdmin);
            this.Controls.Add(this.lblTituloColegiados);
            this.Controls.Add(this.lblColegiados);
            this.Controls.Add(this.lblEstadio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEquipoVisitante);
            this.Controls.Add(this.lblEquipoLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEncuentros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTupla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTodosLosEncuentrosDefinidos";
            this.Text = "frmTodosLosEncuentrosDefinidos";
            ((System.ComponentModel.ISupportInitialize)(this.pbTupla)).EndInit();
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEncuentros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEquipoVisitante;
        private System.Windows.Forms.Label lblEquipoLocal;
        private System.Windows.Forms.PictureBox pbTupla;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.Label lblColegiados;
        private System.Windows.Forms.Label lblTituloColegiados;
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarBajaEncuentroDefToolStripMenuItem;
    }
}