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
    public partial class UC_Employe : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employe()
        {
            InitializeComponent();
        }

    

        private void UC_Employe_Load(object sender, EventArgs e)
        {
            //getMaxId();
            loadBranches();
        }

        // Load branch data into ComboBox
        private void loadBranches()
        {
            query = "SELECT branchid, branchName FROM branch";
            DataSet ds = fn.getData(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                cmbranch.DataSource = ds.Tables[0];
                cmbranch.DisplayMember = "branchName";
                cmbranch.ValueMember = "branchid";
                cmbranch.SelectedIndex = -1; // Xóa lựa chọn ban đầu
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nhánh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //
        //public void getMaxId()
        //{
        //    query = "select max(eid) from employe";
        //    DataSet ds = fn.getData(query);
        //    if (ds.Tables[0].Rows[0][0].ToString() != "")
        //    {
        //        Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
        //        lblToSet.Text = (num + 1).ToString();

        //    }
        //}

    
        private void btnRes_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtGioiTinh.Text != "" && txtMail.Text != "" && txtUseName.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtPhone.Text);
                String gender = txtGioiTinh.Text;
                String email = txtMail.Text;
                String username = txtUseName.Text;
                String password = txtPassword.Text;

                // Lấy branchid từ ComboBox hoặc TextBox
                int branchid = (int)cmbranch.SelectedValue; // hoặc branchid = int.Parse(txtBranchId.Text);

                // Thêm branchid vào câu lệnh INSERT
                query = $"INSERT INTO employee (ename, mobile, gender, emailid, username, pass, branchid) " +
                 $"VALUES ('{name}', {mobile}, '{gender}', '{email}', '{username}', '{password}', {branchid})";

                fn.setData(query, "Đăng ký nhân viên thành công!");
                clearAll();
                //getMaxId();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void clearAll()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtGioiTinh.SelectedIndex = -1;
            txtMail.Clear();
            txtUseName.Clear();
            txtPassword.Clear();
            cmbranch.SelectedIndex = -1;
        }

      

        private void tabEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabEmploye.SelectedIndex == 1)
            {
                setEmploye(dtgChiTietNhanVien);

            }
            else if(tabEmploye.SelectedIndex == 2)
            {
                setEmploye(dtgXoaNhanVien);
            }
        }

        public void setEmploye(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Xóa thành công");
                    tabEmploye_SelectedIndexChanged(this, null);
                }
            }

        }

        private void tabEmploye_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
