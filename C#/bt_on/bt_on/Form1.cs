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

namespace bt_on
{
    public partial class Form1 : Form
    {
        SqlConnection cl;
        DataTable dataTable;
        private void Connect()
        {
            cl = new SqlConnection();
            cl.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\bt_on\bt_on\Database1.mdf;Integrated Security=True";
            cl.Open();
        }
       
        void loaddata()
        {
            string sql;
            sql = "Select *from Chatlieu";
            // lấy dữ liệu từ sql lưu vào dataadapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, cl);
            dataTable = new DataTable();
            //đưa dữ liệu từ DataAdapter vào Datatable
            sqlDataAdapter.Fill(dataTable);
            dvt.DataSource = dataTable;
        }
        public Form1()
        {
            InitializeComponent();
            Connect();
            loaddata();

        }
        private void runSQL(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = cl;
            sqlCommand.ExecuteNonQuery();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void dvt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            txtMa.Text = dvt[0, e.RowIndex].Value.ToString();
            txtTen.Text = dvt[1, e.RowIndex].Value.ToString();
           

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ các textbox
            
            string ten = txtMa.Text;
            string chatLieu = txtTen.Text;
            
            string sql = "Insert into Chatlieu values" +
                "( N'" + ten + "', N'" + chatLieu + "')";
            runSQL(sql);
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ten = txtMa.Text;
            string chatLieu = txtTen.Text;

            string sql = "Update  Chatlieu set idCL= N'" + ten + "',nameCL= N'" + chatLieu + "'  where idCL='" + ten + "'";
            runSQL(sql);
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ten = txtMa.Text;
            string chatLieu = txtTen.Text;

            string sql = "Delete Chatlieu WHERE idCL = '" + ten + "';";
            runSQL(sql);
            loaddata();
        }
    }
}
