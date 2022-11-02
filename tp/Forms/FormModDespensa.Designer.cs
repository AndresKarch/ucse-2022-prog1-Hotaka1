namespace Forms
{
    partial class FormModDespensa
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLCant = new System.Windows.Forms.Label();
            this.TxtCant = new System.Windows.Forms.TextBox();
            this.LBLCantMin = new System.Windows.Forms.Label();
            this.TxtCantMinima = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CMBTipo = new System.Windows.Forms.ComboBox();
            this.LBLKilos = new System.Windows.Forms.Label();
            this.LBLLitros = new System.Windows.Forms.Label();
            this.CMBTipoBebida = new System.Windows.Forms.ComboBox();
            this.LBLTipoBebida = new System.Windows.Forms.Label();
            this.BTNVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(12, 168);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(12, 35);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(118, 35);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // LBLCant
            // 
            this.LBLCant.AutoSize = true;
            this.LBLCant.Location = new System.Drawing.Point(12, 67);
            this.LBLCant.Name = "LBLCant";
            this.LBLCant.Size = new System.Drawing.Size(49, 13);
            this.LBLCant.TabIndex = 8;
            this.LBLCant.Text = "Cantidad";
            this.LBLCant.Visible = false;
            // 
            // TxtCant
            // 
            this.TxtCant.Location = new System.Drawing.Point(12, 86);
            this.TxtCant.Name = "TxtCant";
            this.TxtCant.Size = new System.Drawing.Size(100, 20);
            this.TxtCant.TabIndex = 7;
            this.TxtCant.Visible = false;
            // 
            // LBLCantMin
            // 
            this.LBLCantMin.AutoSize = true;
            this.LBLCantMin.Location = new System.Drawing.Point(12, 113);
            this.LBLCantMin.Name = "LBLCantMin";
            this.LBLCantMin.Size = new System.Drawing.Size(85, 13);
            this.LBLCantMin.TabIndex = 10;
            this.LBLCantMin.Text = "Cantidad Minima";
            this.LBLCantMin.Visible = false;
            // 
            // TxtCantMinima
            // 
            this.TxtCantMinima.Location = new System.Drawing.Point(12, 132);
            this.TxtCantMinima.Name = "TxtCantMinima";
            this.TxtCantMinima.Size = new System.Drawing.Size(100, 20);
            this.TxtCantMinima.TabIndex = 9;
            this.TxtCantMinima.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Comprobar tipo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CMBTipo
            // 
            this.CMBTipo.FormattingEnabled = true;
            this.CMBTipo.Items.AddRange(new object[] {
            "Hortaliza",
            "Fruta",
            "Bebida",
            "Queso",
            "Carne",
            "Pescado",
            "Panaderia",
            "Lacteo"});
            this.CMBTipo.Location = new System.Drawing.Point(224, 35);
            this.CMBTipo.Name = "CMBTipo";
            this.CMBTipo.Size = new System.Drawing.Size(121, 21);
            this.CMBTipo.TabIndex = 13;
            this.CMBTipo.SelectedIndexChanged += new System.EventHandler(this.CMBTipo_SelectedIndexChanged);
            // 
            // LBLKilos
            // 
            this.LBLKilos.AutoSize = true;
            this.LBLKilos.Location = new System.Drawing.Point(12, 67);
            this.LBLKilos.Name = "LBLKilos";
            this.LBLKilos.Size = new System.Drawing.Size(89, 13);
            this.LBLKilos.TabIndex = 14;
            this.LBLKilos.Text = "Cantidad en Kilos";
            this.LBLKilos.Visible = false;
            // 
            // LBLLitros
            // 
            this.LBLLitros.AutoSize = true;
            this.LBLLitros.Location = new System.Drawing.Point(12, 67);
            this.LBLLitros.Name = "LBLLitros";
            this.LBLLitros.Size = new System.Drawing.Size(92, 13);
            this.LBLLitros.TabIndex = 15;
            this.LBLLitros.Text = "Cantidad en Litros";
            this.LBLLitros.Visible = false;
            // 
            // CMBTipoBebida
            // 
            this.CMBTipoBebida.FormattingEnabled = true;
            this.CMBTipoBebida.Items.AddRange(new object[] {
            "Alcoholica",
            "Alta en Azucar",
            "Normal"});
            this.CMBTipoBebida.Location = new System.Drawing.Point(121, 132);
            this.CMBTipoBebida.Name = "CMBTipoBebida";
            this.CMBTipoBebida.Size = new System.Drawing.Size(121, 21);
            this.CMBTipoBebida.TabIndex = 16;
            this.CMBTipoBebida.Visible = false;
            // 
            // LBLTipoBebida
            // 
            this.LBLTipoBebida.AutoSize = true;
            this.LBLTipoBebida.Location = new System.Drawing.Point(118, 113);
            this.LBLTipoBebida.Name = "LBLTipoBebida";
            this.LBLTipoBebida.Size = new System.Drawing.Size(64, 13);
            this.LBLTipoBebida.TabIndex = 17;
            this.LBLTipoBebida.Text = "Tipo Bebida";
            this.LBLTipoBebida.Visible = false;
            // 
            // BTNVolver
            // 
            this.BTNVolver.Location = new System.Drawing.Point(12, 415);
            this.BTNVolver.Name = "BTNVolver";
            this.BTNVolver.Size = new System.Drawing.Size(75, 23);
            this.BTNVolver.TabIndex = 18;
            this.BTNVolver.Text = "Volver";
            this.BTNVolver.UseVisualStyleBackColor = true;
            this.BTNVolver.Click += new System.EventHandler(this.BTNVolver_Click);
            // 
            // FormModDespensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.LBLTipoBebida);
            this.Controls.Add(this.CMBTipoBebida);
            this.Controls.Add(this.LBLLitros);
            this.Controls.Add(this.LBLKilos);
            this.Controls.Add(this.CMBTipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBLCantMin);
            this.Controls.Add(this.TxtCantMinima);
            this.Controls.Add(this.LBLCant);
            this.Controls.Add(this.TxtCant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "FormModDespensa";
            this.Text = "Despensa Modificacion/Nuevos";
            this.Load += new System.EventHandler(this.FormModDespensa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLCant;
        private System.Windows.Forms.TextBox TxtCant;
        private System.Windows.Forms.Label LBLCantMin;
        private System.Windows.Forms.TextBox TxtCantMinima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CMBTipo;
        private System.Windows.Forms.Label LBLKilos;
        private System.Windows.Forms.Label LBLLitros;
        private System.Windows.Forms.ComboBox CMBTipoBebida;
        private System.Windows.Forms.Label LBLTipoBebida;
        private System.Windows.Forms.Button BTNVolver;
    }
}