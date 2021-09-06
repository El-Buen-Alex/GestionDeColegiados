
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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(329, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "AÑADIR EQUIPO";
            // 
            // presidente
            // 
            this.presidente.Location = new System.Drawing.Point(504, 439);
            this.presidente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.presidente.Name = "presidente";
            this.presidente.Size = new System.Drawing.Size(209, 22);
            this.presidente.TabIndex = 18;
            this.presidente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presidente_KeyPress);
            // 
            // director
            // 
            this.director.Location = new System.Drawing.Point(500, 362);
            this.director.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(213, 22);
            this.director.TabIndex = 17;
            this.director.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.director_KeyPress);
            // 
            // numjugadores
            // 
            this.numjugadores.Location = new System.Drawing.Point(500, 294);
            this.numjugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numjugadores.MaxLength = 2;
            this.numjugadores.Name = "numjugadores";
            this.numjugadores.Size = new System.Drawing.Size(213, 22);
            this.numjugadores.TabIndex = 16;
            this.numjugadores.TextChanged += new System.EventHandler(this.numjugadores_TextChanged);
            this.numjugadores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numjugadores_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(500, 230);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(213, 22);
            this.nombre.TabIndex = 15;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(252, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presidente de equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(252, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Director Técnico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(252, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número de jugadores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(252, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrar.Location = new System.Drawing.Point(392, 543);
            this.registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(145, 49);
            this.registrar.TabIndex = 10;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // frmNuevoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(959, 892);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}