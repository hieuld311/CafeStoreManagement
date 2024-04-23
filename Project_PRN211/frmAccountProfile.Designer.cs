namespace Project_PRN211
{
    partial class frmAccountProfile
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
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDisplayName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtNewPassword = new TextBox();
            txtRepassword = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(297, 51);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(429, 39);
            txtUsername.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(256, 46);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 133);
            label2.Name = "label2";
            label2.Size = new Size(206, 46);
            label2.TabIndex = 6;
            label2.Text = "Tên hiển thị";
            // 
            // txtDisplayName
            // 
            txtDisplayName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplayName.Location = new Point(297, 140);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(429, 39);
            txtDisplayName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 235);
            label3.Name = "label3";
            label3.Size = new Size(171, 46);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(297, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(429, 39);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 330);
            label4.Name = "label4";
            label4.Size = new Size(242, 46);
            label4.TabIndex = 10;
            label4.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(297, 337);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(429, 39);
            txtNewPassword.TabIndex = 11;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtRepassword
            // 
            txtRepassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepassword.Location = new Point(297, 439);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.Size = new Size(429, 39);
            txtRepassword.TabIndex = 12;
            txtRepassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 431);
            label5.Name = "label5";
            label5.Size = new Size(162, 46);
            label5.TabIndex = 13;
            label5.Text = "Nhập lại ";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(687, 548);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(221, 88);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(25, 548);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(221, 88);
            btnExit.TabIndex = 15;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(963, 667);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(txtRepassword);
            Controls.Add(txtNewPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtDisplayName);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "frmAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private TextBox txtDisplayName;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtNewPassword;
        private TextBox txtRepassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}