using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_Random
{
    public partial class FrmBackground : Form
    {
        public FrmBackground()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            FrmDS main = new FrmDS();
            main.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRandom_Enter(object sender, EventArgs e)
        {
            btnRandom.BackColor = Color.Goldenrod;
        }

        private void btnRandom_Leave(object sender, EventArgs e)
        {
            btnRandom.BackColor = Color.Transparent;
        }
    }
}
