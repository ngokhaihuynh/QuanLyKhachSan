using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Comtrol
{
   
    public partial class UC_CustomerDetail : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerDetail()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex == 0)
            {
                query = @"SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, 
                     customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.booked,
                     rooms.price, branch.branchName 
              FROM customer
              INNER JOIN rooms ON customer.roomid = rooms.roomid 
              INNER JOIN branch ON customer.branchid = branch.branchid";
                getRecord(query);
                
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                query = @"SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, 
                     customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.booked,
                     rooms.price, branch.branchName 
              FROM customer
              INNER JOIN rooms ON customer.roomid = rooms.roomid 
              INNER JOIN branch ON customer.branchid = branch.branchid 
              WHERE chekout = 'No'";

                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = @"SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, 
                     customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.booked,
                     rooms.price, branch.branchName 
              FROM customer
              INNER JOIN rooms ON customer.roomid = rooms.roomid 
              INNER JOIN branch ON customer.branchid = branch.branchid 
              WHERE chekout = 'Yes'";

                getRecord(query);
            }
        }

        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns["cid"].Visible = false;
            guna2DataGridView1.Columns["cname"].HeaderText = "Tên Khách Hàng";
            guna2DataGridView1.Columns["mobile"].HeaderText = "SDT";
            guna2DataGridView1.Columns["nationality"].HeaderText = "Quốc Tịch";
            guna2DataGridView1.Columns["gender"].HeaderText = "Giới Tính";
            guna2DataGridView1.Columns["dob"].HeaderText = "Ngày Sinh";
            guna2DataGridView1.Columns["idproof"].HeaderText = "Số CMT";
            guna2DataGridView1.Columns["address"].HeaderText = "Địa Chỉ";
            guna2DataGridView1.Columns["checkin"].HeaderText = "Ngày Nhận Phòng";
            guna2DataGridView1.Columns["roomNo"].HeaderText = "Số Phòng";
            guna2DataGridView1.Columns["roomType"].HeaderText = "Loại Phòng";
            guna2DataGridView1.Columns["bed"].HeaderText = "Giường";
            guna2DataGridView1.Columns["price"].HeaderText = "Giá Phòng";
            guna2DataGridView1.Columns["branchName"].HeaderText = "Chi Nhánh";
        }

        private void UC_CustomerDetail_Load(object sender, EventArgs e)
        {

         
        }
    }
}
