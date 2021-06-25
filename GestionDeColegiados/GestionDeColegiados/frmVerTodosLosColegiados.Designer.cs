
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJuezCentral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsistente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsistente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuartoArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colegiados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colJuezCentral,
            this.colAsistente1,
            this.colAsistente2,
            this.colCuartoArbitro});
            this.dataGridView1.Location = new System.Drawing.Point(28, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(564, 339);
            this.dataGridView1.TabIndex = 3;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No.";
            this.colNo.Name = "colNo";
            // 
            // colJuezCentral
            // 
            this.colJuezCentral.HeaderText = "JuezCentral";
            this.colJuezCentral.Name = "colJuezCentral";
            // 
            // colAsistente1
            // 
            this.colAsistente1.HeaderText = "Asistente 1";
            this.colAsistente1.Name = "colAsistente1";
            // 
            // colAsistente2
            // 
            this.colAsistente2.HeaderText = "Asistente 2";
            this.colAsistente2.Name = "colAsistente2";
            // 
            // colCuartoArbitro
            // 
            this.colCuartoArbitro.HeaderText = "Cuarto Arbitro";
            this.colCuartoArbitro.Name = "colCuartoArbitro";
            // 
            // frmVerTodosLosColegiados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(613, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVerTodosLosColegiados";
            this.Text = "frmVerTodosLosColegiados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJuezCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsistente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuartoArbitro;
    }
}