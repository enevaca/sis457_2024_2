namespace CpMinerva
{
    partial class FrmEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // erpCedulaIdentidad
            // 
            this.erpCedulaIdentidad.ContainerControl = this;
            // 
            // erpNombres
            // 
            this.erpNombres.ContainerControl = this;
            // 
            // erpApellidos
            // 
            this.erpApellidos.ContainerControl = this;
            // 
            // erpDireccion
            // 
            this.erpDireccion.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CpMinerva.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(742, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 39);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // erpCelular
            // 
            this.erpCelular.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CpMinerva.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(707, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CpMinerva.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(600, 80);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 39);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtUsuario);
            this.gbxDatos.Controls.Add(this.cbxCargo);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.lblCargo);
            this.gbxDatos.Controls.Add(this.txtCelular);
            this.gbxDatos.Controls.Add(this.txtDireccion);
            this.gbxDatos.Controls.Add(this.txtSegundoApellido);
            this.gbxDatos.Controls.Add(this.lblCelular);
            this.gbxDatos.Controls.Add(this.txtPrimerApellido);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblDirección);
            this.gbxDatos.Controls.Add(this.lblSegundoApellido);
            this.gbxDatos.Controls.Add(this.txtNombres);
            this.gbxDatos.Controls.Add(this.txtCedulaIdentidad);
            this.gbxDatos.Controls.Add(this.lblPrimerApellido);
            this.gbxDatos.Controls.Add(this.lblNombres);
            this.gbxDatos.Controls.Add(this.lblCedulaIdentidad);
            this.gbxDatos.Location = new System.Drawing.Point(15, 307);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(819, 123);
            this.gbxDatos.TabIndex = 13;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Location = new System.Drawing.Point(306, 58);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(75, 18);
            this.lblDirección.TabIndex = 7;
            this.lblDirección.Text = "Dirección:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(306, 30);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(126, 18);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(155, 55);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(142, 24);
            this.txtNombres.TabIndex = 4;
            // 
            // txtCedulaIdentidad
            // 
            this.txtCedulaIdentidad.Location = new System.Drawing.Point(155, 27);
            this.txtCedulaIdentidad.MaxLength = 10;
            this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
            this.txtCedulaIdentidad.Size = new System.Drawing.Size(142, 24);
            this.txtCedulaIdentidad.TabIndex = 3;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(15, 86);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(111, 18);
            this.lblPrimerApellido.TabIndex = 2;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(15, 58);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(74, 18);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(15, 30);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(140, 18);
            this.lblCedulaIdentidad.TabIndex = 0;
            this.lblCedulaIdentidad.Text = "Cédula de Identidad:";
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(15, 89);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(815, 162);
            this.gbxLista.TabIndex = 11;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Empleados";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 23);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(803, 133);
            this.dgvLista.TabIndex = 0;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(261, 52);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(475, 24);
            this.txtParametro.TabIndex = 9;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(12, 55);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(243, 18);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Buscar por CI o Nombre Completo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(820, 32);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Empleados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpMinerva.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(205, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 39);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(15, 258);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(819, 43);
            this.pnlAcciones.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CpMinerva.Properties.Resources.close;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(501, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 39);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CpMinerva.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(397, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CpMinerva.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(303, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 39);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(155, 83);
            this.txtPrimerApellido.MaxLength = 50;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(142, 24);
            this.txtPrimerApellido.TabIndex = 12;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(306, 86);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 18);
            this.lblCelular.TabIndex = 13;
            this.lblCelular.Text = "Celular:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(438, 27);
            this.txtSegundoApellido.MaxLength = 50;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(142, 24);
            this.txtSegundoApellido.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(438, 55);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(142, 24);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(438, 83);
            this.txtCelular.MaxLength = 8;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(142, 24);
            this.txtCelular.TabIndex = 16;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(595, 30);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(53, 18);
            this.lblCargo.TabIndex = 17;
            this.lblCargo.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario:";
            // 
            // cbxCargo
            // 
            this.cbxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Contador",
            "Cajero",
            "Portero",
            "Seguridad"});
            this.cbxCargo.Location = new System.Drawing.Point(665, 27);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(144, 26);
            this.cbxCargo.TabIndex = 19;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(665, 55);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(144, 24);
            this.txtUsuario.TabIndex = 20;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 442);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlAcciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Empleado - Minerva :::";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider erpNombres;
        private System.Windows.Forms.ErrorProvider erpApellidos;
        private System.Windows.Forms.ErrorProvider erpDireccion;
        private System.Windows.Forms.ErrorProvider erpCelular;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}