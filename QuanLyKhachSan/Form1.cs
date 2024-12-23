using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username, pass from employee where username = '" + txtUserName.Text + "'and pass = '" + txtPassWord.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count !=0) 
            {
                labelError.Visible = false;
                DashBoard dash = new DashBoard();
                this.Hide();
                dash.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassWord.Clear();
            }
        }
    }
}
