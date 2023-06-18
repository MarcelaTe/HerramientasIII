namespace diseño_de_interface_grafica
{
    partial class Empleado
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
            this.TxtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCrear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(374, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(205, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Administrador De Empleados";
            // 
            // Categoria
            // 
            this.Categoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Categoria.Controls.Add(this.monthCalendar3);
            this.Categoria.Controls.Add(this.materialLabel4);
            this.Categoria.Controls.Add(this.monthCalendar2);
            this.Categoria.Controls.Add(this.materialLabel3);
            this.Categoria.Controls.Add(this.richTextBox1);
            this.Categoria.Controls.Add(this.comboBox2);
            this.Categoria.Controls.Add(this.materialSingleLineTextField3);
            this.Categoria.Controls.Add(this.materialSingleLineTextField2);
            this.Categoria.Controls.Add(this.materialSingleLineTextField1);
            this.Categoria.Controls.Add(this.monthCalendar1);
            this.Categoria.Controls.Add(this.materialLabel2);
            this.Categoria.Controls.Add(this.comboBox1);
            this.Categoria.Controls.Add(this.TxtProductos);
            this.Categoria.Controls.Add(this.TxtCodigo);
            this.Categoria.Controls.Add(this.TxtCompra);
            this.Categoria.Location = new System.Drawing.Point(42, 42);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(772, 891);
            this.Categoria.TabIndex = 11;
            // 
            // TxtProductos
            // 
            this.TxtProductos.Depth = 0;
            this.TxtProductos.Hint = "Nombre Empledo";
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
            this.TxtCodigo.Hint = "# Documento";
            this.TxtCodigo.Location = new System.Drawing.Point(20, 73);
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
            this.TxtCodigo.Click += new System.EventHandler(this.TxtCodigo_Click);
            // 
            // TxtCompra
            // 
            this.TxtCompra.Depth = 0;
            this.TxtCompra.Hint = "Sexo";
            this.TxtCompra.Location = new System.Drawing.Point(20, 117);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Primaria",
            "Secundaria",
            "Tecnico",
            "Tecnologo",
            "Profesional",
            "Maestria",
            "Doctorado"});
            this.comboBox1.Location = new System.Drawing.Point(20, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Escolaridad";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(16, 202);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Fecha de nacimiento";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 230);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Dirección";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(20, 414);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(332, 23);
            this.materialSingleLineTextField1.TabIndex = 13;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Teléfono";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(20, 453);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(184, 23);
            this.materialSingleLineTextField2.TabIndex = 14;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "E-mail";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(20, 492);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(332, 23);
            this.materialSingleLineTextField3.TabIndex = 15;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Administrador",
            "Empleado",
            "Desarrollador",
            "Vendedor",
            "Tecnico",
            "Soporte"});
            this.comboBox2.Location = new System.Drawing.Point(20, 535);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "Cargo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 576);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(707, 96);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "Datos adicionales";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 684);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(123, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Fecha de ingreso";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(20, 712);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 19;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(330, 684);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(109, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Fecha de retiro";
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.Location = new System.Drawing.Point(334, 712);
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.TabIndex = 21;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(901, 400);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Primary = true;
            this.BtnEliminar.Size = new System.Drawing.Size(103, 36);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(901, 317);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 28;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnCrear
            // 
            this.BtnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCrear.Depth = 0;
            this.BtnCrear.Icon = null;
            this.BtnCrear.Location = new System.Drawing.Point(901, 229);
            this.BtnCrear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Primary = true;
            this.BtnCrear.Size = new System.Drawing.Size(103, 36);
            this.BtnCrear.TabIndex = 27;
            this.BtnCrear.Text = "Crear ";
            this.BtnCrear.UseVisualStyleBackColor = true;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 947);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Categoria.ResumeLayout(false);
            this.Categoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel Categoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCompra;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private MaterialSkin.Controls.MaterialRaisedButton BtnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCrear;
    }
}