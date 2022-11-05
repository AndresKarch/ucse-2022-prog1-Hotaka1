namespace Forms
{
    partial class FormComida
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
            this.DGVHistorial = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Preparar = new System.Windows.Forms.Button();
            this.BTNFiltNombre = new System.Windows.Forms.Button();
            this.BTNFiltTipoComida = new System.Windows.Forms.Button();
            this.BTNFiltTipoReceta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBTiposComida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.BTNProd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBTIpoReceta = new System.Windows.Forms.ComboBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVHistorial
            // 
            this.DGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.TipoReceta,
            this.TipoComida,
            this.Ingredientes});
            this.DGVHistorial.Location = new System.Drawing.Point(12, 63);
            this.DGVHistorial.Name = "DGVHistorial";
            this.DGVHistorial.Size = new System.Drawing.Size(915, 291);
            this.DGVHistorial.TabIndex = 0;
            this.DGVHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHistorial_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // TipoReceta
            // 
            this.TipoReceta.HeaderText = "Tipo Receta";
            this.TipoReceta.Name = "TipoReceta";
            // 
            // TipoComida
            // 
            this.TipoComida.HeaderText = "Tipo Comida";
            this.TipoComida.Name = "TipoComida";
            // 
            // Ingredientes
            // 
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.Name = "Ingredientes";
            // 
            // BTNVolver
            // 
            this.BTNVolver.Location = new System.Drawing.Point(12, 415);
            this.BTNVolver.Name = "BTNVolver";
            this.BTNVolver.Size = new System.Drawing.Size(75, 23);
            this.BTNVolver.TabIndex = 1;
            this.BTNVolver.Text = "Volver";
            this.BTNVolver.UseVisualStyleBackColor = true;
            this.BTNVolver.Click += new System.EventHandler(this.BTNVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Historial Comidas";
            // 
            // Preparar
            // 
            this.Preparar.Location = new System.Drawing.Point(12, 373);
            this.Preparar.Name = "Preparar";
            this.Preparar.Size = new System.Drawing.Size(75, 23);
            this.Preparar.TabIndex = 3;
            this.Preparar.Text = "Preparar";
            this.Preparar.UseVisualStyleBackColor = true;
            this.Preparar.Click += new System.EventHandler(this.Preparar_Click);
            // 
            // BTNFiltNombre
            // 
            this.BTNFiltNombre.Location = new System.Drawing.Point(244, 387);
            this.BTNFiltNombre.Name = "BTNFiltNombre";
            this.BTNFiltNombre.Size = new System.Drawing.Size(52, 23);
            this.BTNFiltNombre.TabIndex = 48;
            this.BTNFiltNombre.Text = "Aplicar";
            this.BTNFiltNombre.UseVisualStyleBackColor = true;
            this.BTNFiltNombre.Click += new System.EventHandler(this.BTNFiltNombre_Click);
            // 
            // BTNFiltTipoComida
            // 
            this.BTNFiltTipoComida.Location = new System.Drawing.Point(244, 430);
            this.BTNFiltTipoComida.Name = "BTNFiltTipoComida";
            this.BTNFiltTipoComida.Size = new System.Drawing.Size(52, 23);
            this.BTNFiltTipoComida.TabIndex = 47;
            this.BTNFiltTipoComida.Text = "Aplicar";
            this.BTNFiltTipoComida.UseVisualStyleBackColor = true;
            this.BTNFiltTipoComida.Click += new System.EventHandler(this.BTNFiltTipoComida_Click);
            // 
            // BTNFiltTipoReceta
            // 
            this.BTNFiltTipoReceta.Location = new System.Drawing.Point(244, 470);
            this.BTNFiltTipoReceta.Name = "BTNFiltTipoReceta";
            this.BTNFiltTipoReceta.Size = new System.Drawing.Size(52, 23);
            this.BTNFiltTipoReceta.TabIndex = 46;
            this.BTNFiltTipoReceta.Text = "Aplicar";
            this.BTNFiltTipoReceta.UseVisualStyleBackColor = true;
            this.BTNFiltTipoReceta.Click += new System.EventHandler(this.BTNFiltTipoReceta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Filtro de Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(117, 390);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Filtro Tipo Comida";
            // 
            // CMBTiposComida
            // 
            this.CMBTiposComida.FormattingEnabled = true;
            this.CMBTiposComida.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.CMBTiposComida.Location = new System.Drawing.Point(117, 432);
            this.CMBTiposComida.Name = "CMBTiposComida";
            this.CMBTiposComida.Size = new System.Drawing.Size(121, 21);
            this.CMBTiposComida.TabIndex = 37;
            this.CMBTiposComida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBTiposComida_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Filtro de Producto";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(117, 519);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(121, 20);
            this.TxtProducto.TabIndex = 49;
            // 
            // BTNProd
            // 
            this.BTNProd.Location = new System.Drawing.Point(244, 517);
            this.BTNProd.Name = "BTNProd";
            this.BTNProd.Size = new System.Drawing.Size(52, 23);
            this.BTNProd.TabIndex = 51;
            this.BTNProd.Text = "Aplicar";
            this.BTNProd.UseVisualStyleBackColor = true;
            this.BTNProd.Click += new System.EventHandler(this.BTNProd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Filtro Tipo Receta";
            // 
            // CMBTIpoReceta
            // 
            this.CMBTIpoReceta.FormattingEnabled = true;
            this.CMBTIpoReceta.Items.AddRange(new object[] {
            "Saludable",
            "Convencional"});
            this.CMBTIpoReceta.Location = new System.Drawing.Point(117, 472);
            this.CMBTIpoReceta.Name = "CMBTIpoReceta";
            this.CMBTIpoReceta.Size = new System.Drawing.Size(121, 21);
            this.CMBTIpoReceta.TabIndex = 52;
            this.CMBTIpoReceta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBTIpoReceta_KeyPress);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Location = new System.Drawing.Point(142, 545);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.Btnlimpiar.TabIndex = 54;
            this.Btnlimpiar.Text = "Limpiar filtro";
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // FormComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 593);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMBTIpoReceta);
            this.Controls.Add(this.BTNProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.BTNFiltNombre);
            this.Controls.Add(this.BTNFiltTipoComida);
            this.Controls.Add(this.BTNFiltTipoReceta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBTiposComida);
            this.Controls.Add(this.Preparar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.DGVHistorial);
            this.Name = "FormComida";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormComida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHistorial;
        private System.Windows.Forms.Button BTNVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Preparar;
        private System.Windows.Forms.Button BTNFiltNombre;
        private System.Windows.Forms.Button BTNFiltTipoComida;
        private System.Windows.Forms.Button BTNFiltTipoReceta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBTiposComida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Button BTNProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMBTIpoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.Button Btnlimpiar;
    }
}