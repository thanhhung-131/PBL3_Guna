using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
namespace PBL3_Guna
{
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
            showDTG_Staff("");
        }
        public StaffDTO getStaffDataToAdd()
        {
            StaffDTO staff = new StaffDTO();
            staff.Name = txtNameStaff.Text;
            staff.Address = txtAddressStaff.Text;
            staff.Age = Convert.ToInt32(txtAgeStaff.Text);
            staff.PhoneNumber = txtPhoneNumberStaff.Text;
            return staff;
        }
        public StaffDTO getStaffDataToUpdate()
        {
            StaffDTO staff = new StaffDTO();
            staff.ID = Convert.ToInt32(txtIDStaff.Text);
            staff.Name = txtNameStaff.Text;
            staff.Address = txtAddressStaff.Text;
            staff.Age = Convert.ToInt32(txtAgeStaff.Text);
            staff.PhoneNumber = txtPhoneNumberStaff.Text;
            return staff;

        }
        public void showDTG_Staff(string name)
        {
            dtgvStaff.DataSource = StaffBUS.Instance.GetStaffByName(name);
        }

        public AccountDTO getDataToCreateAccount()
        {
            AccountDTO account = new AccountDTO();
            account.UserName = txtNameStaff.Text;
            account.DisplayName = txtNameStaff.Text;
            account.Password = txtPassStaff.Text;
            return account;
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (txtIDStaff.Text == "")
            {
                StaffDTO staff = getStaffDataToAdd();
                AccountDTO account = getDataToCreateAccount();
                StaffBUS.Instance.AddUpdateStaff(staff);
                showDTG_Staff("");
                account.IDStaff = Convert.ToInt32(dtgvStaff.Rows[dtgvStaff.Rows.Count - 1].Cells[0].Value.ToString());
                AccountBUS.Instance.AddAccountBUS(account);
                txtPassStaff.Text = "";

            }
            else
            {
                if (StaffBUS.Instance.Check(Convert.ToInt32(txtIDStaff.Text)))
                {
                    StaffDTO staff = getStaffDataToAdd();
                    AccountDTO account = getDataToCreateAccount();
                    StaffBUS.Instance.AddUpdateStaff(staff);
                    showDTG_Staff("");
                    account.IDStaff = Convert.ToInt32(dtgvStaff.Rows[dtgvStaff.Rows.Count - 1].Cells[0].Value.ToString());
                    AccountBUS.Instance.AddAccountBUS(account);
                    txtPassStaff.Text = "";

                }
                else MessageBox.Show("Nhân viên đã tồn tại !!");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dtgvStaff.SelectedRows.Count == 1)
            {
                int DeleteID = Convert.ToInt32(dtgvStaff.CurrentRow.Cells[0].Value.ToString());
                AccountBUS.Instance.DeleteAcount(DeleteID);
                StaffBUS.Instance.DeleteStaff(DeleteID);
            }

            showDTG_Staff("");
        }

        private void btnModifyStaff_Click(object sender, EventArgs e)
        {

            StaffDTO staff = getStaffDataToUpdate();
            StaffBUS.Instance.AddUpdateStaff(staff);
            showDTG_Staff("");
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            showDTG_Staff("");
            txtSearchStaff.Text = "";
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string name = txtSearchStaff.Text;
            showDTG_Staff(name);
        }
    }
}
