namespace diseño_de_interface_grafica
{
    partial class Productos
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
            this.Categoria = new System.Windows.Forms.Panel();
            this.Categorias = new System.Windows.Forms.ComboBox();
            this.richDetalles = new System.Windows.Forms.RichTextBox();
            this.TxtProductos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnCrear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarProduc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Categoria.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Categoria
            // 
            this.Categoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Categoria.Controls.Add(this.materialSingleLineTextField2);
            this.Categoria.Controls.Add(this.materialSingleLineTextField1);
            this.Categoria.Controls.Add(this.Categorias);
            this.Categoria.Controls.Add(this.richDetalles);
            this.Categoria.Controls.Add(this.TxtProductos);
            this.Categoria.Controls.Add(this.TxtCodigo);
            this.Categoria.Controls.Add(this.TxtCompra);
            this.Categoria.Controls.Add(this.TxtVenta);
            this.Categoria.Location = new System.Drawing.Point(45, 83);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(743, 501);
            this.Categoria.TabIndex = 10;
            // 
            // Categorias
            // 
            this.Categorias.FormattingEnabled = true;
            this.Categorias.Items.AddRange(new object[] {
            "Celulares",
            "Computadores",
            "Equipos de sonido",
            "Portatiles ",
            "Gamer"});
            this.Categorias.Location = new System.Drawing.Point(20, 237);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(121, 21);
            this.Categorias.TabIndex = 7;
            this.Categorias.Text = "Categorias";
            // 
            // richDetalles
            // 
            this.richDetalles.Location = new System.Drawing.Point(20, 291);
            this.richDetalles.Name = "richDetalles";
            this.richDetalles.Size = new System.Drawing.Size(700, 89);
            this.richDetalles.TabIndex = 6;
            this.richDetalles.Tag = "";
            this.richDetalles.Text = "Detalles...";
            // 
            // TxtProductos
            // 
            this.TxtProductos.Depth = 0;
            this.TxtProductos.Hint = "Nombre Producto";
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
            // TxtCodigo
            // 
            this.TxtCodigo.Depth = 0;
            this.TxtCodigo.Hint = "# Codigo";
            this.TxtCodigo.Location = new System.Drawing.Point(20, 83);
            this.TxtCodigo.MaxLength = 32767;
            this.TxtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PasswordChar = '\0';
            this.TxtCodigo.SelectedText = "";
            this.TxtCodigo.SelectionLength = 0;
            this.TxtCodigo.SelectionStart = 0;
            this.TxtCodigo.Size = new System.Drawing.Size(184, 23);
            this.TxtCodigo.TabIndex = 2;
            this.TxtCodigo.TabStop = false;
            this.TxtCodigo.UseSystemPasswordChar = false;
            // 
            // TxtCompra
            // 
            this.TxtCompra.Depth = 0;
            this.TxtCompra.Hint = "$ Compra";
            this.TxtCompra.Location = new System.Drawing.Point(20, 137);
            this.TxtCompra.MaxLength = 32767;
            this.TxtCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCompra.Name = "TxtCompra";
            this.TxtCompra.PasswordChar = '\0';
            this.TxtCompra.SelectedText = "";
            this.TxtCompra.SelectionLength = 0;
            this.TxtCompra.SelectionStart = 0;
            this.TxtCompra.Size = new System.Drawing.Size(184, 23);
            this.TxtCompra.TabIndex = 3;
            this.TxtCompra.TabStop = false;
            this.TxtCompra.UseSystemPasswordChar = false;
            // 
            // TxtVenta
            // 
            this.TxtVenta.Depth = 0;
            this.TxtVenta.Hint = "$ Venta";
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
            // BtnCrear
            // 
            this.BtnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCrear.Depth = 0;
            this.BtnCrear.Icon = null;
            this.BtnCrear.Location = new System.Drawing.Point(856, 126);
            this.BtnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Primary = true;
            this.BtnCrear.Size = new System.Drawing.Size(103, 36);
            this.BtnCrear.TabIndex = 11;
            this.BtnCrear.Text = "Crear ";
            this.BtnCrear.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(856, 198);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 12;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(856, 272);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(103, 36);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBuscarCliente);
            this.panel2.Controls.Add(this.TxtBuscarProduc);
            this.panel2.Location = new System.Drawing.Point(45, 672);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 239);
            this.panel2.TabIndex = 14;
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
            this.TxtBuscarProduc.Hint = "Buscar Producto";
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
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuardar.Depth = 0;
            this.BtnGuardar.Icon = null;
            this.BtnGuardar.Location = new System.Drawing.Point(856, 863);
            this.BtnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Primary = true;
            this.BtnGuardar.Size = new System.Drawing.Size(103, 36);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(301, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(199, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Administrador De Productos";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Imagen de producto         ...";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(20, 410);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(184, 23);
            this.materialSingleLineTextField1.TabIndex = 8;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click_1);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Cantidad de stock";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(20, 465);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(184, 23);
            this.materialSingleLineTextField2.TabIndex = 9;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 911);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.Categoria);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Categoria.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Categoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtVenta;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCrear;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private System.Windows.Forms.RichTextBox richDetalles;
        private System.Windows.Forms.ComboBox Categorias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarProduc;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}