using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTAP_31_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tongtien=0;
        

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("bạn muốn thoát không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }

        private void cbbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboTenSach_TextChanged(object sender, EventArgs e)
        {
            if (cboTenSach.Text =="tin đại cương")
            {
                txtGia.Text = "22000";
            }
            else if(cboTenSach.Text =="tiếng anh f2")
            {
                txtGia.Text = "27000";
            }
            else if (cboTenSach.Text == "giải tích f1")
            {
                txtGia.Text = "25000";
            }
            else if (cboTenSach.Text == "đại số tuyến tính")
            {
                txtGia.Text = "26000";
            }
        }

        private void txtSale_TextChanged(object sender, EventArgs e)
        {
           
            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                txtSale.Text = "10";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                txtSale.Text = "5";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSL.Text);
            int b = Convert.ToInt32(txtGia.Text);
            int c = Convert.ToInt32(txtSale.Text);
            int thanhtien = 0;
            thanhtien = a * b * (100-c)/100;
            tongtien += thanhtien;

            string tensach = "";
            tensach = cboTenSach.Text;
            string soluong = "";
            soluong = lbSL.Text;
            string Thanhtien = "";
            Thanhtien = lstSachDaMua.Text;


            if (radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show("vui lòng chọn cách thanh toán");
            if (cboTenSach.Text == "")
                MessageBox.Show("hãy chọn sách");
            if (lbSL.Text == "")
                MessageBox.Show("hãy chọn số lượng");

            

            string s = tensach + "," + soluong + a +  "," + Thanhtien + thanhtien + "";
            lstSachDaMua.Items.Add(s);

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSachDaMua.SelectedItem == null)
            {
                MessageBox.Show("Vui long chọn để xóa ");
            }
            else
            {
                DialogResult xoa = MessageBox.Show("bạn muốn xóa cuốn sách đó không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                int vt = lstSachDaMua.SelectedIndex;
                lstSachDaMua.Items.RemoveAt(vt);
            }

        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            txtTT.Text = tongtien + " ";
        }
    }
}
