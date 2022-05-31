namespace PBL3_Guna
{
    partial class UC_Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.nmItemAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.nmDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnSwapTable = new Guna.UI2.WinForms.Guna2Button();
            this.cbSwapTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.col4 = new System.Windows.Forms.ColumnHeader();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemAmount)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(624, 747);
            this.flpTable.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnAddItem);
            this.guna2Panel1.Controls.Add(this.nmItemAmount);
            this.guna2Panel1.Controls.Add(this.cbCategory);
            this.guna2Panel1.Controls.Add(this.cbItem);
            this.guna2Panel1.Location = new System.Drawing.Point(624, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(463, 133);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Animated = true;
            this.btnAddItem.BorderRadius = 10;
            this.btnAddItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(1)))));
            this.btnAddItem.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnAddItem.FocusedColor = System.Drawing.Color.White;
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(322, 45);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(138, 53);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Items";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // nmItemAmount
            // 
            this.nmItemAmount.BackColor = System.Drawing.Color.Transparent;
            this.nmItemAmount.BorderRadius = 6;
            this.nmItemAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmItemAmount.ForeColor = System.Drawing.Color.Black;
            this.nmItemAmount.Location = new System.Drawing.Point(257, 45);
            this.nmItemAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmItemAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmItemAmount.Name = "nmItemAmount";
            this.nmItemAmount.Size = new System.Drawing.Size(69, 53);
            this.nmItemAmount.TabIndex = 2;
            this.nmItemAmount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
            this.nmItemAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbCategory.BorderRadius = 10;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Location = new System.Drawing.Point(25, 12);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.ShadowDecoration.BorderRadius = 9;
            this.cbCategory.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbCategory.Size = new System.Drawing.Size(193, 36);
            this.cbCategory.TabIndex = 19;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbItem
            // 
            this.cbItem.BackColor = System.Drawing.Color.Transparent;
            this.cbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbItem.BorderRadius = 10;
            this.cbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbItem.ItemHeight = 30;
            this.cbItem.Location = new System.Drawing.Point(25, 77);
            this.cbItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbItem.Name = "cbItem";
            this.cbItem.ShadowDecoration.BorderRadius = 9;
            this.cbItem.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbItem.Size = new System.Drawing.Size(193, 36);
            this.cbItem.TabIndex = 20;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.guna2Panel2.Controls.Add(this.nmDiscount);
            this.guna2Panel2.Controls.Add(this.btnCheckOut);
            this.guna2Panel2.Controls.Add(this.txbTotalPrice);
            this.guna2Panel2.Controls.Add(this.btnSwapTable);
            this.guna2Panel2.Controls.Add(this.cbSwapTable);
            this.guna2Panel2.Location = new System.Drawing.Point(624, 636);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(463, 111);
            this.guna2Panel2.TabIndex = 0;
            // 
            // nmDiscount
            // 
            this.nmDiscount.BackColor = System.Drawing.Color.Transparent;
            this.nmDiscount.BorderRadius = 6;
            this.nmDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmDiscount.ForeColor = System.Drawing.Color.Black;
            this.nmDiscount.Location = new System.Drawing.Point(221, 54);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(69, 53);
            this.nmDiscount.TabIndex = 22;
            this.nmDiscount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Animated = true;
            this.btnCheckOut.BorderRadius = 10;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(1)))));
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnCheckOut.FocusedColor = System.Drawing.Color.White;
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.Location = new System.Drawing.Point(296, 63);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(126, 44);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Payment";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(271, 8);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.PlaceholderText = "0";
            this.txbTotalPrice.Size = new System.Drawing.Size(173, 27);
            this.txbTotalPrice.TabIndex = 9;
            // 
            // btnSwapTable
            // 
            this.btnSwapTable.Animated = true;
            this.btnSwapTable.BorderRadius = 10;
            this.btnSwapTable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(1)))));
            this.btnSwapTable.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSwapTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwapTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwapTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwapTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwapTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnSwapTable.FocusedColor = System.Drawing.Color.White;
            this.btnSwapTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSwapTable.ForeColor = System.Drawing.Color.Black;
            this.btnSwapTable.Location = new System.Drawing.Point(40, 63);
            this.btnSwapTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSwapTable.Name = "btnSwapTable";
            this.btnSwapTable.Size = new System.Drawing.Size(126, 44);
            this.btnSwapTable.TabIndex = 8;
            this.btnSwapTable.Text = "Change Table";
            this.btnSwapTable.Click += new System.EventHandler(this.btnSwapTable_Click);
            // 
            // cbSwapTable
            // 
            this.cbSwapTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSwapTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbSwapTable.BorderRadius = 10;
            this.cbSwapTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSwapTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwapTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwapTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwapTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSwapTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbSwapTable.ItemHeight = 30;
            this.cbSwapTable.Location = new System.Drawing.Point(25, 8);
            this.cbSwapTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSwapTable.Name = "cbSwapTable";
            this.cbSwapTable.ShadowDecoration.BorderRadius = 9;
            this.cbSwapTable.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbSwapTable.Size = new System.Drawing.Size(154, 36);
            this.cbSwapTable.TabIndex = 21;
            // 
            // lvBill
            // 
            this.lvBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.lvBill.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvBill.FullRowSelect = true;
            this.lvBill.GridLines = true;
            this.lvBill.HoverSelection = true;
            this.lvBill.Location = new System.Drawing.Point(624, 133);
            this.lvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(462, 501);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.UseWaitCursor = true;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "Name";
            this.col1.Width = 150;
            // 
            // col2
            // 
            this.col2.Text = "Quantity";
            this.col2.Width = 70;
            // 
            // col3
            // 
            this.col3.Text = "Price";
            this.col3.Width = 90;
            // 
            // col4
            // 
            this.col4.Text = "Total";
            this.col4.Width = 90;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.lvBill);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(1087, 747);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemAmount)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private ListView lvBill;
        private ColumnHeader col1;
        private ColumnHeader col2;
        private ColumnHeader col3;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmItemAmount;
        private ColumnHeader col4;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private TextBox txbTotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnSwapTable;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbSwapTable;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmDiscount;
    }
}
