namespace Forms
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.despensaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSuperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despensaToolStripMenuItem,
            this.comidasToolStripMenuItem,
            this.recetasToolStripMenuItem,
            this.listaSuperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // despensaToolStripMenuItem
            // 
            this.despensaToolStripMenuItem.Name = "despensaToolStripMenuItem";
            this.despensaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.despensaToolStripMenuItem.Text = "Despensa";
            this.despensaToolStripMenuItem.Click += new System.EventHandler(this.despensaToolStripMenuItem_Click);
            // 
            // comidasToolStripMenuItem
            // 
            this.comidasToolStripMenuItem.Name = "comidasToolStripMenuItem";
            this.comidasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.comidasToolStripMenuItem.Text = "Comidas";
            this.comidasToolStripMenuItem.Click += new System.EventHandler(this.comidasToolStripMenuItem_Click);
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.recetasToolStripMenuItem.Text = "Recetas";
            this.recetasToolStripMenuItem.Click += new System.EventHandler(this.recetasToolStripMenuItem_Click);
            // 
            // listaSuperToolStripMenuItem
            // 
            this.listaSuperToolStripMenuItem.Name = "listaSuperToolStripMenuItem";
            this.listaSuperToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.listaSuperToolStripMenuItem.Text = "Lista Super";
            this.listaSuperToolStripMenuItem.Click += new System.EventHandler(this.listaSuperToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem despensaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSuperToolStripMenuItem;
    }
}