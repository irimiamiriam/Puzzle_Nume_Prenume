using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Nume_Prenume
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Vizualizare viz = new Vizualizare();
            this.Hide();
            viz.ToggleButtonVisibility(true);
            viz.ShowDialog();
        }
    }
}
