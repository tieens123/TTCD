using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("bạn muốn thoát không ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSo.Text = " ";
            lbSVN.Text = " ";
            cboChucNang.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = Convert.ToInt32(txtSo.Text);
            a = new int[n];

            for(int i = 0; i < n; i++)
            {
                int so = r.Next(-100, 100);
                a[i] = so;  

            }
            string s = "";
            foreach(int i in a)
            {
                s += i + "";
                lbSVN.Text = s;
            }
        }
    }
}
