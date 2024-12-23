using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Comtrol
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
         private bool isUpdating = false; // Cờ kiểm tra xem có đang cập nhật hay không
        public UC_AddRoom()
        {
            InitializeComponent();
             dtgThemPhong.CellEndEdit += dtgThemPhong_CellEndEdit;
          
        }


        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            LoadBranches(); // Tải chi nhánh khi mở form
            LoadRooms(); // Tải các phòng
           
        }

        private void LoadBranches()
        {
            query = "SELECT branchid, branchName FROM branch"; // Truy vấn lấy danh sách chi nhánh
            DataSet ds = fn.getData(query);
            cmbBranch.DataSource = ds.Tables[0];
            cmbBranch.DisplayMember = "branchName";  // Hiển thị tên chi nhánh
            cmbBranch.ValueMember = "branchid";      // Giá trị chi nhánh tương ứng
        }

        private void LoadRooms()
        {
            query = @"
                SELECT r.*, b.branchName 
                FROM rooms r 
                JOIN branch b ON r.branchid = b.branchid";
            DataSet ds = fn.getData(query);
            dtgThemPhong.ReadOnly = false;
            dtgThemPhong.DataSource = ds.Tables[0];
            dtgThemPhong.Columns["branchid"].Visible = false; // ẩn id chi nhánh
            dtgThemPhong.Columns["roomid"].Visible = false;
            dtgThemPhong.Columns["rowguid"].Visible = false;

            dtgThemPhong.Font = new Font("Arial", 10); // Hoặc bất kỳ font nào hỗ trợ tiếng Việt


            dtgThemPhong.Columns["branchName"].HeaderText = "Tên Chi Nhánh"; // Đổi tên cột tên chi nhánh
            dtgThemPhong.Columns["roomNo"].HeaderText = "Số Phòng"; // Đổi tên cột số phòng
            dtgThemPhong.Columns["roomType"].HeaderText = "Loại Phòng"; // Đổi tên cột loại phòng
            dtgThemPhong.Columns["bed"].HeaderText = "Giường"; // Đổi tên cột giường
            dtgThemPhong.Columns["price"].HeaderText = "Giá"; // Đổi tên cột giá
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "" && cmbBranch.SelectedValue != null)
            {
                String roomno = txtRoomNo.Text;
                String type = txtRoomType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                int branchid = (int)cmbBranch.SelectedValue; // Lấy ID chi nhánh từ ComboBox

                query = "INSERT INTO rooms (roomNo, roomType, bed, price, branchid) VALUES ('" + roomno + "', '" + type + "', '" + bed + "', " + price + ", " + branchid + ")";
                fn.setData(query, "Đã thêm phòng");

                LoadRooms(); // Tải lại các phòng sau khi thêm
                clearAll();  // Xóa các trường nhập liệu
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn chi nhánh.");
            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
            cmbBranch.SelectedIndex = -1; // Xóa lựa chọn chi nhánh
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            LoadRooms(); // Tải lại các phòng khi vào lại form
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDeleteRoomNo.Text))
            {
                string roomNo = txtDeleteRoomNo.Text;

                // Bước 1: Xóa tất cả khách hàng có roomid tương ứng
                query = $"DELETE FROM customer WHERE roomid IN (SELECT roomid FROM rooms WHERE roomNo = '{roomNo}')";
                fn.setData(query, "Đã xóa tất cả khách hàng liên quan đến phòng!");

                // Bước 2: Xóa phòng
                query = $"DELETE FROM rooms WHERE roomNo = '{roomNo}'";
                fn.setData(query, "Đã xóa phòng thành công!");

                txtDeleteRoomNo.Clear(); // Xóa TextBox sau khi xóa
                LoadRooms(); // Tải lại danh sách phòng
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số phòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgThemPhong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                int roomId = Convert.ToInt32(dtgThemPhong.Rows[rowIndex].Cells["roomid"].Value); // Lấy roomid để xác định dòng
                string columnName = dtgThemPhong.Columns[e.ColumnIndex].Name; // Lấy tên cột đang chỉnh sửa
                object newValue = dtgThemPhong.Rows[rowIndex].Cells[e.ColumnIndex].Value; // Lấy giá trị mới

                // Chỉ cho phép chỉnh sửa hai cột roomNo và price
                if (columnName == "roomNo" || columnName == "price")
                {
                    // Tạo câu truy vấn để cập nhật giá trị vào cột tương ứng
                    query = $"UPDATE rooms SET {columnName} = N'{newValue}' WHERE roomid = {roomId}";
                    fn.setData(query, "Cập nhật thành công!"); // Cập nhật vào cơ sở dữ liệu và hiển thị thông báo
                }
                else
                {
                    MessageBox.Show("Chỉ được phép chỉnh sửa Số Phòng và Giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Đặt lại giá trị cũ nếu người dùng chỉnh sửa các cột khác
                    dtgThemPhong.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
