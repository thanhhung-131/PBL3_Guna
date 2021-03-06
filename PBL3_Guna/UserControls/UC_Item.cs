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
    public partial class UC_Item : UserControl
    {
        public UC_Item()
        {
            InitializeComponent();
            LoadCatergory();
            showDTG_Item("");
        }
        void LoadCatergory()
        {
            cxbCategoryItem.Items.Clear();
            cxbCategoryItem.Items.AddRange(CategoryBUS.Instance.GetListCategory().ToArray());
            cxbCategoryItem.DisplayMember = "Name";
            cxbCategoryItem.SelectedIndex = 0;
        }
        public void showDTG_Item(string name)
        {
            dtgvItem.DataSource = ItemBUS.Instance.GetItemByName(name);
        }
        public ItemDTO getItemDataToAdd()
        {
            ItemDTO item = new ItemDTO();
            item.Name = txtNameItem.Text;
            item.IDCategory = (CategoryDAO.Instance.GetIDbyNameCategory(cxbCategoryItem.Text));
            item.Price = Convert.ToInt32(txtPriceItem.Text);
            return item;
        }
        
        public ItemDTO getItemDataToUpdate()
        {
            ItemDTO item = new ItemDTO();
            item.ID = Convert.ToInt32(txtIDItem.Text);
            item.Name = txtNameItem.Text;
            item.IDCategory = (CategoryDAO.Instance.GetIDbyNameCategory(cxbCategoryItem.Text));
            item.Price = Convert.ToInt32(txtPriceItem.Text);
            return item;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtIDItem.Text == "")
            {
                ItemDTO item = getItemDataToAdd();
                ItemBUS.Instance.AddUpdateItem(item);
                showDTG_Item("");
            }
            else
            {
                if (ItemBUS.Instance.Check(Convert.ToInt32(txtIDItem.Text)))
                {
                    ItemDTO item = getItemDataToAdd();
                    ItemBUS.Instance.AddUpdateItem(item);
                    showDTG_Item("");
                }
                else MessageBox.Show("Item này đã tồn tại !!");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dtgvItem.SelectedRows.Count == 1)
            {
                int DeleteID = Convert.ToInt32(dtgvItem.CurrentRow.Cells[0].Value.ToString());

                ItemBUS.Instance.DeleteItem(DeleteID);
            }

            showDTG_Item("");
        }

        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            ItemDTO item = getItemDataToUpdate();
            ItemBUS.Instance.AddUpdateItem(item);
            showDTG_Item("");
        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            showDTG_Item("");
            txtSearchItem.Text = "";
        }

        private void dtgvItem_SelectionChanged(object sender, EventArgs e)
        {
            txtIDItem.Text = dtgvItem.CurrentRow.Cells[0].Value.ToString();
            txtNameItem.Text = dtgvItem.CurrentRow.Cells[1].Value.ToString();
            cxbCategoryItem.Text = CategoryDAO.Instance.GetNamebyIDCategory(Convert.ToInt32(dtgvItem.CurrentRow.Cells[2].Value.ToString()));
            txtPriceItem.Text = dtgvItem.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            string name = txtSearchItem.Text;
            showDTG_Item(name);
        }
    }
}
