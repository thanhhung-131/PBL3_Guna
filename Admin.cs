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

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UC_Home uchome = new UC_Home();
            uchome.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(uchome);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UC_Item ucitem = new UC_Item();
            ucitem.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucitem);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //PanelContainer.Controls.Clear();
            //UC_Staff ucstaff = new UC_Staff();
            //ucstaff.Dock = DockStyle.Fill;
            //PanelContainer.Controls.Add(ucstaff);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            //PanelContainer.Controls.Clear();
            //UC_Revenue ucrevenue = new UC_Revenue();
            //ucrevenue.Dock = DockStyle.Fill;
            //PanelContainer.Controls.Add(ucrevenue);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
