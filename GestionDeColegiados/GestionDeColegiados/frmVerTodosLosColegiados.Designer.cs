
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.coTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditar = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarColegiados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(330, 40);
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
            this.colArbitro,
            this.colCedula,
            this.colNombre,
            this.colApellido,
            this.colDomicilio,
            this.colEmail,
            this.colTelefono});
            this.dgvListarColegiados.Location = new System.Drawing.Point(12, 164);
            this.dgvListarColegiados.Name = "dgvListarColegiados";
            this.dgvListarColegiados.ReadOnly = true;
            this.dgvListarColegiados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListarColegiados.Size = new System.Drawing.Size(761, 183);
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
            this.colCedula.HeaderText = "Cedula";
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
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el grupo: ";
            // 
            // cmbIdArbitro
            // 
            this.cmbIdArbitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdArbitro.FormattingEnabled = true;
            this.cmbIdArbitro.Location = new System.Drawing.Point(208, 113);
            this.cmbIdArbitro.Name = "cmbIdArbitro";
            this.cmbIdArbitro.Size = new System.Drawing.Size(199, 21);
            this.cmbIdArbitro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscar.Location = new System.Drawing.Point(460, 108);
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
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(187, 379);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 31);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Silver;
            this.btnEliminar.Location = new System.Drawing.Point(509, 379);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 31);
            this.btnEliminar.TabIndex = 60;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // coTelefono
            // 
            this.coTelefono.HeaderText = "Telefono";
            this.coTelefono.Name = "coTelefono";
            // 
            // coEmail
            // 
            this.coEmail.HeaderText = "Email";
            this.coEmail.Name = "coEmail";
            // 
            // coDomicilio
            // 
            this.coDomicilio.HeaderText = "Domicilio";
            this.coDomicilio.Name = "coDomicilio";
            // 
            // coApellido
            // 
            this.coApellido.HeaderText = "Apellido";
            this.coApellido.Name = "coApellido";
            // 
            // coNombre
            // 
            this.coNombre.HeaderText = "Nombre";
            this.coNombre.Name = "coNombre";
            // 
            // coCedula
            // 
            this.coCedula.HeaderText = "Cedula";
            this.coCedula.Name = "coCedula";
            // 
            // coArbitro
            // 
            this.coArbitro.HeaderText = "Arbitro";
            this.coArbitro.Name = "coArbitro";
            this.coArbitro.ReadOnly = true;
            // 
            // dgvEditar
            // 
            this.dgvEditar.AllowUserToAddRows = false;
            this.dgvEditar.AllowUserToDeleteRows = false;
            this.dgvEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coArbitro,
            this.coCedula,
            this.coNombre,
            this.coApellido,
            this.coDomicilio,
            this.coEmail,
            this.coTelefono});
            this.dgvEditar.Location = new System.Drawing.Point(12, 429);
            this.dgvEditar.Name = "dgvEditar";
            this.dgvEditar.Size = new System.Drawing.Size(761, 77);
            this.dgvEditar.TabIndex = 61;
            this.dgvEditar.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(119)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Silver;
            this.btnActualizar.Location = new System.Drawing.Point(349, 529);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 31);
            this.btnActualizar.TabIndex = 62;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            // 
            // frmVerTodosLosColegiados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(783, 603);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvEditar);
            this.Controls.Add(this.btnEliminar);
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
            this.Text = "frmVerTodosLosColegiados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarColegiados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarColegiados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdArbitro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn coEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn coApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn coArbitro;
        private System.Windows.Forms.DataGridView dgvEditar;
        private System.Windows.Forms.Button btnActualizar;
    }
}