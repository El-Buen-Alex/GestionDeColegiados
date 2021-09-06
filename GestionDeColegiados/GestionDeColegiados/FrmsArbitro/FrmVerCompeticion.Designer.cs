
namespace GestionDeColegiados.FrmsArbitro
{
    partial class FrmVerCompeticion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCompeticion = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGolFavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGolContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGolDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEINICIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEINICIARTODALACOMPETENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEINICIARRESULTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tERMINARCOMPETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINALIZARCOMPETENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARBAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARBAJACOMPETENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompeticion)).BeginInit();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(189, 116);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(442, 32);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "LIGA-POSICIONES ACTUALES";
            // 
            // dgvCompeticion
            // 
            this.dgvCompeticion.AllowUserToAddRows = false;
            this.dgvCompeticion.AllowUserToDeleteRows = false;
            this.dgvCompeticion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompeticion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompeticion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.dgvCompeticion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompeticion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompeticion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompeticion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCompeticion.ColumnHeadersHeight = 35;
            this.dgvCompeticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCompeticion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colEquipo,
            this.colGolFavor,
            this.colGolContra,
            this.colGolDiferencia,
            this.colPuntos});
            this.dgvCompeticion.EnableHeadersVisualStyles = false;
            this.dgvCompeticion.Location = new System.Drawing.Point(165, 249);
            this.dgvCompeticion.Name = "dgvCompeticion";
            this.dgvCompeticion.ReadOnly = true;
            this.dgvCompeticion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompeticion.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCompeticion.RowHeadersVisible = false;
            this.dgvCompeticion.RowHeadersWidth = 5;
            this.dgvCompeticion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.dgvCompeticion.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCompeticion.RowTemplate.Height = 24;
            this.dgvCompeticion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCompeticion.Size = new System.Drawing.Size(496, 328);
            this.dgvCompeticion.TabIndex = 33;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "Posicion";
            this.colNum.MinimumWidth = 6;
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            this.colNum.Width = 88;
            // 
            // colEquipo
            // 
            this.colEquipo.HeaderText = "EQUIPO";
            this.colEquipo.MinimumWidth = 6;
            this.colEquipo.Name = "colEquipo";
            this.colEquipo.ReadOnly = true;
            this.colEquipo.Width = 88;
            // 
            // colGolFavor
            // 
            this.colGolFavor.HeaderText = "GF";
            this.colGolFavor.MinimumWidth = 6;
            this.colGolFavor.Name = "colGolFavor";
            this.colGolFavor.ReadOnly = true;
            this.colGolFavor.Width = 54;
            // 
            // colGolContra
            // 
            this.colGolContra.HeaderText = "GC";
            this.colGolContra.MinimumWidth = 6;
            this.colGolContra.Name = "colGolContra";
            this.colGolContra.ReadOnly = true;
            this.colGolContra.Width = 55;
            // 
            // colGolDiferencia
            // 
            this.colGolDiferencia.HeaderText = "GD";
            this.colGolDiferencia.MinimumWidth = 6;
            this.colGolDiferencia.Name = "colGolDiferencia";
            this.colGolDiferencia.ReadOnly = true;
            this.colGolDiferencia.Width = 56;
            // 
            // colPuntos
            // 
            this.colPuntos.HeaderText = "PUNTOS";
            this.colPuntos.MinimumWidth = 6;
            this.colPuntos.Name = "colPuntos";
            this.colPuntos.ReadOnly = true;
            this.colPuntos.Width = 93;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.Location = new System.Drawing.Point(272, 173);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(319, 17);
            this.lblAdvertencia.TabIndex = 34;
            this.lblAdvertencia.Text = "AÚN NO SE HA JUGADO ALGÚN PARTIDO";
            this.lblAdvertencia.Visible = false;
            // 
            // msAdmin
            // 
            this.msAdmin.Dock = System.Windows.Forms.DockStyle.None;
            this.msAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem});
            this.msAdmin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msAdmin.Location = new System.Drawing.Point(512, 216);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(276, 28);
            this.msAdmin.TabIndex = 35;
            this.msAdmin.Text = "menuStrip1";
            this.msAdmin.Visible = false;
            // 
            // aDMINISTRARToolStripMenuItem
            // 
            this.aDMINISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEINICIARToolStripMenuItem,
            this.tERMINARCOMPETEToolStripMenuItem,
            this.dARBAJAToolStripMenuItem});
            this.aDMINISTRARToolStripMenuItem.Name = "aDMINISTRARToolStripMenuItem";
            this.aDMINISTRARToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.aDMINISTRARToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // rEINICIARToolStripMenuItem
            // 
            this.rEINICIARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEINICIARTODALACOMPETENCIAToolStripMenuItem,
            this.rEINICIARRESULTADOSToolStripMenuItem});
            this.rEINICIARToolStripMenuItem.Name = "rEINICIARToolStripMenuItem";
            this.rEINICIARToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.rEINICIARToolStripMenuItem.Text = "REINICIAR COMPETENCIA";
            // 
            // rEINICIARTODALACOMPETENCIAToolStripMenuItem
            // 
            this.rEINICIARTODALACOMPETENCIAToolStripMenuItem.Enabled = false;
            this.rEINICIARTODALACOMPETENCIAToolStripMenuItem.Name = "rEINICIARTODALACOMPETENCIAToolStripMenuItem";
            this.rEINICIARTODALACOMPETENCIAToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.rEINICIARTODALACOMPETENCIAToolStripMenuItem.Text = "REINICIAR TODA LA COMPETENCIA";
            this.rEINICIARTODALACOMPETENCIAToolStripMenuItem.Click += new System.EventHandler(this.rEINICIARTODALACOMPETENCIAToolStripMenuItem_Click);
            // 
            // rEINICIARRESULTADOSToolStripMenuItem
            // 
            this.rEINICIARRESULTADOSToolStripMenuItem.Enabled = false;
            this.rEINICIARRESULTADOSToolStripMenuItem.Name = "rEINICIARRESULTADOSToolStripMenuItem";
            this.rEINICIARRESULTADOSToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.rEINICIARRESULTADOSToolStripMenuItem.Text = "REINICIAR RESULTADOS";
            this.rEINICIARRESULTADOSToolStripMenuItem.Click += new System.EventHandler(this.rEINICIARRESULTADOSToolStripMenuItem_Click);
            // 
            // tERMINARCOMPETEToolStripMenuItem
            // 
            this.tERMINARCOMPETEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fINALIZARCOMPETENCIAToolStripMenuItem});
            this.tERMINARCOMPETEToolStripMenuItem.Name = "tERMINARCOMPETEToolStripMenuItem";
            this.tERMINARCOMPETEToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.tERMINARCOMPETEToolStripMenuItem.Text = "TERMINAR COMPETENCIA";
            // 
            // fINALIZARCOMPETENCIAToolStripMenuItem
            // 
            this.fINALIZARCOMPETENCIAToolStripMenuItem.Enabled = false;
            this.fINALIZARCOMPETENCIAToolStripMenuItem.Name = "fINALIZARCOMPETENCIAToolStripMenuItem";
            this.fINALIZARCOMPETENCIAToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.fINALIZARCOMPETENCIAToolStripMenuItem.Text = "FINALIZAR COMPETENCIA";
            this.fINALIZARCOMPETENCIAToolStripMenuItem.Click += new System.EventHandler(this.fINALIZARCOMPETENCIAToolStripMenuItem_Click);
            // 
            // dARBAJAToolStripMenuItem
            // 
            this.dARBAJAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dARBAJACOMPETENCIAToolStripMenuItem});
            this.dARBAJAToolStripMenuItem.Name = "dARBAJAToolStripMenuItem";
            this.dARBAJAToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.dARBAJAToolStripMenuItem.Text = "DAR BAJA";
            // 
            // dARBAJACOMPETENCIAToolStripMenuItem
            // 
            this.dARBAJACOMPETENCIAToolStripMenuItem.Enabled = false;
            this.dARBAJACOMPETENCIAToolStripMenuItem.Name = "dARBAJACOMPETENCIAToolStripMenuItem";
            this.dARBAJACOMPETENCIAToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.dARBAJACOMPETENCIAToolStripMenuItem.Text = "DAR BAJA COMPETENCIA";
            this.dARBAJACOMPETENCIAToolStripMenuItem.Click += new System.EventHandler(this.DAR_BAJA_RCOMPETENCIAToolStripMenuItem_Click);
            // 
            // FrmVerCompeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(777, 762);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.dgvCompeticion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.msAdmin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerCompeticion";
            this.Text = "FrmVerCompeticion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompeticion)).EndInit();
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCompeticion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGolFavor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGolContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGolDiferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntos;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEINICIARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEINICIARTODALACOMPETENCIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEINICIARRESULTADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tERMINARCOMPETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINALIZARCOMPETENCIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dARBAJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dARBAJACOMPETENCIAToolStripMenuItem;
    }
}