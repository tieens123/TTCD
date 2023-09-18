using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_kqua_Click(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(txt_thang.Text);
                int year = int.Parse(txt_nam.Text);

                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        lbResult.Text = "Tháng" + month + "/" + year + "có 31 ngày";
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        lbResult.Text = "Tháng" + month + "/" + year + "có 30 ngày";
                        break;
                    case 2:
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                            lbResult.Text = "Tháng" + month + "/" + year + "có 29 ngày";
                        else
                            lbResult.Text = "Tháng" + month + "/" + year + "có 28 ngày";
                        break;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập đúng tháng và năm");
            }


        }

        

        private void bt_llai_Click(object sender, EventArgs e)
        {
            txt_nam.Text = "";
            txt_thang.Text = "";
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }
    }
}
