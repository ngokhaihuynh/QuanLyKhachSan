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
    public partial class UC_Checkout : UserControl
    {
        function fn = new function();
        String query;
        Timer timer = new Timer();
        public UC_Checkout()
        {
            InitializeComponent();
            timer.Interval = 5000; // 5 giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UC_Checkout_Load(this, null); // Tải lại dữ liệu mỗi 5 giây
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            query = @"SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, 
                     customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed,rooms.booked, 
                     rooms.price, branch.branchName 
              FROM customer
              INNER JOIN rooms ON customer.roomid = rooms.roomid 
              INNER JOIN branch ON customer.branchid = branch.branchid 
              WHERE chekout = 'No'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns["cid"].Visible = false;

            guna2DataGridView1.Columns["cname"].HeaderText = "Tên Khách Hàng";
            guna2DataGridView1.Columns["mobile"].HeaderText = "Số Điện Thoại";
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = @"SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, 
                     customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.booked,
                     rooms.price, branch.branchName 
              FROM customer
              INNER JOIN rooms ON customer.roomid = rooms.roomid 
              INNER JOIN branch ON customer.branchid = branch.branchid 
              WHERE cname LIKE '" + txtName.Text + "%' AND chekout = 'No'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(txtCName.Text != "")
            {
                if(MessageBox.Show("Bạn có chăc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckoutDate.Text;
                    query = " update customer set chekout = 'Yes', checkout = '" + cdate + "' where cid = " + id + " update rooms set booked = 'No' where roomNo = '" + txtRoom.Text + "'";
                    fn.setData(query, "Thanh toán thành công");
                    UC_Checkout_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Không có khách hàng !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckoutDate.ResetText();
        }

        private void UC_Checkout_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
