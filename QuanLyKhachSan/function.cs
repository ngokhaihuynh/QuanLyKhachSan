using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-1D3BM95\\HUYNH;Initial Catalog=QLKS;Integrated Security=True"; //KẾT NỐI MASTER
            //con.ConnectionString = "Data Source=26.63.150.253,1433;Initial Catalog=QLKS1;User Id=sa;Password=1405;"; //KẾT NỐI CHI NHÁNH 1
            //con.ConnectionString = "Data Source=26.63.150.253,1434;Initial Catalog=QLKS_2;User Id=sa;Password=1405;"; // KET NOI CHI NHANH 2
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
           
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
