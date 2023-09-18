using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class oooo : Form
    {
        public oooo()
        {
            InitializeComponent();
        }

        

        private void btnSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) ==false )
                    {
                        e.Handled= true;
                    }
        }

        private void btnSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                    {
                        e.Handled = true;
                    }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                int so1 = Convert.ToInt32(txtA.Text);
                int so2 = Convert.ToInt32(txtB.Text);
                int result = so1 + so2;
                this.txtKQ.Text = result.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("nhap lại","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtA.Text);
            int so2 = Convert.ToInt32(txtB.Text);
            int result = so1 - so2;
            this.txtKQ.Text = result.ToString();
        }

        private void rbNhan_CheckedChanged(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtA.Text);
            int so2 = Convert.ToInt32(txtB.Text);
            int result = so1 * so2;
            this.txtKQ.Text = result.ToString();
        }

        private void rbChia_CheckedChanged(object sender, EventArgs e)
        {
            int so1 = Convert.ToInt32(txtA.Text);
            int so2 = Convert.ToInt32(txtB.Text);
            int result = so1 / so2;
            this.txtKQ.Text = result.ToString();

              
        }
    }
}
