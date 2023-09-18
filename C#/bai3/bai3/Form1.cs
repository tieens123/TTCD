using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        int[] a;
        public Form1()
        {
            InitializeComponent();
            btnTinhTong.Enabled= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnTinhTong.Enabled= true;
            int n = Convert.ToInt32(txt1.Text);
            a = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {

                int number = rd.Next(1, 100);

                a[i] = number;
            }
            string s = "";
            foreach (int i in a)
                s += i + "";
            //găn giá trị biến s cho lb dãy số
            lbDaySo.Text = s;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (int i in a)
                s += i;
            lbDaySo.Text = s + "";
        }
    }
}
