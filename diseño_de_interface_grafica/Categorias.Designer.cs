namespace diseño_de_interface_grafica
{
    partial class Categorias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtBuscarProduc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnCrear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
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
            this.materialLabel1.Location = new System.Drawing.Point(320, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(203, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Administrador De Categorias";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NombreCategoria);
            this.panel1.Controls.Add(this.TxtReferencia);
            this.panel1.Location = new System.Drawing.Point(29, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 122);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Depth = 0;
            this.TxtReferencia.Hint = "Codigo referencia";
            this.TxtReferencia.Location = new System.Drawing.Point(20, 31);
            this.TxtReferencia.MaxLength = 32767;
            this.TxtReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.PasswordChar = '\0';
            this.TxtReferencia.SelectedText = "";
            this.TxtReferencia.SelectionLength = 0;
            this.TxtReferencia.SelectionStart = 0;
            this.TxtReferencia.Size = new System.Drawing.Size(332, 23);
            this.TxtReferencia.TabIndex = 1;
            this.TxtReferencia.TabStop = false;
            this.TxtReferencia.UseSystemPasswordChar = false;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.Depth = 0;
            this.NombreCategoria.Hint = "Nombre Categoria";
            this.NombreCategoria.Location = new System.Drawing.Point(20, 83);
            this.NombreCategoria.MaxLength = 32767;
            this.NombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.PasswordChar = '\0';
            this.NombreCategoria.SelectedText = "";
            this.NombreCategoria.SelectionLength = 0;
            this.NombreCategoria.SelectionStart = 0;
            this.NombreCategoria.Size = new System.Drawing.Size(332, 23);
            this.NombreCategoria.TabIndex = 2;
            this.NombreCategoria.TabStop = false;
            this.NombreCategoria.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnBuscarCliente);
            this.panel2.Controls.Add(this.TxtBuscarProduc);
            this.panel2.Location = new System.Drawing.Point(29, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 236);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // BtnCrear
            // 
            this.BtnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCrear.Depth = 0;
            this.BtnCrear.Icon = null;
            this.BtnCrear.Location = new System.Drawing.Point(850, 77);
            this.BtnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Primary = true;
            this.BtnCrear.Size = new System.Drawing.Size(103, 36);
            this.BtnCrear.TabIndex = 16;
            this.BtnCrear.Text = "Crear ";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(850, 119);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(850, 161);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(103, 36);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuardar.Depth = 0;
            this.BtnGuardar.Icon = null;
            this.BtnGuardar.Location = new System.Drawing.Point(850, 457);
            this.BtnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Primary = true;
            this.BtnGuardar.Size = new System.Drawing.Size(103, 36);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 514);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Categorias";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField NombreCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtReferencia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscarCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarProduc;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCrear;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGuardar;
    }
}