﻿
namespace GestionDeColegiados
{
    partial class frmVerTodos
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
            this.nomEquipo = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numjugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
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
            this.label5.Size = new System.Drawing.Size(261, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Datos de Configuración";
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
            // nomEquipo
            // 
            this.nomEquipo.Location = new System.Drawing.Point(228, 94);
            this.nomEquipo.Name = "nomEquipo";
            this.nomEquipo.Size = new System.Drawing.Size(159, 20);
            this.nomEquipo.TabIndex = 22;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buscar.Location = new System.Drawing.Point(413, 88);
            this.buscar.Margin = new System.Windows.Forms.Padding(2);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(109, 31);
            this.buscar.TabIndex = 23;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.idEquipo,
            this.nombreEquipo,
            this.numjugadores,
            this.director,
            this.presidente});
            this.tablaDatos.Location = new System.Drawing.Point(12, 157);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.Size = new System.Drawing.Size(601, 125);
            this.tablaDatos.TabIndex = 24;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(382, 372);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 31);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(54, 372);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 31);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar Equipo";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // num
            // 
            this.num.HeaderText = "Num";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // idEquipo
            // 
            this.idEquipo.HeaderText = "Id Equipo";
            this.idEquipo.Name = "idEquipo";
            this.idEquipo.ReadOnly = true;
            // 
            // nombreEquipo
            // 
            this.nombreEquipo.HeaderText = "Nombre";
            this.nombreEquipo.Name = "nombreEquipo";
            this.nombreEquipo.ReadOnly = true;
            // 
            // numjugadores
            // 
            this.numjugadores.HeaderText = "Número de Jugadores";
            this.numjugadores.Name = "numjugadores";
            this.numjugadores.ReadOnly = true;
            // 
            // director
            // 
            this.director.HeaderText = "Director Técnico";
            this.director.Name = "director";
            this.director.ReadOnly = true;
            // 
            // presidente
            // 
            this.presidente.HeaderText = "Presidente de Equipo";
            this.presidente.Name = "presidente";
            this.presidente.ReadOnly = true;
            // 
            // frmVerTodos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(625, 483);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.nomEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerTodos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomEquipo;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numjugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidente;
    }
}