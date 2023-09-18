using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg= new OpenFileDialog();
            dlg.Filter = "Bitmap(*.bmp)| *.*";
            dlg.Title = "chọn ảnh ";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pcb.Image = Image.FromFile(dlg.FileName);
            }
            else
                MessageBox.Show("cút","...");
        }

        private void bntTho_Click(object sender, EventArgs e)
        {
            SaveFileDialog luu= new SaveFileDialog();
            luu.Filter = "Text file(* .txt) |* .txt  |Word Document (*.doc)|*.doc| All files(*.*)|*.* ";
            luu.Title = "chọn cmm đi";
            if (luu.ShowDialog()== DialogResult.OK)
            {
                StreamWriter strem = new StreamWriter(luu.FileName);
                strem.WriteLine(textBox1.Text);
                MessageBox.Show("xong cmm rồi!");
            }
        }
    }
}
