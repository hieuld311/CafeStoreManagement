namespace Project_PRN211
{
    partial class frmAdmin
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
			tbpAccount = new TabPage();
			panel13 = new Panel();
			dgvAccount = new DataGridView();
			panel14 = new Panel();
			nudAccountType = new NumericUpDown();
			btnResetPassword = new Button();
			label10 = new Label();
			txtAccountDisplayName = new TextBox();
			label11 = new Label();
			txtAccountUsername = new TextBox();
			label12 = new Label();
			panel15 = new Panel();
			btnViewAccount = new Button();
			btnUpdateAccount = new Button();
			btnDeleteAccount = new Button();
			btnAddAccount = new Button();
			tbpTable = new TabPage();
			panel8 = new Panel();
			dgvTable = new DataGridView();
			panel11 = new Panel();
			cbxTableStatus = new ComboBox();
			label9 = new Label();
			txtTableName = new TextBox();
			label5 = new Label();
			txtTableID = new TextBox();
			label6 = new Label();
			panel12 = new Panel();
			btnViewTable = new Button();
			btnUpdateTable = new Button();
			btnDeleteTable = new Button();
			btnAddTable = new Button();
			tbpCategory = new TabPage();
			panel10 = new Panel();
			dgvCategory = new DataGridView();
			panel7 = new Panel();
			txtCategoryName = new TextBox();
			label7 = new Label();
			txtCategoryID = new TextBox();
			label8 = new Label();
			panel9 = new Panel();
			btnViewCategory = new Button();
			btnUpdateCategory = new Button();
			btnDeleteCategory = new Button();
			btnAddCategory = new Button();
			tbpFood = new TabPage();
			panel6 = new Panel();
			nudPrice = new NumericUpDown();
			label4 = new Label();
			cbxCategory = new ComboBox();
			label3 = new Label();
			txtFoodName = new TextBox();
			label2 = new Label();
			txtIdFood = new TextBox();
			label1 = new Label();
			panel5 = new Panel();
			dgvFood = new DataGridView();
			panel4 = new Panel();
			txtFoodNameSearch = new TextBox();
			btnSearchFood = new Button();
			panel3 = new Panel();
			btnViewFood = new Button();
			btnUpdateFood = new Button();
			btnDeleteFood = new Button();
			btnAddFood = new Button();
			tbpBill = new TabPage();
			panel2 = new Panel();
			btnViewBill = new Button();
			dtbToDate = new DateTimePicker();
			dtbFromDate = new DateTimePicker();
			panel1 = new Panel();
			dgvBill = new DataGridView();
			tbcAdmin = new TabControl();
			tbpAccount.SuspendLayout();
			panel13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
			panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudAccountType).BeginInit();
			panel15.SuspendLayout();
			tbpTable.SuspendLayout();
			panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
			panel11.SuspendLayout();
			panel12.SuspendLayout();
			tbpCategory.SuspendLayout();
			panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
			panel7.SuspendLayout();
			panel9.SuspendLayout();
			tbpFood.SuspendLayout();
			panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			tbpBill.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
			tbcAdmin.SuspendLayout();
			SuspendLayout();
			// 
			// tbpAccount
			// 
			tbpAccount.Controls.Add(panel13);
			tbpAccount.Controls.Add(panel14);
			tbpAccount.Controls.Add(panel15);
			tbpAccount.Location = new Point(4, 24);
			tbpAccount.Margin = new Padding(3, 2, 3, 2);
			tbpAccount.Name = "tbpAccount";
			tbpAccount.Padding = new Padding(3, 2, 3, 2);
			tbpAccount.Size = new Size(817, 496);
			tbpAccount.TabIndex = 4;
			tbpAccount.Text = "Tài khoản";
			tbpAccount.UseVisualStyleBackColor = true;
			// 
			// panel13
			// 
			panel13.Controls.Add(dgvAccount);
			panel13.Location = new Point(5, 86);
			panel13.Margin = new Padding(3, 2, 3, 2);
			panel13.Name = "panel13";
			panel13.Size = new Size(449, 406);
			panel13.TabIndex = 12;
			// 
			// dgvAccount
			// 
			dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAccount.Location = new Point(3, 2);
			dgvAccount.Margin = new Padding(3, 2, 3, 2);
			dgvAccount.Name = "dgvAccount";
			dgvAccount.RowHeadersWidth = 51;
			dgvAccount.RowTemplate.Height = 29;
			dgvAccount.Size = new Size(444, 401);
			dgvAccount.TabIndex = 0;
			// 
			// panel14
			// 
			panel14.Controls.Add(nudAccountType);
			panel14.Controls.Add(btnResetPassword);
			panel14.Controls.Add(label10);
			panel14.Controls.Add(txtAccountDisplayName);
			panel14.Controls.Add(label11);
			panel14.Controls.Add(txtAccountUsername);
			panel14.Controls.Add(label12);
			panel14.Location = new Point(459, 86);
			panel14.Margin = new Padding(3, 2, 3, 2);
			panel14.Name = "panel14";
			panel14.Size = new Size(354, 406);
			panel14.TabIndex = 11;
			// 
			// nudAccountType
			// 
			nudAccountType.Location = new Point(160, 145);
			nudAccountType.Margin = new Padding(3, 2, 3, 2);
			nudAccountType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			nudAccountType.Name = "nudAccountType";
			nudAccountType.Size = new Size(172, 23);
			nudAccountType.TabIndex = 10;
			// 
			// btnResetPassword
			// 
			btnResetPassword.Location = new Point(160, 226);
			btnResetPassword.Margin = new Padding(3, 2, 3, 2);
			btnResetPassword.Name = "btnResetPassword";
			btnResetPassword.Size = new Size(172, 47);
			btnResetPassword.TabIndex = 4;
			btnResetPassword.Text = "Đặt lại mật khẩu";
			btnResetPassword.UseVisualStyleBackColor = true;
			btnResetPassword.Click += btnResetPassword_Click;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(5, 140);
			label10.Name = "label10";
			label10.Size = new Size(134, 25);
			label10.TabIndex = 9;
			label10.Text = "Loại tài khoản:";
			// 
			// txtAccountDisplayName
			// 
			txtAccountDisplayName.Location = new Point(160, 88);
			txtAccountDisplayName.Margin = new Padding(3, 2, 3, 2);
			txtAccountDisplayName.Name = "txtAccountDisplayName";
			txtAccountDisplayName.Size = new Size(173, 23);
			txtAccountDisplayName.TabIndex = 8;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label11.Location = new Point(5, 83);
			label11.Name = "label11";
			label11.Size = new Size(119, 25);
			label11.TabIndex = 7;
			label11.Text = "Tên hiển thị: ";
			// 
			// txtAccountUsername
			// 
			txtAccountUsername.Location = new Point(160, 28);
			txtAccountUsername.Margin = new Padding(3, 2, 3, 2);
			txtAccountUsername.Name = "txtAccountUsername";
			txtAccountUsername.Size = new Size(173, 23);
			txtAccountUsername.TabIndex = 6;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label12.Location = new Point(3, 23);
			label12.Name = "label12";
			label12.Size = new Size(128, 25);
			label12.TabIndex = 0;
			label12.Text = "Tên tài khoản:";
			// 
			// panel15
			// 
			panel15.Controls.Add(btnViewAccount);
			panel15.Controls.Add(btnUpdateAccount);
			panel15.Controls.Add(btnDeleteAccount);
			panel15.Controls.Add(btnAddAccount);
			panel15.Location = new Point(5, 8);
			panel15.Margin = new Padding(3, 2, 3, 2);
			panel15.Name = "panel15";
			panel15.Size = new Size(449, 70);
			panel15.TabIndex = 10;
			// 
			// btnViewAccount
			// 
			btnViewAccount.Location = new Point(339, 9);
			btnViewAccount.Margin = new Padding(3, 2, 3, 2);
			btnViewAccount.Name = "btnViewAccount";
			btnViewAccount.Size = new Size(94, 48);
			btnViewAccount.TabIndex = 3;
			btnViewAccount.Text = "Xem ";
			btnViewAccount.UseVisualStyleBackColor = true;
			btnViewAccount.Click += btnViewAccount_Click;
			// 
			// btnUpdateAccount
			// 
			btnUpdateAccount.Location = new Point(230, 9);
			btnUpdateAccount.Margin = new Padding(3, 2, 3, 2);
			btnUpdateAccount.Name = "btnUpdateAccount";
			btnUpdateAccount.Size = new Size(94, 48);
			btnUpdateAccount.TabIndex = 2;
			btnUpdateAccount.Text = "Sửa ";
			btnUpdateAccount.UseVisualStyleBackColor = true;
			btnUpdateAccount.Click += btnUpdateAccount_Click;
			// 
			// btnDeleteAccount
			// 
			btnDeleteAccount.Location = new Point(119, 9);
			btnDeleteAccount.Margin = new Padding(3, 2, 3, 2);
			btnDeleteAccount.Name = "btnDeleteAccount";
			btnDeleteAccount.Size = new Size(94, 48);
			btnDeleteAccount.TabIndex = 1;
			btnDeleteAccount.Text = "Xóa";
			btnDeleteAccount.UseVisualStyleBackColor = true;
			btnDeleteAccount.Click += btnDeleteAccount_Click;
			// 
			// btnAddAccount
			// 
			btnAddAccount.Location = new Point(3, 9);
			btnAddAccount.Margin = new Padding(3, 2, 3, 2);
			btnAddAccount.Name = "btnAddAccount";
			btnAddAccount.Size = new Size(94, 48);
			btnAddAccount.TabIndex = 0;
			btnAddAccount.Text = "Thêm ";
			btnAddAccount.UseVisualStyleBackColor = true;
			btnAddAccount.Click += btnAddAccount_Click;
			// 
			// tbpTable
			// 
			tbpTable.Controls.Add(panel8);
			tbpTable.Controls.Add(panel11);
			tbpTable.Controls.Add(panel12);
			tbpTable.Location = new Point(4, 24);
			tbpTable.Margin = new Padding(3, 2, 3, 2);
			tbpTable.Name = "tbpTable";
			tbpTable.Padding = new Padding(3, 2, 3, 2);
			tbpTable.Size = new Size(817, 496);
			tbpTable.TabIndex = 3;
			tbpTable.Text = "Bàn";
			tbpTable.UseVisualStyleBackColor = true;
			// 
			// panel8
			// 
			panel8.Controls.Add(dgvTable);
			panel8.Location = new Point(5, 86);
			panel8.Margin = new Padding(3, 2, 3, 2);
			panel8.Name = "panel8";
			panel8.Size = new Size(449, 406);
			panel8.TabIndex = 9;
			// 
			// dgvTable
			// 
			dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTable.Location = new Point(3, 2);
			dgvTable.Margin = new Padding(3, 2, 3, 2);
			dgvTable.Name = "dgvTable";
			dgvTable.RowHeadersWidth = 51;
			dgvTable.RowTemplate.Height = 29;
			dgvTable.Size = new Size(444, 401);
			dgvTable.TabIndex = 0;
			// 
			// panel11
			// 
			panel11.Controls.Add(cbxTableStatus);
			panel11.Controls.Add(label9);
			panel11.Controls.Add(txtTableName);
			panel11.Controls.Add(label5);
			panel11.Controls.Add(txtTableID);
			panel11.Controls.Add(label6);
			panel11.Location = new Point(459, 86);
			panel11.Margin = new Padding(3, 2, 3, 2);
			panel11.Name = "panel11";
			panel11.Size = new Size(354, 406);
			panel11.TabIndex = 8;
			// 
			// cbxTableStatus
			// 
			cbxTableStatus.FormattingEnabled = true;
			cbxTableStatus.Location = new Point(160, 142);
			cbxTableStatus.Margin = new Padding(3, 2, 3, 2);
			cbxTableStatus.Name = "cbxTableStatus";
			cbxTableStatus.Size = new Size(173, 23);
			cbxTableStatus.TabIndex = 10;
			cbxTableStatus.SelectedIndexChanged += cbxTableStatus_SelectedIndexChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(5, 136);
			label9.Name = "label9";
			label9.Size = new Size(100, 25);
			label9.TabIndex = 9;
			label9.Text = "Trạng thái:";
			// 
			// txtTableName
			// 
			txtTableName.Location = new Point(160, 83);
			txtTableName.Margin = new Padding(3, 2, 3, 2);
			txtTableName.Name = "txtTableName";
			txtTableName.Size = new Size(173, 23);
			txtTableName.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(5, 80);
			label5.Name = "label5";
			label5.Size = new Size(87, 25);
			label5.TabIndex = 7;
			label5.Text = "Tên bàn: ";
			// 
			// txtTableID
			// 
			txtTableID.Location = new Point(160, 23);
			txtTableID.Margin = new Padding(3, 2, 3, 2);
			txtTableID.Name = "txtTableID";
			txtTableID.ReadOnly = true;
			txtTableID.Size = new Size(173, 23);
			txtTableID.TabIndex = 6;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(15, 20);
			label6.Name = "label6";
			label6.Size = new Size(34, 25);
			label6.TabIndex = 0;
			label6.Text = "ID:";
			// 
			// panel12
			// 
			panel12.Controls.Add(btnViewTable);
			panel12.Controls.Add(btnUpdateTable);
			panel12.Controls.Add(btnDeleteTable);
			panel12.Controls.Add(btnAddTable);
			panel12.Location = new Point(5, 8);
			panel12.Margin = new Padding(3, 2, 3, 2);
			panel12.Name = "panel12";
			panel12.Size = new Size(449, 70);
			panel12.TabIndex = 7;
			// 
			// btnViewTable
			// 
			btnViewTable.Location = new Point(339, 9);
			btnViewTable.Margin = new Padding(3, 2, 3, 2);
			btnViewTable.Name = "btnViewTable";
			btnViewTable.Size = new Size(94, 48);
			btnViewTable.TabIndex = 3;
			btnViewTable.Text = "Xem ";
			btnViewTable.UseVisualStyleBackColor = true;
			btnViewTable.Click += btnViewTable_Click;
			// 
			// btnUpdateTable
			// 
			btnUpdateTable.Location = new Point(230, 9);
			btnUpdateTable.Margin = new Padding(3, 2, 3, 2);
			btnUpdateTable.Name = "btnUpdateTable";
			btnUpdateTable.Size = new Size(94, 48);
			btnUpdateTable.TabIndex = 2;
			btnUpdateTable.Text = "Sửa ";
			btnUpdateTable.UseVisualStyleBackColor = true;
			btnUpdateTable.Click += btnUpdateTable_Click;
			// 
			// btnDeleteTable
			// 
			btnDeleteTable.Location = new Point(119, 9);
			btnDeleteTable.Margin = new Padding(3, 2, 3, 2);
			btnDeleteTable.Name = "btnDeleteTable";
			btnDeleteTable.Size = new Size(94, 48);
			btnDeleteTable.TabIndex = 1;
			btnDeleteTable.Text = "Xóa";
			btnDeleteTable.UseVisualStyleBackColor = true;
			btnDeleteTable.Click += btnDeleteTable_Click;
			// 
			// btnAddTable
			// 
			btnAddTable.Location = new Point(3, 9);
			btnAddTable.Margin = new Padding(3, 2, 3, 2);
			btnAddTable.Name = "btnAddTable";
			btnAddTable.Size = new Size(94, 48);
			btnAddTable.TabIndex = 0;
			btnAddTable.Text = "Thêm ";
			btnAddTable.UseVisualStyleBackColor = true;
			btnAddTable.Click += btnAddTable_Click;
			// 
			// tbpCategory
			// 
			tbpCategory.Controls.Add(panel10);
			tbpCategory.Controls.Add(panel7);
			tbpCategory.Controls.Add(panel9);
			tbpCategory.Location = new Point(4, 24);
			tbpCategory.Margin = new Padding(3, 2, 3, 2);
			tbpCategory.Name = "tbpCategory";
			tbpCategory.Padding = new Padding(3, 2, 3, 2);
			tbpCategory.Size = new Size(817, 496);
			tbpCategory.TabIndex = 2;
			tbpCategory.Text = "Danh mục";
			tbpCategory.UseVisualStyleBackColor = true;
			// 
			// panel10
			// 
			panel10.Controls.Add(dgvCategory);
			panel10.Location = new Point(5, 86);
			panel10.Margin = new Padding(3, 2, 3, 2);
			panel10.Name = "panel10";
			panel10.Size = new Size(449, 406);
			panel10.TabIndex = 6;
			// 
			// dgvCategory
			// 
			dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCategory.Location = new Point(3, 2);
			dgvCategory.Margin = new Padding(3, 2, 3, 2);
			dgvCategory.Name = "dgvCategory";
			dgvCategory.RowHeadersWidth = 51;
			dgvCategory.RowTemplate.Height = 29;
			dgvCategory.Size = new Size(444, 401);
			dgvCategory.TabIndex = 0;
			// 
			// panel7
			// 
			panel7.Controls.Add(txtCategoryName);
			panel7.Controls.Add(label7);
			panel7.Controls.Add(txtCategoryID);
			panel7.Controls.Add(label8);
			panel7.Location = new Point(459, 86);
			panel7.Margin = new Padding(3, 2, 3, 2);
			panel7.Name = "panel7";
			panel7.Size = new Size(354, 406);
			panel7.TabIndex = 5;
			// 
			// txtCategoryName
			// 
			txtCategoryName.Location = new Point(160, 83);
			txtCategoryName.Margin = new Padding(3, 2, 3, 2);
			txtCategoryName.Name = "txtCategoryName";
			txtCategoryName.Size = new Size(173, 23);
			txtCategoryName.TabIndex = 8;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(5, 80);
			label7.Name = "label7";
			label7.Size = new Size(134, 25);
			label7.TabIndex = 7;
			label7.Text = "Tên danh mục:";
			// 
			// txtCategoryID
			// 
			txtCategoryID.Location = new Point(160, 23);
			txtCategoryID.Margin = new Padding(3, 2, 3, 2);
			txtCategoryID.Name = "txtCategoryID";
			txtCategoryID.ReadOnly = true;
			txtCategoryID.Size = new Size(173, 23);
			txtCategoryID.TabIndex = 6;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(15, 20);
			label8.Name = "label8";
			label8.Size = new Size(34, 25);
			label8.TabIndex = 0;
			label8.Text = "ID:";
			// 
			// panel9
			// 
			panel9.Controls.Add(btnViewCategory);
			panel9.Controls.Add(btnUpdateCategory);
			panel9.Controls.Add(btnDeleteCategory);
			panel9.Controls.Add(btnAddCategory);
			panel9.Location = new Point(5, 8);
			panel9.Margin = new Padding(3, 2, 3, 2);
			panel9.Name = "panel9";
			panel9.Size = new Size(449, 70);
			panel9.TabIndex = 3;
			// 
			// btnViewCategory
			// 
			btnViewCategory.Location = new Point(339, 9);
			btnViewCategory.Margin = new Padding(3, 2, 3, 2);
			btnViewCategory.Name = "btnViewCategory";
			btnViewCategory.Size = new Size(94, 48);
			btnViewCategory.TabIndex = 3;
			btnViewCategory.Text = "Xem ";
			btnViewCategory.UseVisualStyleBackColor = true;
			btnViewCategory.Click += btnViewCategory_Click;
			// 
			// btnUpdateCategory
			// 
			btnUpdateCategory.Location = new Point(230, 9);
			btnUpdateCategory.Margin = new Padding(3, 2, 3, 2);
			btnUpdateCategory.Name = "btnUpdateCategory";
			btnUpdateCategory.Size = new Size(94, 48);
			btnUpdateCategory.TabIndex = 2;
			btnUpdateCategory.Text = "Sửa ";
			btnUpdateCategory.UseVisualStyleBackColor = true;
			btnUpdateCategory.Click += btnUpdateCategory_Click;
			// 
			// btnDeleteCategory
			// 
			btnDeleteCategory.Location = new Point(119, 9);
			btnDeleteCategory.Margin = new Padding(3, 2, 3, 2);
			btnDeleteCategory.Name = "btnDeleteCategory";
			btnDeleteCategory.Size = new Size(94, 48);
			btnDeleteCategory.TabIndex = 1;
			btnDeleteCategory.Text = "Xóa";
			btnDeleteCategory.UseVisualStyleBackColor = true;
			btnDeleteCategory.Click += btnDeleteCategory_Click;
			// 
			// btnAddCategory
			// 
			btnAddCategory.Location = new Point(3, 9);
			btnAddCategory.Margin = new Padding(3, 2, 3, 2);
			btnAddCategory.Name = "btnAddCategory";
			btnAddCategory.Size = new Size(94, 48);
			btnAddCategory.TabIndex = 0;
			btnAddCategory.Text = "Thêm ";
			btnAddCategory.UseVisualStyleBackColor = true;
			btnAddCategory.Click += btnAddCategory_Click;
			// 
			// tbpFood
			// 
			tbpFood.Controls.Add(panel6);
			tbpFood.Controls.Add(panel5);
			tbpFood.Controls.Add(panel4);
			tbpFood.Controls.Add(panel3);
			tbpFood.Location = new Point(4, 24);
			tbpFood.Margin = new Padding(3, 2, 3, 2);
			tbpFood.Name = "tbpFood";
			tbpFood.Padding = new Padding(3, 2, 3, 2);
			tbpFood.Size = new Size(817, 496);
			tbpFood.TabIndex = 1;
			tbpFood.Text = "Món";
			tbpFood.UseVisualStyleBackColor = true;
			// 
			// panel6
			// 
			panel6.Controls.Add(nudPrice);
			panel6.Controls.Add(label4);
			panel6.Controls.Add(cbxCategory);
			panel6.Controls.Add(label3);
			panel6.Controls.Add(txtFoodName);
			panel6.Controls.Add(label2);
			panel6.Controls.Add(txtIdFood);
			panel6.Controls.Add(label1);
			panel6.Location = new Point(459, 82);
			panel6.Margin = new Padding(3, 2, 3, 2);
			panel6.Name = "panel6";
			panel6.Size = new Size(354, 406);
			panel6.TabIndex = 2;
			// 
			// nudPrice
			// 
			nudPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
			nudPrice.Location = new Point(119, 197);
			nudPrice.Margin = new Padding(3, 2, 3, 2);
			nudPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
			nudPrice.Name = "nudPrice";
			nudPrice.Size = new Size(214, 23);
			nudPrice.TabIndex = 13;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(5, 192);
			label4.Name = "label4";
			label4.Size = new Size(44, 25);
			label4.TabIndex = 12;
			label4.Text = "Giá:";
			// 
			// cbxCategory
			// 
			cbxCategory.FormattingEnabled = true;
			cbxCategory.Location = new Point(119, 136);
			cbxCategory.Margin = new Padding(3, 2, 3, 2);
			cbxCategory.Name = "cbxCategory";
			cbxCategory.Size = new Size(214, 23);
			cbxCategory.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(5, 136);
			label3.Name = "label3";
			label3.Size = new Size(107, 25);
			label3.TabIndex = 9;
			label3.Text = "Danh mục: ";
			// 
			// txtFoodName
			// 
			txtFoodName.Location = new Point(119, 83);
			txtFoodName.Margin = new Padding(3, 2, 3, 2);
			txtFoodName.Name = "txtFoodName";
			txtFoodName.Size = new Size(214, 23);
			txtFoodName.TabIndex = 8;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(5, 80);
			label2.Name = "label2";
			label2.Size = new Size(88, 25);
			label2.TabIndex = 7;
			label2.Text = "Tên món:";
			// 
			// txtIdFood
			// 
			txtIdFood.Location = new Point(119, 23);
			txtIdFood.Margin = new Padding(3, 2, 3, 2);
			txtIdFood.Name = "txtIdFood";
			txtIdFood.ReadOnly = true;
			txtIdFood.Size = new Size(214, 23);
			txtIdFood.TabIndex = 6;
			txtIdFood.TextChanged += txtFoodID_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(15, 20);
			label1.Name = "label1";
			label1.Size = new Size(34, 25);
			label1.TabIndex = 0;
			label1.Text = "ID:";
			// 
			// panel5
			// 
			panel5.Controls.Add(dgvFood);
			panel5.Location = new Point(5, 80);
			panel5.Margin = new Padding(3, 2, 3, 2);
			panel5.Name = "panel5";
			panel5.Size = new Size(449, 408);
			panel5.TabIndex = 0;
			// 
			// dgvFood
			// 
			dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFood.Location = new Point(3, 2);
			dgvFood.Margin = new Padding(3, 2, 3, 2);
			dgvFood.Name = "dgvFood";
			dgvFood.RowHeadersWidth = 51;
			dgvFood.RowTemplate.Height = 29;
			dgvFood.Size = new Size(444, 404);
			dgvFood.TabIndex = 0;
			// 
			// panel4
			// 
			panel4.Controls.Add(txtFoodNameSearch);
			panel4.Controls.Add(btnSearchFood);
			panel4.Location = new Point(459, 4);
			panel4.Margin = new Padding(3, 2, 3, 2);
			panel4.Name = "panel4";
			panel4.Size = new Size(354, 70);
			panel4.TabIndex = 1;
			// 
			// txtFoodNameSearch
			// 
			txtFoodNameSearch.Location = new Point(15, 23);
			txtFoodNameSearch.Margin = new Padding(3, 2, 3, 2);
			txtFoodNameSearch.Name = "txtFoodNameSearch";
			txtFoodNameSearch.Size = new Size(221, 23);
			txtFoodNameSearch.TabIndex = 5;
			// 
			// btnSearchFood
			// 
			btnSearchFood.Location = new Point(256, 9);
			btnSearchFood.Margin = new Padding(3, 2, 3, 2);
			btnSearchFood.Name = "btnSearchFood";
			btnSearchFood.Size = new Size(94, 48);
			btnSearchFood.TabIndex = 4;
			btnSearchFood.Text = "Tìm món";
			btnSearchFood.UseVisualStyleBackColor = true;
			btnSearchFood.Click += btnSearchFood_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(btnViewFood);
			panel3.Controls.Add(btnUpdateFood);
			panel3.Controls.Add(btnDeleteFood);
			panel3.Controls.Add(btnAddFood);
			panel3.Location = new Point(5, 4);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(449, 70);
			panel3.TabIndex = 0;
			// 
			// btnViewFood
			// 
			btnViewFood.Location = new Point(339, 9);
			btnViewFood.Margin = new Padding(3, 2, 3, 2);
			btnViewFood.Name = "btnViewFood";
			btnViewFood.Size = new Size(94, 48);
			btnViewFood.TabIndex = 3;
			btnViewFood.Text = "Xem món";
			btnViewFood.UseVisualStyleBackColor = true;
			btnViewFood.Click += btnViewFood_Click;
			// 
			// btnUpdateFood
			// 
			btnUpdateFood.Location = new Point(230, 9);
			btnUpdateFood.Margin = new Padding(3, 2, 3, 2);
			btnUpdateFood.Name = "btnUpdateFood";
			btnUpdateFood.Size = new Size(94, 48);
			btnUpdateFood.TabIndex = 2;
			btnUpdateFood.Text = "Sửa món";
			btnUpdateFood.UseVisualStyleBackColor = true;
			btnUpdateFood.Click += btnUpdateFood_Click;
			// 
			// btnDeleteFood
			// 
			btnDeleteFood.Location = new Point(119, 9);
			btnDeleteFood.Margin = new Padding(3, 2, 3, 2);
			btnDeleteFood.Name = "btnDeleteFood";
			btnDeleteFood.Size = new Size(94, 48);
			btnDeleteFood.TabIndex = 1;
			btnDeleteFood.Text = "Xóa món";
			btnDeleteFood.UseVisualStyleBackColor = true;
			btnDeleteFood.Click += btnDeleteFood_Click;
			// 
			// btnAddFood
			// 
			btnAddFood.Location = new Point(3, 9);
			btnAddFood.Margin = new Padding(3, 2, 3, 2);
			btnAddFood.Name = "btnAddFood";
			btnAddFood.Size = new Size(94, 48);
			btnAddFood.TabIndex = 0;
			btnAddFood.Text = "Thêm món";
			btnAddFood.UseVisualStyleBackColor = true;
			btnAddFood.Click += btnAddFood_Click;
			// 
			// tbpBill
			// 
			tbpBill.Controls.Add(panel2);
			tbpBill.Controls.Add(panel1);
			tbpBill.Location = new Point(4, 24);
			tbpBill.Margin = new Padding(3, 2, 3, 2);
			tbpBill.Name = "tbpBill";
			tbpBill.Padding = new Padding(3, 2, 3, 2);
			tbpBill.Size = new Size(817, 496);
			tbpBill.TabIndex = 0;
			tbpBill.Text = "Doanh thu";
			tbpBill.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnViewBill);
			panel2.Controls.Add(dtbToDate);
			panel2.Controls.Add(dtbFromDate);
			panel2.Location = new Point(5, 4);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(808, 49);
			panel2.TabIndex = 1;
			// 
			// btnViewBill
			// 
			btnViewBill.Location = new Point(621, 10);
			btnViewBill.Margin = new Padding(3, 2, 3, 2);
			btnViewBill.Name = "btnViewBill";
			btnViewBill.Size = new Size(120, 26);
			btnViewBill.TabIndex = 2;
			btnViewBill.Text = "Thống kê";
			btnViewBill.UseVisualStyleBackColor = true;
			btnViewBill.Click += btnViewBill_Click;
			// 
			// dtbToDate
			// 
			dtbToDate.Location = new Point(309, 11);
			dtbToDate.Margin = new Padding(3, 2, 3, 2);
			dtbToDate.Name = "dtbToDate";
			dtbToDate.Size = new Size(219, 23);
			dtbToDate.TabIndex = 1;
			// 
			// dtbFromDate
			// 
			dtbFromDate.Location = new Point(25, 11);
			dtbFromDate.Margin = new Padding(3, 2, 3, 2);
			dtbFromDate.Name = "dtbFromDate";
			dtbFromDate.Size = new Size(219, 23);
			dtbFromDate.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(dgvBill);
			panel1.Location = new Point(5, 58);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(808, 437);
			panel1.TabIndex = 0;
			// 
			// dgvBill
			// 
			dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBill.Location = new Point(3, 2);
			dgvBill.Margin = new Padding(3, 2, 3, 2);
			dgvBill.Name = "dgvBill";
			dgvBill.RowHeadersWidth = 51;
			dgvBill.RowTemplate.Height = 29;
			dgvBill.Size = new Size(802, 433);
			dgvBill.TabIndex = 0;
			// 
			// tbcAdmin
			// 
			tbcAdmin.Controls.Add(tbpBill);
			tbcAdmin.Controls.Add(tbpFood);
			tbcAdmin.Controls.Add(tbpCategory);
			tbcAdmin.Controls.Add(tbpTable);
			tbcAdmin.Controls.Add(tbpAccount);
			tbcAdmin.Location = new Point(20, 21);
			tbcAdmin.Margin = new Padding(3, 2, 3, 2);
			tbcAdmin.Name = "tbcAdmin";
			tbcAdmin.SelectedIndex = 0;
			tbcAdmin.Size = new Size(825, 524);
			tbcAdmin.TabIndex = 0;
			// 
			// frmAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(863, 563);
			Controls.Add(tbcAdmin);
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmAdmin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Admin";
			tbpAccount.ResumeLayout(false);
			panel13.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
			panel14.ResumeLayout(false);
			panel14.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudAccountType).EndInit();
			panel15.ResumeLayout(false);
			tbpTable.ResumeLayout(false);
			panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
			panel11.ResumeLayout(false);
			panel11.PerformLayout();
			panel12.ResumeLayout(false);
			tbpCategory.ResumeLayout(false);
			panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel9.ResumeLayout(false);
			tbpFood.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
			panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			tbpBill.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
			tbcAdmin.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabPage tbpAccount;
        private Panel panel13;
        private DataGridView dgvAccount;
        private Panel panel14;
        private Label label10;
        private TextBox txtAccountDisplayName;
        private Label label11;
        private TextBox txtAccountUsername;
        private Label label12;
        private Panel panel15;
        private Button btnViewAccount;
        private Button btnUpdateAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private TabPage tbpTable;
        private Panel panel8;
        private DataGridView dgvTable;
        private Panel panel11;
        private ComboBox cbxTableStatus;
        private Label label9;
        private TextBox txtTableName;
        private Label label5;
        private TextBox txtTableID;
        private Label label6;
        private Panel panel12;
        private Button btnViewTable;
        private Button btnUpdateTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private TabPage tbpCategory;
        private Panel panel10;
        private DataGridView dgvCategory;
        private Panel panel7;
        private TextBox txtCategoryName;
        private Label label7;
        private TextBox txtCategoryID;
        private Label label8;
        private Panel panel9;
        private Button btnViewCategory;
        private Button btnUpdateCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private TabPage tbpFood;
        private Panel panel6;
        private NumericUpDown nudPrice;
        private Label label4;
        private ComboBox cbxCategory;
        private Label label3;
        private TextBox txtFoodName;
        private Label label2;
        private TextBox txtIdFood;
        private Label label1;
        private Panel panel5;
        private DataGridView dgvFood;
        private Panel panel4;
        private TextBox txtFoodNameSearch;
        private Button btnSearchFood;
        private Panel panel3;
        private Button btnViewFood;
        private Button btnUpdateFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private TabPage tbpBill;
        private Panel panel2;
        private Button btnViewBill;
        private DateTimePicker dtbToDate;
        private DateTimePicker dtbFromDate;
        private Panel panel1;
        private DataGridView dgvBill;
        private TabControl tbcAdmin;
        private Button btnResetPassword;
        private NumericUpDown nudAccountType;
    }
}