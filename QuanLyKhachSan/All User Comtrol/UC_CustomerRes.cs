﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Comtrol
{
    public partial class UC_CustomerRes : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRes()
        {
            InitializeComponent();
        }

        public void setCombobox (String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for(int i =0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType =  '" + txtRoom.Text + "' and booked = 'NO' ";
            setCombobox(query, txtRoomNo);
        }

        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomid from rooms where roomNo = '" + txtRoomNo.Text + "' ";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtQuocTich.Text != "" && txtgender.Text != "" &&
                txtDob.Text != "" && txtIdPoof.Text != "" && txtDiaChi.Text != "" && txtCheckin.Text != "" && txtPrice.Text != "")
            {
               // int branchid = 1; chỉ thêm của chi nhanh 1
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string quoctich = txtQuocTich.Text;
                string gioitinh = txtgender.Text;
                string ngaysinh = txtDob.Text;
                string dinhdanh = txtIdPoof.Text;
                string diachi = txtDiaChi.Text;
                string checkin = txtCheckin.Text;
                int branchid = (int)cmbBranch.SelectedValue;  // Lấy branchid từ ComboBox

                query = $"INSERT INTO customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, roomid, branchid, chekout) " +
                        $"VALUES ('{name}', '{mobile}', '{quoctich}', '{gioitinh}', '{ngaysinh}', '{dinhdanh}', '{diachi}', '{checkin}', {rid}, {branchid}, 'No'); " +
                        $"UPDATE rooms SET booked = 'Yes' WHERE roomNo = '{txtRoomNo.Text}'";

                fn.setData(query, $"Số phòng {txtRoomNo.Text} đăng ký thành công");
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //private void btnThemKhachHang_Click(object sender, EventArgs e)
        //{
        //    if (txtName.Text != "" && txtContact.Text != "" && txtQuocTich.Text != "" && txtgender.Text != "" && txtDob.Text != "" && txtIdPoof.Text != "" && txtDiaChi.Text != "" && txtCheckin.Text != "" && txtPrice.Text !="")
        //    {
        //        String name = txtName.Text;
        //        Int64 mobile = Int64.Parse(txtContact.Text);
        //        String quoctich = txtQuocTich.Text;
        //        String gioitinh = txtgender.Text;
        //        String ngaysinh = txtDob.Text;
        //        String dinhdanh = txtIdPoof.Text;
        //        String diachi = txtDiaChi.Text;
        //        String checkin = txtCheckin.Text;

        //        query = "insert into customer (name, mobile, quoctich, gioitinh, ngaysinh, dinhdanh, diachi, checkin, roomid, branchid) values ('"+ name  + "','" + mobile + "','" + quoctich + "','" + gioitinh + "','" + ngaysinh + "','" + dinhdanh + "','" + diachi + "','" + checkin + "', "+ rid +" ) update rooms set booked = 'Yes' where roomNo = '"+ txtRoomNo.Text +"'";
        //        fn.setData(query, "Số phòng" + txtRoomNo.Text + "Đăng ký thành công");
        //        clearAll();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void LoadBranches()
        {
            query = "SELECT branchid, branchName FROM branch"; // Lấy danh sách chi nhánh
            DataSet ds = fn.getData(query);
            cmbBranch.DataSource = ds.Tables[0];
            cmbBranch.DisplayMember = "branchName";  // Hiển thị tên chi nhánh
            cmbBranch.ValueMember = "branchid";      // Giá trị chi nhánh tương ứng
        }

        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtQuocTich.Clear();
            txtgender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIdPoof.Clear();
            txtDiaChi.Clear();
            txtCheckin.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }
    }
}
