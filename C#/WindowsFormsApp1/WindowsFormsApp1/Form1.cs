using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconnetion;
        DataTable dataTable;

        private void Connect()
        {
            sqlconnetion= new SqlConnection();
            sqlconnetion.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\C#\\WindowsFormsApp1\\WindowsFormsApp1\\Database2.mdf;Integrated Security=True";
            sqlconnetion.Open();
        }

        private void LoadData()
        {
            string sql;
            sql = "select *from Hang";
            // lấy dữ liệu từ sql lưu vào dataadapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlconnetion);
            dataTable = new DataTable();
            //đưa dữ liệu từ DataAdapter vào Datatable
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public Form1()
        {
            InitializeComponent();
            Connect();
            LoadData();
        }

        public void RunSQL(string sql)
        {
            //đói tượng thực hiện lệnh
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.CommandText= sql;
            sqlCommand.Connection = sqlconnetion;
            sqlCommand.ExecuteNonQuery();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMH.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            txtTH.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            txtCL.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            txtSL.Text = dataGridView1[3, e.RowIndex].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtMH.Text);
            string ten = txtTH .Text;
            string chatlieu= txtCL.Text;
            int soluong = Convert.ToInt32(txtSL.Text);
            string sql = "Insert into Hang Values" + "(" + ma + ",N'" + ten + "', N'" + chatlieu + "'," + soluong + ")";
            RunSQL(sql);
            LoadData();
        }
    }
}
