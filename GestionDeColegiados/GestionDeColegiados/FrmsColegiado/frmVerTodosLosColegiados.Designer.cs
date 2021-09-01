
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarColegiados = new System.Windows.Forms.DataGridView();
            this.colArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdArbitro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminarArbitro = new System.Windows.Forms.Button();
            this.btnEliminarColegiado = new System.Windows.Forms.Button();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarColegiados)).BeginInit();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(330, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "COLEGIADOS";
            // 
            // dgvListarColegiados
            // 
            this.dgvListarColegiados.AllowUserToAddRows = false;
            this.dgvListarColegiados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListarColegiados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarColegiados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListarColegiados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarColegiados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListarColegiados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarColegiados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarColegiados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArbitro,
            this.colCedula,
            this.colNombre,
            this.colApellido,
            this.colDomicilio,
            this.colEmail,
            this.colTelefono});
            this.dgvListarColegiados.Location = new System.Drawing.Point(12, 167);
            this.dgvListarColegiados.Name = "dgvListarColegiados";
            this.dgvListarColegiados.ReadOnly = true;
            this.dgvListarColegiados.Size = new System.Drawing.Size(759, 183);
            this.dgvListarColegiados.TabIndex = 3;
            // 
            // colArbitro
            // 
            this.colArbitro.HeaderText = "Árbitro";
            this.colArbitro.Name = "colArbitro";
            this.colArbitro.ReadOnly = true;
            // 
            // colCedula
            // 
            this.colCedula.HeaderText = "Cédula";
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colDomicilio
            // 
            this.colDomicilio.HeaderText = "Domicilio";
            this.colDomicilio.Name = "colDomicilio";
            this.colDomicilio.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el grupo: ";
            // 
            // cmbIdArbitro
            // 
            this.cmbIdArbitro.BackColor = System.Drawing.SystemColors.Window;
            this.cmbIdArbitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdArbitro.FormattingEnabled = true;
            this.cmbIdArbitro.IntegralHeight = false;
            this.cmbIdArbitro.Location = new System.Drawing.Point(215, 117);
            this.cmbIdArbitro.Name = "cmbIdArbitro";
            this.cmbIdArbitro.Size = new System.Drawing.Size(259, 21);
            this.cmbIdArbitro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscar.Location = new System.Drawing.Point(517, 112);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 31);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(187, 383);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 31);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminarArbitro
            // 
            this.btnEliminarArbitro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEliminarArbitro.Enabled = false;
            this.btnEliminarArbitro.FlatAppearance.BorderSize = 0;
            this.btnEliminarArbitro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnEliminarArbitro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArbitro.ForeColor = System.Drawing.Color.Silver;
            this.btnEliminarArbitro.Location = new System.Drawing.Point(504, 383);
            this.btnEliminarArbitro.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarArbitro.Name = "btnEliminarArbitro";
            this.btnEliminarArbitro.Size = new System.Drawing.Size(114, 31);
            this.btnEliminarArbitro.TabIndex = 60;
            this.btnEliminarArbitro.Text = "Eliminar (Árbitro)";
            this.btnEliminarArbitro.UseVisualStyleBackColor = false;
            this.btnEliminarArbitro.Click += new System.EventHandler(this.btnEliminarArbitro_Click);
            // 
            // btnEliminarColegiado
            // 
            this.btnEliminarColegiado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEliminarColegiado.Enabled = false;
            this.btnEliminarColegiado.FlatAppearance.BorderSize = 0;
            this.btnEliminarColegiado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnEliminarColegiado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarColegiado.ForeColor = System.Drawing.Color.Silver;
            this.btnEliminarColegiado.Location = new System.Drawing.Point(646, 112);
            this.btnEliminarColegiado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarColegiado.Name = "btnEliminarColegiado";
            this.btnEliminarColegiado.Size = new System.Drawing.Size(116, 31);
            this.btnEliminarColegiado.TabIndex = 61;
            this.btnEliminarColegiado.Text = "Eliminar (Colegiado)";
            this.btnEliminarColegiado.UseVisualStyleBackColor = false;
            this.btnEliminarColegiado.Click += new System.EventHandler(this.btnEliminarColegiado_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.PanelBarraTitulo.Controls.Add(this.pbCerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(783, 28);
            this.PanelBarraTitulo.TabIndex = 62;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::GestionDeColegiados.Properties.Resources.cerrarVentana;
            this.pbCerrar.Location = new System.Drawing.Point(750, 5);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(26, 20);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 2;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            this.pbCerrar.MouseEnter += new System.EventHandler(this.pbCerrar_MouseEnter);
            this.pbCerrar.MouseLeave += new System.EventHandler(this.pbCerrar_MouseLeave);
            // 
            // frmVerTodosLosColegiados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(783, 452);
            this.Controls.Add(this.PanelBarraTitulo);
            this.Controls.Add(this.btnEliminarColegiado);
            this.Controls.Add(this.btnEliminarArbitro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbIdArbitro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListarColegiados);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVerTodosLosColegiados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerTodosLosColegiados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarColegiados)).EndInit();
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarColegiados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdArbitro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminarArbitro;
        private System.Windows.Forms.Button btnEliminarColegiado;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
    }
}