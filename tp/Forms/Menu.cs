using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Forms
{
    public partial class Menu : Form
    {
        Archivo Arch = new Archivo();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            Arch.Crear_carpeta();
        }

        private void despensaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDespensa Despensa = new FormDespensa();
            Despensa.Show();
        }

        private void comidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComida Comidas = new FormComida();
            Comidas.ShowDialog();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecetas Recetas = new FormRecetas();
            Recetas.ShowDialog();
        }

        private void listaSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListSuper Super = new FormListSuper();
            Super.ShowDialog();
        }
        
        
    }
}
