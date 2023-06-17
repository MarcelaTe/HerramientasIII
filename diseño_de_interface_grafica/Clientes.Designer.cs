namespace diseño_de_interface_grafica
{
    partial class Clientes
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
            this.lblClientes = new MaterialSkin.Controls.MaterialLabel();
            this.TxtClientes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnCrear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtBuscarClien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Depth = 0;
            this.lblClientes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClientes.Location = new System.Drawing.Point(287, 9);
            this.lblClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(192, 19);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Administración De Clientes";
            // 
            // TxtClientes
            // 
            this.TxtClientes.Depth = 0;
            this.TxtClientes.Hint = "Nombre Cliente";
            this.TxtClientes.Location = new System.Drawing.Point(20, 31);
            this.TxtClientes.MaxLength = 32767;
            this.TxtClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtClientes.Name = "TxtClientes";
            this.TxtClientes.PasswordChar = '\0';
            this.TxtClientes.SelectedText = "";
            this.TxtClientes.SelectionLength = 0;
            this.TxtClientes.SelectionStart = 0;
            this.TxtClientes.Size = new System.Drawing.Size(332, 23);
            this.TxtClientes.TabIndex = 1;
            this.TxtClientes.TabStop = false;
            this.TxtClientes.UseSystemPasswordChar = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "# Documento";
            this.TxtDocumento.Location = new System.Drawing.Point(20, 83);
            this.TxtDocumento.MaxLength = 32767;
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(184, 23);
            this.TxtDocumento.TabIndex = 2;
            this.TxtDocumento.TabStop = false;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Depth = 0;
            this.TxtDireccion.Hint = "Dirección";
            this.TxtDireccion.Location = new System.Drawing.Point(20, 137);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.Size = new System.Drawing.Size(332, 23);
            this.TxtDireccion.TabIndex = 3;
            this.TxtDireccion.TabStop = false;
            this.TxtDireccion.UseSystemPasswordChar = false;
            this.TxtDireccion.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Hint = "# Teléfono";
            this.TxtTelefono.Location = new System.Drawing.Point(20, 189);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.Size = new System.Drawing.Size(184, 23);
            this.TxtTelefono.TabIndex = 4;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.UseSystemPasswordChar = false;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Depth = 0;
            this.TxtCorreo.Hint = "Correo Electrónico";
            this.TxtCorreo.Location = new System.Drawing.Point(20, 248);
            this.TxtCorreo.MaxLength = 32767;
            this.TxtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.PasswordChar = '\0';
            this.TxtCorreo.SelectedText = "";
            this.TxtCorreo.SelectionLength = 0;
            this.TxtCorreo.SelectionStart = 0;
            this.TxtCorreo.Size = new System.Drawing.Size(332, 23);
            this.TxtCorreo.TabIndex = 5;
            this.TxtCorreo.TabStop = false;
            this.TxtCorreo.UseSystemPasswordChar = false;
            // 
            // BtnCrear
            // 
            this.BtnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCrear.Depth = 0;
            this.BtnCrear.Icon = null;
            this.BtnCrear.Location = new System.Drawing.Point(875, 119);
            this.BtnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Primary = true;
            this.BtnCrear.Size = new System.Drawing.Size(103, 36);
            this.BtnCrear.TabIndex = 6;
            this.BtnCrear.Text = "Crear ";
            this.BtnCrear.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(875, 197);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 7;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(875, 274);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(103, 36);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtClientes);
            this.panel1.Controls.Add(this.TxtDocumento);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.TxtTelefono);
            this.panel1.Controls.Add(this.TxtCorreo);
            this.panel1.Location = new System.Drawing.Point(67, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 296);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBuscarCliente);
            this.panel2.Controls.Add(this.TxtBuscarClien);
            this.panel2.Location = new System.Drawing.Point(67, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 246);
            this.panel2.TabIndex = 10;
            // 
            // TxtBuscarClien
            // 
            this.TxtBuscarClien.Depth = 0;
            this.TxtBuscarClien.Hint = "Buscar Cliente";
            this.TxtBuscarClien.Location = new System.Drawing.Point(20, 32);
            this.TxtBuscarClien.MaxLength = 32767;
            this.TxtBuscarClien.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarClien.Name = "TxtBuscarClien";
            this.TxtBuscarClien.PasswordChar = '\0';
            this.TxtBuscarClien.SelectedText = "";
            this.TxtBuscarClien.SelectionLength = 0;
            this.TxtBuscarClien.SelectionStart = 0;
            this.TxtBuscarClien.Size = new System.Drawing.Size(555, 23);
            this.TxtBuscarClien.TabIndex = 4;
            this.TxtBuscarClien.TabStop = false;
            this.TxtBuscarClien.UseSystemPasswordChar = false;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscarCliente.Depth = 0;
            this.BtnBuscarCliente.Icon = null;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(624, 19);
            this.BtnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Primary = true;
            this.BtnBuscarCliente.Size = new System.Drawing.Size(103, 36);
            this.BtnBuscarCliente.TabIndex = 8;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 142);
            this.dataGridView1.TabIndex = 9;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuardar.Depth = 0;
            this.BtnGuardar.Icon = null;
            this.BtnGuardar.Location = new System.Drawing.Point(875, 661);
            this.BtnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Primary = true;
            this.BtnGuardar.Size = new System.Drawing.Size(74, 36);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 712);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.lblClientes);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCorreo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCrear;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarClien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuardar;
    }
}