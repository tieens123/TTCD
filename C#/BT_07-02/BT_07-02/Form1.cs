using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_07_02
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dtpThue_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void dtpTra_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTimeThue = dtpThue.Value;
            DateTime dateTimeTra = dtpTra.Value;
            TimeSpan tgian= dateTimeTra.Subtract(dateTimeThue);
            double phut = tgian.TotalMinutes;
            Math.Round((double)(phut));
            txtTongTG.Text = phut + "";
            if (dateTimeThue.Hour >= 6 && dateTimeTra.Hour < 17)
            {
                double tien = 50000 / 60 * phut;
                lbSang.Text = tien + "";
            }
            if(dateTimeThue.Hour >= 17 && dateTimeTra.Hour <6)
            {
                double tien = 1000 * phut;
                lbToi.Text = tien + "";

            }
            if (dateTimeThue.Hour < 17 && dateTimeTra.Hour >=7 && dateTimeTra.Hour > 17 && dateTimeTra.Hour <23)

            {
                double tien;
                tien = (17 - dateTimeThue.Hour) * 60 * 50000 / 60 + (phut - (17 - dateTimeThue.Hour) * 60) * 1000;
                lbToi.Text = tien + "";

            }
        }
    }
}
