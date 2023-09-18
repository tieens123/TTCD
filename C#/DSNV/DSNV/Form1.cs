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

namespace DSNV
{
    
    public partial class Form1 : Form
    {
        SqlConnection NV;
        DataTable dataTable;
        private void Connect()
        {
            NV = new SqlConnection();
            NV.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\bt_on\bt_on\Database1.mdf;Integrated Security=True";
            NV.Open();
        }

        void Loaddata()
        {
            string sql;
            sql = "Select *from DSNV";
            // lấy dữ liệu từ sql lưu vào dataadapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, NV);
            dataTable = new DataTable();
            //đưa dữ liệu từ DataAdapter vào Datatable
            sqlDataAdapter.Fill(dataTable);
            dtv.DataSource = dataTable;
        }
        public Form1()
        {
            InitializeComponent();
            Connect();
            Loaddata();

        }
        private void runSQL(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = NV;
            sqlCommand.ExecuteNonQuery();
        }

        private void dtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTNV.Text = dtv[0, e.RowIndex].ToString();
            txtTNV.Text = dtv[1, e.RowIndex].ToString();
            dtDay.Text = dtv[2, e.RowIndex].ToString();
            rbGT.Text = dtv[3, e.RowIndex].ToString();
            txtDC.Text = dtv[4, e.RowIndex].ToString();
            txtDT.Text = dtv[5, e.RowIndex].ToString();
            


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTNV.Text;
            string ma = txtMNV.Text;
            string day = dtDay.Text;    
            int gt = Convert.ToInt32(rbGT.Text);
            string dc = txtDC.Text;
            string dt = txtDT.Text;

            string sql = "Insert into DSNV values" +
                "( N'" + ten + "', N'" + ma + "','" + day +"',N '" + gt +"',N'" + dc +"','" +dt+ "')";
            runSQL(sql);
            Loaddata();
        }
    }
}
