namespace Forms
{
    partial class FormPrepararComidas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DGVComidas = new System.Windows.Forms.DataGridView();
            this.Preparar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista Comidas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGVComidas
            // 
            this.DGVComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preparar,
            this.Id,
            this.Nombre,
            this.TipoReceta,
            this.TipoComida,
            this.Ingredientes});
            this.DGVComidas.Location = new System.Drawing.Point(12, 71);
            this.DGVComidas.Name = "DGVComidas";
            this.DGVComidas.Size = new System.Drawing.Size(776, 293);
            this.DGVComidas.TabIndex = 4;
            this.DGVComidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDespensa_CellContentClick);
            // 
            // Preparar
            // 
            this.Preparar.HeaderText = "Preparar";
            this.Preparar.Name = "Preparar";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // TipoReceta
            // 
            this.TipoReceta.DataPropertyName = "tipo_receta";
            this.TipoReceta.HeaderText = "Tipo Receta";
            this.TipoReceta.Name = "TipoReceta";
            // 
            // TipoComida
            // 
            this.TipoComida.DataPropertyName = "tipo_comida";
            this.TipoComida.HeaderText = "Tipo Comida";
            this.TipoComida.Name = "TipoComida";
            // 
            // Ingredientes
            // 
            this.Ingredientes.DataPropertyName = "ingredientes";
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.Name = "Ingredientes";
            // 
            // BTNVolver
            // 
            this.BTNVolver.Location = new System.Drawing.Point(12, 415);
            this.BTNVolver.Name = "BTNVolver";
            this.BTNVolver.Size = new System.Drawing.Size(75, 23);
            this.BTNVolver.TabIndex = 19;
            this.BTNVolver.Text = "Volver";
            this.BTNVolver.UseVisualStyleBackColor = true;
            this.BTNVolver.Click += new System.EventHandler(this.BTNVolver_Click);
            // 
            // FormPrepararComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVComidas);
            this.Name = "FormPrepararComidas";
            this.Text = "Comidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVComidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVComidas;
        private System.Windows.Forms.Button BTNVolver;
        private System.Windows.Forms.DataGridViewButtonColumn Preparar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
    }
}

