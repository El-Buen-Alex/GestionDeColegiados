﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCompeticion = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGolFavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGolContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGolDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompeticion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(76, 25);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompeticion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvCompeticion.Location = new System.Drawing.Point(52, 112);
            this.dgvCompeticion.Name = "dgvCompeticion";
            this.dgvCompeticion.ReadOnly = true;
            this.dgvCompeticion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompeticion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompeticion.RowHeadersVisible = false;
            this.dgvCompeticion.RowHeadersWidth = 5;
            this.dgvCompeticion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.dgvCompeticion.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.lblAdvertencia.Location = new System.Drawing.Point(159, 82);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(319, 17);
            this.lblAdvertencia.TabIndex = 34;
            this.lblAdvertencia.Text = "AÚN NO SE HA JUGADO ALGÚN PARTIDO";
            this.lblAdvertencia.Visible = false;
            // 
            // FrmVerCompeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(595, 624);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.dgvCompeticion);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerCompeticion";
            this.Text = "FrmVerCompeticion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompeticion)).EndInit();
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
    }
}