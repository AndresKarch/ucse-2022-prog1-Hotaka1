﻿namespace Forms
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
            this.BTNVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Preparar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVHistorial
            // 
            this.DGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHistorial.Location = new System.Drawing.Point(12, 63);
            this.DGVHistorial.Name = "DGVHistorial";
            this.DGVHistorial.Size = new System.Drawing.Size(776, 291);
            this.DGVHistorial.TabIndex = 0;
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
            // FormComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Preparar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNVolver);
            this.Controls.Add(this.DGVHistorial);
            this.Name = "FormComida";
            this.Text = "Form2";
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
    }
}