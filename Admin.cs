using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Guna
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2ContainerControl1.Controls.Clear();
            guna2ContainerControl1.Controls.Add(userControl);
            guna2ContainerControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            UC_Home uchome = new UC_Home();
            addUserControl(uchome);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            UC_Item ucitem = new UC_Item();
            addUserControl(ucitem);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            UC_Staff ucstaff = new UC_Staff();
            addUserControl((ucstaff));
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            UC_Revenue ucrevenue = new UC_Revenue();
            addUserControl(ucrevenue);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
