
namespace GestionDeColegiados
{
    partial class frmEditarEquipo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editar = new System.Windows.Forms.Label();
            this.equipo = new System.Windows.Forms.Label();
            this.añadir = new System.Windows.Forms.Label();
            this.eliminarEquipo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numjugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscar = new System.Windows.Forms.Button();
            this.numEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.equipo);
            this.panel1.Controls.Add(this.añadir);
            this.panel1.Controls.Add(this.eliminarEquipo);
            this.panel1.Location = new System.Drawing.Point(28, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 460);
            this.panel1.TabIndex = 37;
            // 
            // editar
            // 
            this.editar.AutoSize = true;
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editar.Location = new System.Drawing.Point(66, 360);
            this.editar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(51, 20);
            this.editar.TabIndex = 27;
            this.editar.Text = "Editar";
            // 
            // equipo
            // 
            this.equipo.AutoSize = true;
            this.equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equipo.Location = new System.Drawing.Point(49, 264);
            this.equipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(104, 26);
            this.equipo.TabIndex = 29;
            this.equipo.Text = "EQUIPO";
            // 
            // añadir
            // 
            this.añadir.AutoSize = true;
            this.añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.añadir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.añadir.Location = new System.Drawing.Point(66, 309);
            this.añadir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(55, 20);
            this.añadir.TabIndex = 26;
            this.añadir.Text = "Añadir";
            // 
            // eliminarEquipo
            // 
            this.eliminarEquipo.AutoSize = true;
            this.eliminarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eliminarEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminarEquipo.Location = new System.Drawing.Point(66, 414);
            this.eliminarEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eliminarEquipo.Name = "eliminarEquipo";
            this.eliminarEquipo.Size = new System.Drawing.Size(65, 20);
            this.eliminarEquipo.TabIndex = 28;
            this.eliminarEquipo.Text = "Eliminar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEquipo,
            this.numjugadores,
            this.director,
            this.presidente});
            this.dataGridView1.Location = new System.Drawing.Point(285, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 125);
            this.dataGridView1.TabIndex = 35;
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
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buscar.Location = new System.Drawing.Point(661, 71);
            this.buscar.Margin = new System.Windows.Forms.Padding(2);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(109, 31);
            this.buscar.TabIndex = 34;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            // 
            // numEquipo
            // 
            this.numEquipo.Location = new System.Drawing.Point(501, 77);
            this.numEquipo.Name = "numEquipo";
            this.numEquipo.Size = new System.Drawing.Size(100, 20);
            this.numEquipo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(281, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingrese el número de equipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(423, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "EDITAR EQUIPO";
            // 
            // frmEditarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.numEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarEquipo";
            this.Text = "frmEditarEquipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label editar;
        private System.Windows.Forms.Label equipo;
        private System.Windows.Forms.Label añadir;
        private System.Windows.Forms.Label eliminarEquipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numjugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidente;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox numEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}