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
    public partial class FrmDS : Form
    {
        private int max = 50;
        List<int> ListNum = new List<int>();

        public FrmDS()
        {
            InitializeComponent();
            txtMax.Text = max.ToString();
            AddItem(max);
        }

        private void AddItem(int max)
        {
            for (int i = 0; i < max; i++)
            {
                var ckb = new CheckBox()
                {
                    Text = i + 1 + "",
                    Size = new Size(this.Width / 11, 50),
                    Checked = true
                };
                pnShow.Controls.Add(ckb);
            }
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                max = Convert.ToInt32(txtMax.Text.Trim());
                pnShow.Controls.Clear();
                AddItem(max);
            }
            catch
            {

            }
        }

        private void ckbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSelectAll.Checked)
            {
                foreach (var control in pnShow.Controls)
                    (control as CheckBox).Checked = true;
                ckbSelectAll.Text = "Hủy chọn tất cả";
            }
            else
            {
                foreach (var control in pnShow.Controls)
                    (control as CheckBox).Checked = false;
                ckbSelectAll.Text = "Chọn tất cả";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int count = 0;
            ListNum.Clear();
            foreach (var c in pnShow.Controls)
            {
                count++;
                if ((c as CheckBox).Checked)
                    ListNum.Add(count);
            }
            if (ListNum.Count > 0)
            {
                FrmRandom frmRandom = new FrmRandom(ListNum, max);
                this.Hide();
                frmRandom.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn ít nhất 1 người!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
