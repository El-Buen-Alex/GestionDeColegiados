
namespace GestionDeColegiados
{
    partial class frmEliminarEquipo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numEquipo = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numjugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(150, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "ELIMINAR EQUIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese el nombre de equipo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numEquipo
            // 
            this.numEquipo.Location = new System.Drawing.Point(228, 94);
            this.numEquipo.Name = "numEquipo";
            this.numEquipo.Size = new System.Drawing.Size(128, 20);
            this.numEquipo.TabIndex = 22;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buscar.Location = new System.Drawing.Point(388, 88);
            this.buscar.Margin = new System.Windows.Forms.Padding(2);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(109, 31);
            this.buscar.TabIndex = 23;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEquipo,
            this.numjugadores,
            this.director,
            this.presidente});
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 125);
            this.dataGridView1.TabIndex = 24;
            // 
            // nombreEquipo
            // 
            this.nombreEquipo.HeaderText = "Nombre";
            this.nombreEquipo.Name = "nombreEquipo";
            // 
            // numjugadores
            // 
            this.numjugadores.HeaderText = "Número de Jugadores";
            this.numjugadores.Name = "numjugadores";
            // 
            // director
            // 
            this.director.HeaderText = "Director Técnico";
            this.director.Name = "director";
            // 
            // presidente
            // 
            this.presidente.HeaderText = "Presidente de Equipo";
            this.presidente.Name = "presidente";
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar.Location = new System.Drawing.Point(155, 401);
            this.eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(109, 31);
            this.eliminar.TabIndex = 25;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            // 
            // frmEliminarEquipo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(522, 482);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.numEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEliminarEquipo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numEquipo;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numjugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidente;
        private System.Windows.Forms.Button eliminar;
    }
}