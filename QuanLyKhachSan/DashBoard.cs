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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_Checkout1.Visible = false;
            uC_CustomerDetail1.Visible = false;
            uC_Employe1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddRoom.Left + 20;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();

        }

       

        private void PanelMoving_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomerRes_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerRes.Left + 30;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCheckout.Left + 30;
            uC_Checkout1.Visible = true;
            uC_Checkout1.BringToFront();
        }

        private void btnCusDetail_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCusDetail.Left + 30;
            uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();
        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnEmploye.Left + 30;
            uC_Employe1.Visible = true;
            uC_Employe1.BringToFront();
        }
    }
}
