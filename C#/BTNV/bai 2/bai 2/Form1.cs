using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSoA.Text);
            int b = Convert.ToInt32(txtSoB.Text);
            int s = 0;
            if(a>b)
            {
                for (int i = b; i <= a; i++)
                    s += i;
            }    
            else
            {
                for( int i = a; i <= b, i++)
                    s+= i;
            }
            ldKQ.Text = "tong la: " + s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           txtSoA.Text = "";
            txtSoB.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult a= MessageBox.Show("m có chắc muôn thoát","thông báo",MessageBoxButtons.YesNo);
            if(a==DialogResult.Yes){

            }
            Close();
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ldKQ_Click(object sender, EventArgs e)
        {

        }
    }
}
