using System;
using System.Windows.Forms;

namespace CS_TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double so1, so2, result;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            result = so1 + so2;
            
            txtKQ.Text = result.ToString();
        }


        private void btnTinhHieu_Click(object sender, EventArgs e)
        {
            Double so1, so2, result;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            result = so1 - so2;

            txtKQ.Text = result.ToString();
        }

        private void btnTinhTich_Click(object sender, EventArgs e)
        {
            Double so1, so2, result;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            result = so1 * so2;

            txtKQ.Text = result.ToString();
        }

        private void btnTinhThuong_Click(object sender, EventArgs e)
        {
            Double so1, so2, result;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            result = so1 / so2;

            if (so2 == 0)
            {
                MessageBox.Show("Khong the chia cho 0", "Thong bao loi", MessageBoxButtons.OK);
            }
            else
            {
                txtKQ.Text = result.ToString();
            }            
        }
    }
}
