namespace Forms
{
    partial class FormModRecetas
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
            this.BTNVolver = new System.Windows.Forms.Button();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.CMBTipoComida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBReceta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_ingredientes = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingrediente_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNCrear = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ingredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNVolver
            // 
            this.BTNVolver.Location = new System.Drawing.Point(12, 402);
            this.BTNVolver.Name = "BTNVolver";
            this.BTNVolver.Size = new System.Drawing.Size(75, 23);
            this.BTNVolver.TabIndex = 2;
            this.BTNVolver.Text = "Volver";
            this.BTNVolver.UseVisualStyleBackColor = true;
            this.BTNVolver.Click += new System.EventHandler(this.BTNVolver_Click);
            // 
            // TXTName
            // 
            this.TXTName.Location = new System.Drawing.Point(12, 55);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(100, 20);
            this.TXTName.TabIndex = 3;
            // 
            // CMBTipoComida
            // 
            this.CMBTipoComida.FormattingEnabled = true;
            this.CMBTipoComida.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.CMBTipoComida.Location = new System.Drawing.Point(12, 108);
            this.CMBTipoComida.Name = "CMBTipoComida";
            this.CMBTipoComida.Size = new System.Drawing.Size(121, 21);
            this.CMBTipoComida.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo Comida";
            // 
            // CMBReceta
            // 
            this.CMBReceta.FormattingEnabled = true;
            this.CMBReceta.Items.AddRange(new object[] {
            "Saludable",
            "Convencional"});
            this.CMBReceta.Location = new System.Drawing.Point(12, 152);
            this.CMBReceta.Name = "CMBReceta";
            this.CMBReceta.Size = new System.Drawing.Size(121, 21);
            this.CMBReceta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Receta";
            // 
            // Dgv_ingredientes
            // 
            this.Dgv_ingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ingredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.Id,
            this.Ingrediente_dgv,
            this.Cant});
            this.Dgv_ingredientes.Location = new System.Drawing.Point(195, 55);
            this.Dgv_ingredientes.Name = "Dgv_ingredientes";
            this.Dgv_ingredientes.Size = new System.Drawing.Size(560, 326);
            this.Dgv_ingredientes.TabIndex = 9;
            this.Dgv_ingredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Elejir";
            this.Seleccion.Name = "Seleccion";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ingrediente_dgv
            // 
            this.Ingrediente_dgv.DataPropertyName = "nombre";
            this.Ingrediente_dgv.HeaderText = "Ingrediente";
            this.Ingrediente_dgv.Name = "Ingrediente_dgv";
            this.Ingrediente_dgv.ReadOnly = true;
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "cant";
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            // 
            // BTNCrear
            // 
            this.BTNCrear.Location = new System.Drawing.Point(12, 199);
            this.BTNCrear.Name = "BTNCrear";
            this.BTNCrear.Size = new System.Drawing.Size(75, 23);
            this.BTNCrear.TabIndex = 10;
            this.BTNCrear.Text = "Crear";
            this.BTNCrear.UseVisualStyleBackColor = true;
            this.BTNCrear.Click += new System.EventHandler(this.BTNCrear_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(93, 199);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Visible = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(195, 402);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(100, 20);
            this.Txtid.TabIndex = 12;
            this.Txtid.Visible = false;
            this.Txtid.TextChanged += new System.EventHandler(this.Txtid_TextChanged);
            // 
            // FormModRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BTNCrear);
            this.Controls.Add(this.Dgv_ingredientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMBReceta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBTipoComida);
            this.Controls.Add(this.TXTName);
            this.Controls.Add(this.BTNVolver);
            this.Name = "FormModRecetas";
            this.Text = "Agregar Recetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormModRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ingredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVolver;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.ComboBox CMBTipoComida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBReceta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_ingredientes;
        private System.Windows.Forms.Button BTNCrear;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingrediente_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox Txtid;
    }
}