using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktra1201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtMKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMKH.Text = "";
            txtHTKH.Text = "";
            txtDC.Text = "";
            txtNgayChot.Text = "";
            txtSTT.Text = "";
            txtSTN.Text = "";
        }

        private void txtMKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            
            string s = (string)txtMKH.Text;
            if (s.Length < 6)
            {
                MessageBox.Show("bạn chưa nhập MKH", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (txtHTKH.Text.Length == 0)
            {
                MessageBox.Show("bạn chưa nhập họ tên KH", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (txtDC.Text.Length == 0)
            {
                MessageBox.Show("bạn chưa nhập địa chỉ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            lsbDSKH.Items.Add(txtMKH.Text);
            lsbDSKH.Items.Add(txtHTKH.Text);
            lsbDSKH.Items.Add(txtDC.Text);
            lsbDSKH.Items.Add(txtNgayChot.Text);
            lsbDSKH.Items.Add(txtSTT.Text);
            lsbDSKH.Items.Add(txtSTN.Text);

            int a = Convert.ToInt32(txtSTT.Text);
            int b = Convert.ToInt32(txtSTN.Text);
            int c = b - a;
            int Tongtien = 0;
            if ( a > b)
            {
                MessageBox.Show("số điện sai", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

        }
    }
}
