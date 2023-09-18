using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_tinhtoan
{
    public partial class Form2 : Form
    {
        double tongdiem;
        public Form2()
        {
            InitializeComponent();
        }

        

        

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);
            int f = Convert.ToInt32(textBox5.Text);

            

            if (a != 2)
            {
                textBox1.BackColor= Color.Red;   
            }
            else
            {
                textBox1.BackColor= Color.Green;
                tongdiem = tongdiem + 2;
            }
            if (b != 4)
            {
                textBox2.BackColor = Color.Red;
            }
            else
            {
                textBox2.BackColor = Color.Green;
                tongdiem = tongdiem + 2;

            }
            if (c != 6)
            {
                textBox3.BackColor = Color.Red;
                

            }
            else
            {
                textBox3.BackColor = Color.Green;
                tongdiem = tongdiem + 2;
            }
            if (d != 8)
            {
                textBox4.BackColor = Color.Red;
            }
            else
            {
                textBox4.BackColor = Color.Green;
                tongdiem = tongdiem + 2;
            }
            if (f != 10)
            {
                textBox5.BackColor = Color.Red;
            }
            else
            {
                textBox5.BackColor = Color.Green;
                tongdiem = tongdiem + 2;
            }
            MessageBox.Show("tổng điểm là: " + tongdiem);
;        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor= Color.White;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.BackColor = Color.White;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            textBox1.ForeColor = Color.Blue;
            textBox2.Text = "4";
            textBox2.ForeColor = Color.Blue;
            textBox3.Text = "6";
            textBox3.ForeColor = Color.Blue;
            textBox4.Text = "8";
            textBox4.ForeColor = Color.Blue;
            textBox5.Text = "10";
            textBox5.ForeColor = Color.Blue;


            
        }
    }
}
