
namespace QuanLyKhachSan
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMiniSize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEmploye = new Guna.UI2.WinForms.Guna2Button();
            this.btnCusDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employe1 = new QuanLyKhachSan.All_User_Comtrol.UC_Employe();
            this.uC_CustomerDetail1 = new QuanLyKhachSan.All_User_Comtrol.UC_CustomerDetail();
            this.uC_Checkout1 = new QuanLyKhachSan.All_User_Comtrol.UC_Checkout();
            this.uC_CustomerRes1 = new QuanLyKhachSan.All_User_Comtrol.UC_CustomerRes();
            this.uC_AddRoom1 = new QuanLyKhachSan.All_User_Comtrol.UC_AddRoom();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.SkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(0, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 88);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.BackColor = System.Drawing.Color.White;
            this.btnMiniSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiniSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiniSize.FillColor = System.Drawing.Color.SkyBlue;
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiniSize.ForeColor = System.Drawing.Color.White;
            this.btnMiniSize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniSize.Image")));
            this.btnMiniSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMiniSize.Location = new System.Drawing.Point(0, 102);
            this.btnMiniSize.Margin = new System.Windows.Forms.Padding(6);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(102, 88);
            this.btnMiniSize.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PanelMoving);
            this.panel1.Controls.Add(this.btnEmploye);
            this.panel1.Controls.Add(this.btnCusDetail);
            this.panel1.Controls.Add(this.btnCustomerRes);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(142, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2400, 205);
            this.panel1.TabIndex = 2;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.Red;
            this.PanelMoving.BorderRadius = 50;
            this.PanelMoving.Location = new System.Drawing.Point(120, 164);
            this.PanelMoving.Margin = new System.Windows.Forms.Padding(6);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(309, 24);
            this.PanelMoving.TabIndex = 0;
            this.PanelMoving.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMoving_Paint);
            // 
            // btnEmploye
            // 
            this.btnEmploye.BorderRadius = 18;
            this.btnEmploye.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmploye.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmploye.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmploye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmploye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmploye.FillColor = System.Drawing.Color.Aquamarine;
            this.btnEmploye.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEmploye.Location = new System.Drawing.Point(1968, 15);
            this.btnEmploye.Margin = new System.Windows.Forms.Padding(6);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(398, 148);
            this.btnEmploye.TabIndex = 4;
            this.btnEmploye.Text = "Nhân viên";
            this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);
            // 
            // btnCusDetail
            // 
            this.btnCusDetail.BorderRadius = 18;
            this.btnCusDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCusDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCusDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCusDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCusDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCusDetail.FillColor = System.Drawing.Color.Aquamarine;
            this.btnCusDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusDetail.ForeColor = System.Drawing.Color.White;
            this.btnCusDetail.Location = new System.Drawing.Point(1506, 15);
            this.btnCusDetail.Margin = new System.Windows.Forms.Padding(6);
            this.btnCusDetail.Name = "btnCusDetail";
            this.btnCusDetail.Size = new System.Drawing.Size(374, 148);
            this.btnCusDetail.TabIndex = 3;
            this.btnCusDetail.Text = "Chi tiết khách hàng";
            this.btnCusDetail.Click += new System.EventHandler(this.btnCusDetail_Click);
            // 
            // btnCustomerRes
            // 
            this.btnCustomerRes.BorderRadius = 18;
            this.btnCustomerRes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRes.FillColor = System.Drawing.Color.Aquamarine;
            this.btnCustomerRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRes.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRes.Location = new System.Drawing.Point(564, 15);
            this.btnCustomerRes.Margin = new System.Windows.Forms.Padding(6);
            this.btnCustomerRes.Name = "btnCustomerRes";
            this.btnCustomerRes.Size = new System.Drawing.Size(402, 148);
            this.btnCustomerRes.TabIndex = 2;
            this.btnCustomerRes.Text = "Đăng kí Khách hàng";
            this.btnCustomerRes.Click += new System.EventHandler(this.btnCustomerRes_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 18;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.Aquamarine;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(1020, 15);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(6);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(376, 148);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.Aquamarine;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(92, 15);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(368, 148);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_Employe1);
            this.panel2.Controls.Add(this.uC_CustomerDetail1);
            this.panel2.Controls.Add(this.uC_Checkout1);
            this.panel2.Controls.Add(this.uC_CustomerRes1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(60, 371);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2651, 1274);
            this.panel2.TabIndex = 3;
            // 
            // uC_Employe1
            // 
            this.uC_Employe1.BackColor = System.Drawing.Color.White;
            this.uC_Employe1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Employe1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Employe1.Name = "uC_Employe1";
            this.uC_Employe1.Size = new System.Drawing.Size(2565, 1250);
            this.uC_Employe1.TabIndex = 4;
            // 
            // uC_CustomerDetail1
            // 
            this.uC_CustomerDetail1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetail1.Location = new System.Drawing.Point(-1, 4);
            this.uC_CustomerDetail1.Margin = new System.Windows.Forms.Padding(12);
            this.uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            this.uC_CustomerDetail1.Size = new System.Drawing.Size(2566, 1160);
            this.uC_CustomerDetail1.TabIndex = 3;
            // 
            // uC_Checkout1
            // 
            this.uC_Checkout1.BackColor = System.Drawing.Color.White;
            this.uC_Checkout1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Checkout1.Margin = new System.Windows.Forms.Padding(12);
            this.uC_Checkout1.Name = "uC_Checkout1";
            this.uC_Checkout1.Size = new System.Drawing.Size(2638, 1063);
            this.uC_Checkout1.TabIndex = 2;
            // 
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRes1.Location = new System.Drawing.Point(4, 4);
            this.uC_CustomerRes1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(2542, 1260);
            this.uC_CustomerRes1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.AutoScroll = true;
            this.uC_AddRoom1.AutoSize = true;
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-1, -1);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(12);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(2565, 1261);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(2590, 1575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMiniSize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnEmploye;
        private Guna.UI2.WinForms.Guna2Button btnCusDetail;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRes;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private All_User_Comtrol.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Comtrol.UC_CustomerRes uC_CustomerRes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Comtrol.UC_Checkout uC_Checkout1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Comtrol.UC_CustomerDetail uC_CustomerDetail1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Comtrol.UC_Employe uC_Employe1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}