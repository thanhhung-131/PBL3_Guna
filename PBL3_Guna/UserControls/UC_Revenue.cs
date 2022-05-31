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
    public partial class UC_Revenue : UserControl
    {
        public UC_Revenue()
        {
            InitializeComponent();
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            //ShowBill(dtpkFromDate.Value, dtpkToDate.Value);
        }
        public void ShowBill(DateTime checkIn, DateTime checkOut)
        {
            int total = 0;
           // dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
            for(int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                total += Convert.ToInt32(dtgvBill.Rows[i].Cells[1].Value.ToString());
            }    
            lblTotalPrice.Text = total.ToString();
        }
    }
}
