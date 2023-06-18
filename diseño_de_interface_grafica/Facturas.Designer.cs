namespace diseño_de_interface_grafica
{
    partial class Facturas
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Categoria = new System.Windows.Forms.Panel();
            this.TxtProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarProduc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCrear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Categoria.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(377, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(188, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Administrador De Facturas";
            // 
            // Categoria
            // 
            this.Categoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Categoria.Controls.Add(this.comboBox3);
            this.Categoria.Controls.Add(this.materialSingleLineTextField3);
            this.Categoria.Controls.Add(this.comboBox2);
            this.Categoria.Controls.Add(this.comboBox1);
            this.Categoria.Controls.Add(this.TxtProductos);
            this.Categoria.Controls.Add(this.TxtVenta);
            this.Categoria.Location = new System.Drawing.Point(59, 67);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(743, 325);
            this.Categoria.TabIndex = 11;
            // 
            // TxtProductos
            // 
            this.TxtProductos.Depth = 0;
            this.TxtProductos.Hint = "# Factura";
            this.TxtProductos.Location = new System.Drawing.Point(20, 31);
            this.TxtProductos.MaxLength = 32767;
            this.TxtProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProductos.Name = "TxtProductos";
            this.TxtProductos.PasswordChar = '\0';
            this.TxtProductos.SelectedText = "";
            this.TxtProductos.SelectionLength = 0;
            this.TxtProductos.SelectionStart = 0;
            this.TxtProductos.Size = new System.Drawing.Size(332, 23);
            this.TxtProductos.TabIndex = 1;
            this.TxtProductos.TabStop = false;
            this.TxtProductos.UseSystemPasswordChar = false;
            // 
            // TxtVenta
            // 
            this.TxtVenta.Depth = 0;
            this.TxtVenta.Hint = "% Descuento";
            this.TxtVenta.Location = new System.Drawing.Point(20, 189);
            this.TxtVenta.MaxLength = 32767;
            this.TxtVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.PasswordChar = '\0';
            this.TxtVenta.SelectedText = "";
            this.TxtVenta.SelectionLength = 0;
            this.TxtVenta.SelectionStart = 0;
            this.TxtVenta.Size = new System.Drawing.Size(184, 23);
            this.TxtVenta.TabIndex = 4;
            this.TxtVenta.TabStop = false;
            this.TxtVenta.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Empresa",
            "Persona Natural",
            "Gobierno"});
            this.comboBox1.Location = new System.Drawing.Point(20, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Cliente";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Vendedor",
            "Aprendiz",
            "Tecnico",
            "Soporte",
            "Garantia",
            "Bodega"});
            this.comboBox2.Location = new System.Drawing.Point(20, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "Empleado";
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Valor de impuesto";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(20, 239);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(184, 23);
            this.materialSingleLineTextField3.TabIndex = 12;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Cancelada",
            "En proceso",
            "Aceptada"});
            this.comboBox3.Location = new System.Drawing.Point(20, 288);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Text = "Estado Factura";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBuscarCliente);
            this.panel2.Controls.Add(this.TxtBuscarProduc);
            this.panel2.Location = new System.Drawing.Point(59, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 239);
            this.panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 142);
            this.dataGridView1.TabIndex = 9;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.AutoSize = true;
            this.BtnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscarCliente.Depth = 0;
            this.BtnBuscarCliente.Icon = null;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(624, 19);
            this.BtnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Primary = true;
            this.BtnBuscarCliente.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscarCliente.TabIndex = 8;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarProduc
            // 
            this.TxtBuscarProduc.Depth = 0;
            this.TxtBuscarProduc.Hint = "Buscar Detalle Factura";
            this.TxtBuscarProduc.Location = new System.Drawing.Point(20, 32);
            this.TxtBuscarProduc.MaxLength = 32767;
            this.TxtBuscarProduc.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarProduc.Name = "TxtBuscarProduc";
            this.TxtBuscarProduc.PasswordChar = '\0';
            this.TxtBuscarProduc.SelectedText = "";
            this.TxtBuscarProduc.SelectionLength = 0;
            this.TxtBuscarProduc.SelectionStart = 0;
            this.TxtBuscarProduc.Size = new System.Drawing.Size(555, 23);
            this.TxtBuscarProduc.TabIndex = 4;
            this.TxtBuscarProduc.TabStop = false;
            this.TxtBuscarProduc.UseSystemPasswordChar = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(883, 290);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(112, 36);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(883, 216);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(112, 36);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnCrear
            // 
            this.BtnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCrear.Depth = 0;
            this.BtnCrear.Icon = null;
            this.BtnCrear.Location = new System.Drawing.Point(883, 144);
            this.BtnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Primary = true;
            this.BtnCrear.Size = new System.Drawing.Size(112, 36);
            this.BtnCrear.TabIndex = 16;
            this.BtnCrear.Text = "Crear ";
            this.BtnCrear.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuardar.Depth = 0;
            this.BtnGuardar.Icon = null;
            this.BtnGuardar.Location = new System.Drawing.Point(883, 638);
            this.BtnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Primary = true;
            this.BtnGuardar.Size = new System.Drawing.Size(112, 36);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 722);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            this.Categoria.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel Categoria;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtVenta;
        private System.Windows.Forms.ComboBox comboBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarProduc;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCrear;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuardar;
    }
}