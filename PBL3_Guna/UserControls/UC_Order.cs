using BUS;
using DAO;
using DTO;
using System;
using System.Globalization;
using System.Linq;

namespace PBL3_Guna
{
    public partial class UC_Order : UserControl
    {
        public UC_Order()
        {
            InitializeComponent();
            LoadTable();
            LoadCatergory();
            LoadComboboxTable();
        }

        void LoadComboboxTable()
        {
            cbSwapTable.Items.AddRange(TableBUS.Instance.GetListTable().ToArray());
            cbSwapTable.DisplayMember = "Name";
            cbSwapTable.SelectedIndex = 0;
        }
        void LoadCatergory()
        {
            cbCategory.Items.AddRange(CategoryBUS.Instance.GetListCategory().ToArray());
            cbCategory.DisplayMember = "Name";
            cbCategory.SelectedIndex = 0;

        }
        void LoadItemListByIDCategory(int id)
        {
            cbItem.Items.Clear();
            cbItem.Items.AddRange(ItemBUS.Instance.GetItemByIDCategory(id).ToArray());
            cbItem.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<TableDTO> tableList = TableBUS.Instance.GetListTable();
            foreach (TableDTO item in tableList)
            {
                Button btn = new Button() { Width = TableBUS.TableWidth, Height = TableBUS.TableHeight };
                btn.Text = item.Name + "\n" + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.AliceBlue;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<TempBillDTO> listBillInfor = TempBillBUS.Instance.GetListTempBillByTableID(id);
            float TotalPrice = 0;
            foreach (TempBillDTO item in listBillInfor)
            {
                ListViewItem listView = new ListViewItem(item.ItemName.ToString());
                listView.SubItems.Add(item.AmountItem.ToString());
                listView.SubItems.Add(item.Price.ToString());
                listView.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lvBill.Items.Add(listView);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = TotalPrice.ToString("c", culture);
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            int IDTable = ((sender as Button).Tag as TableDTO).ID;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(IDTable);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbItem.Text = string.Empty;
            LoadItemListByIDCategory(((CategoryDTO)cbCategory.SelectedItem).ID);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");

            TableDTO table = lvBill.Tag as TableDTO;
            int idBill = BillDAO.Instance.GetUnCheckIDBillByIDTable(table.ID);
            int discount = (int)nmDiscount.Value;
            double TotalPrice = Double.Parse(txbTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
            double FinalPrice = TotalPrice - (TotalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(String.Format("Bạn có chắc muốn thanh toán hóa đơn cho {0} \nTổng tiền = {1}", table.Name, FinalPrice.ToString("c", culture)), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, FinalPrice);
                    ShowBill(table.ID);
                }
            }
            else
                MessageBox.Show("Không tồn tại hóa đơn !");
            LoadTable();
        }

        private void btnSwapTable_Click(object sender, EventArgs e)
        {
            int id1 = (lvBill.Tag as TableDTO).ID;
            int id2 = (cbSwapTable.SelectedItem as TableDTO).ID;


            if (MessageBox.Show(String.Format("Bạn có thật sự muốn chuyển từ {0} sang {1} ?", (lvBill.Tag as TableDTO).Name, (cbSwapTable.SelectedItem as TableDTO).Name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAO.Instance.SwapTable(id1, id2);
                LoadTable();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cbItem.Text != string.Empty)
            {
                TableDTO tableDTO = lvBill.Tag as TableDTO;
                int idBill = BillDAO.Instance.GetUnCheckIDBillByIDTable(tableDTO.ID);
                int idItem = (cbItem.SelectedItem as ItemDTO).ID;
                int amount = (int)nmItemAmount.Value;
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(tableDTO.ID);
                    BillInforDAO.Instance.InsertBillInfor(BillDAO.Instance.GetMaxIDBill(), idItem, amount);
                }
                else
                {
                    BillInforDAO.Instance.InsertBillInfor(idBill, idItem, amount);
                }
                ShowBill(tableDTO.ID);
                LoadTable();
            }
            else MessageBox.Show("vui lòng chọn món");
        }
    }
}
