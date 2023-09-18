using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMKH.Text = "";
            txtHTKH.Text = "";
            txtDC.Text = "";
            txtTienGui.Text = "";
            txtNgayGui.Text = "";
            nmrTGG.Value = 0;
            txtDSKH.Text = "";
            rbThuong.Checked = false;
            rbPl.Checked = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Exit == DialogResult.Yes)
                {
                    Application.Exit(); 
                }    
            
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            string a = (string)txtMKH.Text;
            if(a.Length <6) { 
            MessageBox.Show("bạn chưa nhập đủ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            lsbDSKH.Items.Add(txtMKH.Text);
            lsbDSKH.Items.Add(txtHTKH.Text);
            lsbDSKH.Items.Add(txtDC.Text);
            lsbDSKH.Items.Add(txtTienGui.Text);




        }
    }
}
    