
namespace GestionDeColegiados
{
    partial class frmNuevoEquipo
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
            this.presidente = new System.Windows.Forms.TextBox();
            this.director = new System.Windows.Forms.TextBox();
            this.numjugadores = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(108, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "AÑADIR EQUIPO";
            // 
            // presidente
            // 
            this.presidente.Location = new System.Drawing.Point(239, 298);
            this.presidente.Margin = new System.Windows.Forms.Padding(2);
            this.presidente.Name = "presidente";
            this.presidente.Size = new System.Drawing.Size(158, 20);
            this.presidente.TabIndex = 18;
            this.presidente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presidente_KeyPress);
            // 
            // director
            // 
            this.director.Location = new System.Drawing.Point(236, 236);
            this.director.Margin = new System.Windows.Forms.Padding(2);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(161, 20);
            this.director.TabIndex = 17;
            this.director.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.director_KeyPress);
            // 
            // numjugadores
            // 
            this.numjugadores.Location = new System.Drawing.Point(236, 180);
            this.numjugadores.Margin = new System.Windows.Forms.Padding(2);
            this.numjugadores.MaxLength = 2;
            this.numjugadores.Name = "numjugadores";
            this.numjugadores.Size = new System.Drawing.Size(161, 20);
            this.numjugadores.TabIndex = 16;
            this.numjugadores.TextChanged += new System.EventHandler(this.numjugadores_TextChanged);
            this.numjugadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numjugadores_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(236, 128);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(161, 20);
            this.nombre.TabIndex = 15;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(50, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presidente de equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(50, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Director Técnico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número de jugadores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrar.Location = new System.Drawing.Point(160, 360);
            this.registrar.Margin = new System.Windows.Forms.Padding(2);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(109, 40);
            this.registrar.TabIndex = 10;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar.Location = new System.Drawing.Point(287, 422);
            this.eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(138, 40);
            this.eliminar.TabIndex = 48;
            this.eliminar.Text = "Eliminar Equipo";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editar.Location = new System.Drawing.Point(11, 422);
            this.editar.Margin = new System.Windows.Forms.Padding(2);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(140, 40);
            this.editar.TabIndex = 47;
            this.editar.Text = "Editar Equipo";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // frmNuevoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(446, 507);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.presidente);
            this.Controls.Add(this.director);
            this.Controls.Add(this.numjugadores);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNuevoEquipo";
            this.Text = "frmNuevoEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox presidente;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.TextBox numjugadores;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
    }
}