using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_Random
{
    public partial class FrmRandom : Form
    {
        Random random = new Random();
        List<int> listNumbers = new List<int>();
        int maxValue = 12;
        int count = 25;

        public FrmRandom(List<int> listNum, int max)
        {
            InitializeComponent();
            listNumbers = listNum;
            maxValue = max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                RandInt();
                this.Refresh();
                Thread.Sleep(50);
            }
        }

        private void RandInt()
        {
            int value = random.Next(maxValue);
            while (listNumbers.Contains(value) == false)
                value = random.Next(maxValue);
            label1.Text = value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Goldenrod;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }
    }
}
