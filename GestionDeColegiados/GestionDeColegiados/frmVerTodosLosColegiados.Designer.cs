
namespace GestionDeColegiados
{
    partial class frmVerTodosLosColegiados
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarColegiados = new System.Windows.Forms.DataGridView();
            this.colJuezCentral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsistente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsistente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuartoArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarColegiados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(167, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "COLEGIADOS";
            // 
            // dgvListarColegiados
            // 
            this.dgvListarColegiados.AllowUserToAddRows = false;
            this.dgvListarColegiados.AllowUserToDeleteRows = false;
            this.dgvListarColegiados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarColegiados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJuezCentral,
            this.colAsistente1,
            this.colAsistente2,
            this.colCuartoArbitro});
            this.dgvListarColegiados.Location = new System.Drawing.Point(11, 87);
            this.dgvListarColegiados.Name = "dgvListarColegiados";
            this.dgvListarColegiados.ReadOnly = true;
            this.dgvListarColegiados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListarColegiados.Size = new System.Drawing.Size(450, 183);
            this.dgvListarColegiados.TabIndex = 3;
            // 
            // colJuezCentral
            // 
            this.colJuezCentral.HeaderText = "Juez Central";
            this.colJuezCentral.Name = "colJuezCentral";
            this.colJuezCentral.ReadOnly = true;
            // 
            // colAsistente1
            // 
            this.colAsistente1.HeaderText = "Asistente 1";
            this.colAsistente1.Name = "colAsistente1";
            this.colAsistente1.ReadOnly = true;
            // 
            // colAsistente2
            // 
            this.colAsistente2.HeaderText = "Asistente 2";
            this.colAsistente2.Name = "colAsistente2";
            this.colAsistente2.ReadOnly = true;
            // 
            // colCuartoArbitro
            // 
            this.colCuartoArbitro.HeaderText = "Cuarto Arbitro";
            this.colCuartoArbitro.Name = "colCuartoArbitro";
            this.colCuartoArbitro.ReadOnly = true;
            // 
            // frmVerTodosLosColegiados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(480, 555);
            this.Controls.Add(this.dgvListarColegiados);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVerTodosLosColegiados";
            this.Text = "frmVerTodosLosColegiados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarColegiados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarColegiados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJuezCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuartoArbitro;
    }
}