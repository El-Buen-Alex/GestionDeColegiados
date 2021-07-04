
namespace GestionDeColegiados
{
    partial class frmGenerarEncuentros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarEncuentros));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.local = new System.Windows.Forms.TextBox();
            this.visitante = new System.Windows.Forms.TextBox();
            this.guardarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAR ENCUENTRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "VS";
            // 
            // generar
            // 
            this.generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generar.Location = new System.Drawing.Point(97, 547);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(134, 49);
            this.generar.TabIndex = 16;
            this.generar.Text = "Generar encuentros";
            this.generar.UseVisualStyleBackColor = false;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(421, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Visitantes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(113, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Local";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // local
            // 
            this.local.Enabled = false;
            this.local.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local.Location = new System.Drawing.Point(46, 189);
            this.local.Multiline = true;
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(185, 301);
            this.local.TabIndex = 19;
            this.local.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // visitante
            // 
            this.visitante.Enabled = false;
            this.visitante.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitante.Location = new System.Drawing.Point(383, 186);
            this.visitante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visitante.Multiline = true;
            this.visitante.Name = "visitante";
            this.visitante.Size = new System.Drawing.Size(196, 301);
            this.visitante.TabIndex = 21;
            this.visitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guardarDatos
            // 
            this.guardarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.guardarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarDatos.Location = new System.Drawing.Point(356, 547);
            this.guardarDatos.Name = "guardarDatos";
            this.guardarDatos.Size = new System.Drawing.Size(145, 49);
            this.guardarDatos.TabIndex = 22;
            this.guardarDatos.Text = "Registrar encuentros";
            this.guardarDatos.UseVisualStyleBackColor = false;
            this.guardarDatos.Click += new System.EventHandler(this.guardarDatos_Click);
            // 
            // frmGenerarEncuentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 674);
            this.Controls.Add(this.guardarDatos);
            this.Controls.Add(this.visitante);
            this.Controls.Add(this.local);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerarEncuentros";
            this.Text = "frmGenerarEncuentros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.TextBox visitante;
        private System.Windows.Forms.Button guardarDatos;
    }
}