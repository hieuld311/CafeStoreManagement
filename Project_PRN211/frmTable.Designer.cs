namespace Project_PRN211
{
    partial class frmTable
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
			menuStrip1 = new MenuStrip();
			adminToolStripMenuItem = new ToolStripMenuItem();
			tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
			thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
			đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
			panel2 = new Panel();
			lsvBill = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			panel3 = new Panel();
			label1 = new Label();
			txtTotalPrice = new TextBox();
			nudDiscount = new NumericUpDown();
			btnCheckOut = new Button();
			panel4 = new Panel();
			btnAddFood = new Button();
			nudFoodCount = new NumericUpDown();
			cbxFood = new ComboBox();
			cbxCategory = new ComboBox();
			flpTable = new FlowLayoutPanel();
			btnRefresh = new Button();
			menuStrip1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudFoodCount).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, tàiKhoảnToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(5, 2, 0, 2);
			menuStrip1.Size = new Size(945, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			adminToolStripMenuItem.Size = new Size(55, 20);
			adminToolStripMenuItem.Text = "Admin";
			adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
			// 
			// tàiKhoảnToolStripMenuItem
			// 
			tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, đăngXuấtToolStripMenuItem });
			tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
			tàiKhoảnToolStripMenuItem.Size = new Size(70, 20);
			tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(177, 22);
			thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
			// 
			// đăngXuấtToolStripMenuItem
			// 
			đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			đăngXuấtToolStripMenuItem.Size = new Size(177, 22);
			đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
			đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(lsvBill);
			panel2.Location = new Point(485, 118);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(452, 311);
			panel2.TabIndex = 2;
			// 
			// lsvBill
			// 
			lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			lsvBill.GridLines = true;
			lsvBill.Location = new Point(0, 2);
			lsvBill.Margin = new Padding(3, 2, 3, 2);
			lsvBill.Name = "lsvBill";
			lsvBill.Size = new Size(453, 308);
			lsvBill.TabIndex = 0;
			lsvBill.UseCompatibleStateImageBehavior = false;
			lsvBill.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Tên món";
			columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Số lượng";
			columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Đơn giá";
			columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Thành tiền";
			columnHeader4.Width = 150;
			// 
			// panel3
			// 
			panel3.Controls.Add(label1);
			panel3.Controls.Add(txtTotalPrice);
			panel3.Controls.Add(nudDiscount);
			panel3.Controls.Add(btnCheckOut);
			panel3.Location = new Point(485, 434);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(452, 76);
			panel3.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(9, 29);
			label1.Name = "label1";
			label1.Size = new Size(91, 25);
			label1.TabIndex = 10;
			label1.Text = "Giảm giá:";
			// 
			// txtTotalPrice
			// 
			txtTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtTotalPrice.ForeColor = Color.Black;
			txtTotalPrice.Location = new Point(237, 29);
			txtTotalPrice.Margin = new Padding(3, 2, 3, 2);
			txtTotalPrice.Name = "txtTotalPrice";
			txtTotalPrice.ReadOnly = true;
			txtTotalPrice.Size = new Size(110, 29);
			txtTotalPrice.TabIndex = 9;
			txtTotalPrice.Text = "0";
			// 
			// nudDiscount
			// 
			nudDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			nudDiscount.Location = new Point(113, 29);
			nudDiscount.Margin = new Padding(3, 2, 3, 2);
			nudDiscount.Name = "nudDiscount";
			nudDiscount.Size = new Size(113, 29);
			nudDiscount.TabIndex = 6;
			// 
			// btnCheckOut
			// 
			btnCheckOut.Location = new Point(353, 16);
			btnCheckOut.Margin = new Padding(3, 2, 3, 2);
			btnCheckOut.Name = "btnCheckOut";
			btnCheckOut.Size = new Size(85, 55);
			btnCheckOut.TabIndex = 4;
			btnCheckOut.Text = "Thanh toán";
			btnCheckOut.UseVisualStyleBackColor = true;
			btnCheckOut.Click += btnCheckOut_Click;
			// 
			// panel4
			// 
			panel4.Controls.Add(btnRefresh);
			panel4.Controls.Add(btnAddFood);
			panel4.Controls.Add(nudFoodCount);
			panel4.Controls.Add(cbxFood);
			panel4.Controls.Add(cbxCategory);
			panel4.Location = new Point(482, 40);
			panel4.Margin = new Padding(3, 2, 3, 2);
			panel4.Name = "panel4";
			panel4.Size = new Size(452, 74);
			panel4.TabIndex = 3;
			// 
			// btnAddFood
			// 
			btnAddFood.Location = new Point(354, 27);
			btnAddFood.Margin = new Padding(3, 2, 3, 2);
			btnAddFood.Name = "btnAddFood";
			btnAddFood.Size = new Size(85, 37);
			btnAddFood.TabIndex = 3;
			btnAddFood.Text = "Thêm món";
			btnAddFood.UseVisualStyleBackColor = true;
			btnAddFood.Click += btnAddFood_Click;
			// 
			// nudFoodCount
			// 
			nudFoodCount.Location = new Point(274, 27);
			nudFoodCount.Margin = new Padding(3, 2, 3, 2);
			nudFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			nudFoodCount.Name = "nudFoodCount";
			nudFoodCount.Size = new Size(66, 23);
			nudFoodCount.TabIndex = 2;
			nudFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// cbxFood
			// 
			cbxFood.FormattingEnabled = true;
			cbxFood.Location = new Point(15, 43);
			cbxFood.Margin = new Padding(3, 2, 3, 2);
			cbxFood.Name = "cbxFood";
			cbxFood.Size = new Size(245, 23);
			cbxFood.TabIndex = 1;
			// 
			// cbxCategory
			// 
			cbxCategory.FormattingEnabled = true;
			cbxCategory.Location = new Point(15, 9);
			cbxCategory.Margin = new Padding(3, 2, 3, 2);
			cbxCategory.Name = "cbxCategory";
			cbxCategory.Size = new Size(245, 23);
			cbxCategory.TabIndex = 0;
			cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
			// 
			// flpTable
			// 
			flpTable.AutoScroll = true;
			flpTable.Location = new Point(10, 40);
			flpTable.Margin = new Padding(3, 2, 3, 2);
			flpTable.Name = "flpTable";
			flpTable.Size = new Size(458, 470);
			flpTable.TabIndex = 4;
			flpTable.Paint += flpTable_Paint;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(356, 3);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(83, 22);
			btnRefresh.TabIndex = 5;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// frmTable
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(945, 529);
			Controls.Add(flpTable);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmTable";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmTable";
			Load += frmTable_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
			panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)nudFoodCount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private Button btnAddFood;
        private NumericUpDown nudFoodCount;
        private ComboBox cbxFood;
        private ComboBox cbxCategory;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nudDiscount;
        private Button btnCheckOut;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtTotalPrice;
        private Label label1;
		private Button btnRefresh;
	}
}