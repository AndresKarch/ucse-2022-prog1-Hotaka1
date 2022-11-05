namespace Forms
{
    partial class FormListSuper
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.DGVListSuper = new System.Windows.Forms.DataGridView();
            this.Realizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNVolver = new System.Windows.Forms.Button();
            this.CMBTipos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMenor = new System.Windows.Forms.TextBox();
            this.TxtMayor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecioMayor = new System.Windows.Forms.TextBox();
            this.TxtPrecioMenor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNFiltPrecios = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNFiltCant = new System.Windows.Forms.Button();
            this.BTNFiltTipo = new System.Windows.Forms.Button();
            this.BTNFiltNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListSuper)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Super";
            // 
            // BtnComprar
            // 
            this.BtnComprar.Location = new System.Drawing.Point(12, 392);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(110, 23);
            this.BtnComprar.TabIndex = 6;
            this.BtnComprar.Text = "Realizar Compra";
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // DGVListSuper
            // 
            this.DGVListSuper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListSuper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Realizado,
            this.Id,
            this.Nombre,
            this.Precio,
            this.Tipo,
            this.Cantidad,
            this.PrecioTotal});
            this.DGVListSuper.Location = new System.Drawing.Point(12, 93);
            this.DGVListSuper.Name = "DGVListSuper";
            this.DGVListSuper.Size = new System.Drawing.Size(776, 293);
            this.DGVListSuper.TabIndex = 5;
            this.DGVListSuper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDespensa_CellContentClick);
            // 
            // Realizado
            // 
            this.Realizado.HeaderText = "Realizado";
            this.Realizado.Name = "Realizado";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.Name = "PrecioTotal";
            // 
            // BTNVolver
            // 
            this.BTNVolver.Location = new System.Drawing.Point(12, 421);
            this.BTNVolver.Name = "BTNVolver";
            this.BTNVolver.Size = new System.Drawing.Size(75, 23);
            this.BTNVolver.TabIndex = 19;
            this.BTNVolver.Text = "Volver";
            this.BTNVolver.UseVisualStyleBackColor = true;
            this.BTNVolver.Click += new System.EventHandler(this.BTNVolver_Click);
            // 
            // CMBTipos
            // 
            this.CMBTipos.FormattingEnabled = true;
            this.CMBTipos.Items.AddRange(new object[] {
            "Hortaliza",
            "Fruta",
            "Bebida",
            "Queso",
            "Carne",
            "Pescado",
            "Panaderia",
            "Lacteo"});
            this.CMBTipos.Location = new System.Drawing.Point(808, 160);
            this.CMBTipos.Name = "CMBTipos";
            this.CMBTipos.Size = new System.Drawing.Size(121, 21);
            this.CMBTipos.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad";
            // 
            // TxtMenor
            // 
            this.TxtMenor.Location = new System.Drawing.Point(808, 200);
            this.TxtMenor.Name = "TxtMenor";
            this.TxtMenor.Size = new System.Drawing.Size(46, 20);
            this.TxtMenor.TabIndex = 23;
            // 
            // TxtMayor
            // 
            this.TxtMayor.Location = new System.Drawing.Point(883, 200);
            this.TxtMayor.Name = "TxtMayor";
            this.TxtMayor.Size = new System.Drawing.Size(46, 20);
            this.TxtMayor.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "<";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(861, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "<";
            // 
            // TxtPrecioMayor
            // 
            this.TxtPrecioMayor.Location = new System.Drawing.Point(883, 239);
            this.TxtPrecioMayor.Name = "TxtPrecioMayor";
            this.TxtPrecioMayor.Size = new System.Drawing.Size(46, 20);
            this.TxtPrecioMayor.TabIndex = 27;
            // 
            // TxtPrecioMenor
            // 
            this.TxtPrecioMenor.Location = new System.Drawing.Point(808, 239);
            this.TxtPrecioMenor.Name = "TxtPrecioMenor";
            this.TxtPrecioMenor.Size = new System.Drawing.Size(46, 20);
            this.TxtPrecioMenor.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Precio";
            // 
            // BTNFiltPrecios
            // 
            this.BTNFiltPrecios.Location = new System.Drawing.Point(935, 237);
            this.BTNFiltPrecios.Name = "BTNFiltPrecios";
            this.BTNFiltPrecios.Size = new System.Drawing.Size(52, 23);
            this.BTNFiltPrecios.TabIndex = 30;
            this.BTNFiltPrecios.Text = "Aplicar";
            this.BTNFiltPrecios.UseVisualStyleBackColor = true;
            this.BTNFiltPrecios.Click += new System.EventHandler(this.BTNFiltPrecios_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(808, 118);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filtro de tipos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(805, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Filtro de Nombre";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(808, 265);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(121, 23);
            this.BTNLimpiar.TabIndex = 33;
            this.BTNLimpiar.Text = "Limpiar Filtro";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNFiltCant
            // 
            this.BTNFiltCant.Location = new System.Drawing.Point(935, 198);
            this.BTNFiltCant.Name = "BTNFiltCant";
            this.BTNFiltCant.Size = new System.Drawing.Size(52, 23);
            this.BTNFiltCant.TabIndex = 34;
            this.BTNFiltCant.Text = "Aplicar";
            this.BTNFiltCant.UseVisualStyleBackColor = true;
            this.BTNFiltCant.Click += new System.EventHandler(this.BTNFiltCant_Click);
            // 
            // BTNFiltTipo
            // 
            this.BTNFiltTipo.Location = new System.Drawing.Point(935, 158);
            this.BTNFiltTipo.Name = "BTNFiltTipo";
            this.BTNFiltTipo.Size = new System.Drawing.Size(52, 23);
            this.BTNFiltTipo.TabIndex = 35;
            this.BTNFiltTipo.Text = "Aplicar";
            this.BTNFiltTipo.UseVisualStyleBackColor = true;
            this.BTNFiltTipo.Click += new System.EventHandler(this.BTNFiltTipo_Click);
            // 
            // BTNFiltNombre
            // 
            this.BTNFiltNombre.Location = new System.Drawing.Point(935, 115);
            this.BTNFiltNombre.Name = "BTNFiltNombre";
            this.BTNFiltNombre.Size = new System.Drawing.Size(52, 23);
            this.BTNFiltNombre.TabIndex = 36;
            this.BTNFiltNombre.Text = "Aplicar";
            this.BTNFiltNombre.UseVisualStyleBackColor = true;
            this.BTNFiltNombre.Click += new System.EventHandler(this.BTNFiltNombre_Click);
            // 
            // FormListSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 497);
            this.Controls.Add(this.BTNFiltNombre);
            this.Controls.Add(this.BTNFiltTipo);
            this.Controls.Add(this.BTNFiltCant);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BTNFiltPrecios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPrecioMayor);
            this.Controls.Add(this.TxtPrecioMenor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMayor);
            this.Controls.Add(this.TxtMenor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBTipos);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.DGVListSuper);
            this.Name = "FormListSuper";
            this.Text = "Lista Super";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListSuper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListSuper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.DataGridView DGVListSuper;
        private System.Windows.Forms.Button BTNVolver;
        private System.Windows.Forms.ComboBox CMBTipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMenor;
        private System.Windows.Forms.TextBox TxtMayor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrecioMayor;
        private System.Windows.Forms.TextBox TxtPrecioMenor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Realizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.Button BTNFiltPrecios;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNFiltCant;
        private System.Windows.Forms.Button BTNFiltTipo;
        private System.Windows.Forms.Button BTNFiltNombre;
    }
}