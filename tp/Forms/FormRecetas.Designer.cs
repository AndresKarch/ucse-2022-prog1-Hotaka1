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
            this.BtnNuevoElemento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRecetas
            // 
            this.DGVRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRecetas.Location = new System.Drawing.Point(12, 58);
            this.DGVRecetas.Name = "DGVRecetas";
            this.DGVRecetas.Size = new System.Drawing.Size(776, 293);
            this.DGVRecetas.TabIndex = 0;
            this.DGVRecetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDespensa_CellContentClick);
            // 
            // BtnNuevoElemento
            // 
            this.BtnNuevoElemento.Location = new System.Drawing.Point(12, 357);
            this.BtnNuevoElemento.Name = "BtnNuevoElemento";
            this.BtnNuevoElemento.Size = new System.Drawing.Size(110, 23);
            this.BtnNuevoElemento.TabIndex = 1;
            this.BtnNuevoElemento.Text = "Nuevo Elemento";
            this.BtnNuevoElemento.UseVisualStyleBackColor = true;
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
    }
}