namespace Forms
{
    partial class FormDespensa
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevoElemento = new System.Windows.Forms.Button();
            this.DGVDespensa = new System.Windows.Forms.DataGridView();
            this.BTNVolver = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDespensa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Despensa";
            // 
            // BtnNuevoElemento
            // 
            this.BtnNuevoElemento.Location = new System.Drawing.Point(12, 392);
            this.BtnNuevoElemento.Name = "BtnNuevoElemento";
            this.BtnNuevoElemento.Size = new System.Drawing.Size(110, 23);
            this.BtnNuevoElemento.TabIndex = 6;
            this.BtnNuevoElemento.Text = "Nuevo Elemento";
            this.BtnNuevoElemento.UseVisualStyleBackColor = true;
            this.BtnNuevoElemento.Click += new System.EventHandler(this.BtnNuevoElemento_Click);
            // 
            // DGVDespensa
            // 
            this.DGVDespensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDespensa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Tipo,
            this.Cantidades,
            this.CantidadMin,
            this.TipoBebida,
            this.Eliminar,
            this.Modificar,
            this.Id});
            this.DGVDespensa.Location = new System.Drawing.Point(12, 90);
            this.DGVDespensa.Name = "DGVDespensa";
            this.DGVDespensa.Size = new System.Drawing.Size(950, 293);
            this.DGVDespensa.TabIndex = 5;
            this.DGVDespensa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDespensa_CellContentClick);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Cantidades
            // 
            this.Cantidades.DataPropertyName = "cantidad";
            this.Cantidades.HeaderText = "Cantidades";
            this.Cantidades.Name = "Cantidades";
            this.Cantidades.ReadOnly = true;
            // 
            // CantidadMin
            // 
            this.CantidadMin.DataPropertyName = "CantMinima";
            this.CantidadMin.HeaderText = "cantidad Minima";
            this.CantidadMin.Name = "CantidadMin";
            this.CantidadMin.ReadOnly = true;
            // 
            // TipoBebida
            // 
            this.TipoBebida.DataPropertyName = "tipobebida";
            this.TipoBebida.HeaderText = "TipoBebida";
            this.TipoBebida.Name = "TipoBebida";
            this.TipoBebida.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FormDespensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNuevoElemento);
            this.Controls.Add(this.DGVDespensa);
            this.Name = "FormDespensa";
            this.Text = "Despensa";
            this.Load += new System.EventHandler(this.FormDespensa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDespensa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNuevoElemento;
        private System.Windows.Forms.DataGridView DGVDespensa;
        private System.Windows.Forms.Button BTNVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBebida;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}