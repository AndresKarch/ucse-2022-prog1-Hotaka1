namespace Forms
{
    partial class FormRecetas
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
            this.DGVRecetas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevoElemento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRecetas
            // 
            this.DGVRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Eliminar,
            this.Modificar,
            this.Nombre,
            this.TipoReceta,
            this.TipoComida,
            this.Ingredientes});
            this.DGVRecetas.Location = new System.Drawing.Point(12, 58);
            this.DGVRecetas.Name = "DGVRecetas";
            this.DGVRecetas.Size = new System.Drawing.Size(776, 293);
            this.DGVRecetas.TabIndex = 0;
            this.DGVRecetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDespensa_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TipoReceta
            // 
            this.TipoReceta.DataPropertyName = "tipo_receta";
            this.TipoReceta.HeaderText = "Tipo Receta";
            this.TipoReceta.Name = "TipoReceta";
            this.TipoReceta.ReadOnly = true;
            // 
            // TipoComida
            // 
            this.TipoComida.DataPropertyName = "tipo_comida";
            this.TipoComida.HeaderText = "TipoComida";
            this.TipoComida.Name = "TipoComida";
            this.TipoComida.ReadOnly = true;
            // 
            // Ingredientes
            // 
            this.Ingredientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Width = 90;
            // 
            // BtnNuevoElemento
            // 
            this.BtnNuevoElemento.Location = new System.Drawing.Point(12, 357);
            this.BtnNuevoElemento.Name = "BtnNuevoElemento";
            this.BtnNuevoElemento.Size = new System.Drawing.Size(110, 23);
            this.BtnNuevoElemento.TabIndex = 1;
            this.BtnNuevoElemento.Text = "Nuevo Elemento";
            this.BtnNuevoElemento.UseVisualStyleBackColor = true;
            this.BtnNuevoElemento.Click += new System.EventHandler(this.BtnNuevoElemento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Recetas";
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
            // FormRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNuevoElemento);
            this.Controls.Add(this.DGVRecetas);
            this.Name = "FormRecetas";
            this.Text = "Recetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRecetas;
        private System.Windows.Forms.Button BtnNuevoElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
    }
}