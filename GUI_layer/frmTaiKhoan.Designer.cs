namespace GUI_layer
{
    partial class frmTaiKhoan
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchTaikhoan = new System.Windows.Forms.TextBox();
            this.btnSearchTaiKhoan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowTaikhoan = new System.Windows.Forms.Button();
            this.btnDeleteTaiKhoan = new System.Windows.Forms.Button();
            this.btnEditTaiKhoan = new System.Windows.Forms.Button();
            this.btnAddTaiKhoan = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(423, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 362);
            this.panel6.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNhanVien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 53);
            this.panel1.TabIndex = 3;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(134, 11);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(147, 21);
            this.cmbNhanVien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhân Viên";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPassWord);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 46);
            this.panel8.TabIndex = 2;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(134, 9);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(147, 20);
            this.txtPassWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtUserName);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 46);
            this.panel7.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(130, 9);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(147, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchTaikhoan);
            this.panel5.Controls.Add(this.btnSearchTaiKhoan);
            this.panel5.Location = new System.Drawing.Point(423, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 63);
            this.panel5.TabIndex = 12;
            // 
            // txtSearchTaikhoan
            // 
            this.txtSearchTaikhoan.Location = new System.Drawing.Point(3, 22);
            this.txtSearchTaikhoan.Name = "txtSearchTaikhoan";
            this.txtSearchTaikhoan.Size = new System.Drawing.Size(208, 20);
            this.txtSearchTaikhoan.TabIndex = 5;
            // 
            // btnSearchTaiKhoan
            // 
            this.btnSearchTaiKhoan.Location = new System.Drawing.Point(229, 3);
            this.btnSearchTaiKhoan.Name = "btnSearchTaiKhoan";
            this.btnSearchTaiKhoan.Size = new System.Drawing.Size(74, 57);
            this.btnSearchTaiKhoan.TabIndex = 4;
            this.btnSearchTaiKhoan.Text = "Tìm ";
            this.btnSearchTaiKhoan.UseVisualStyleBackColor = true;
            this.btnSearchTaiKhoan.Click += new System.EventHandler(this.btnSearchTaiKhoan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvTaiKhoan);
            this.panel4.Location = new System.Drawing.Point(7, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 362);
            this.panel4.TabIndex = 13;
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.AllowUserToAddRows = false;
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(6, 3);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(401, 346);
            this.dtgvTaiKhoan.TabIndex = 0;
            this.dtgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTaiKhoan_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowTaikhoan);
            this.panel3.Controls.Add(this.btnDeleteTaiKhoan);
            this.panel3.Controls.Add(this.btnEditTaiKhoan);
            this.panel3.Controls.Add(this.btnAddTaiKhoan);
            this.panel3.Location = new System.Drawing.Point(7, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 63);
            this.panel3.TabIndex = 10;
            // 
            // btnShowTaikhoan
            // 
            this.btnShowTaikhoan.Location = new System.Drawing.Point(292, 3);
            this.btnShowTaikhoan.Name = "btnShowTaikhoan";
            this.btnShowTaikhoan.Size = new System.Drawing.Size(74, 57);
            this.btnShowTaikhoan.TabIndex = 3;
            this.btnShowTaikhoan.Text = "Xem";
            this.btnShowTaikhoan.UseVisualStyleBackColor = true;
            this.btnShowTaikhoan.Click += new System.EventHandler(this.btnShowTaikhoan_Click);
            // 
            // btnDeleteTaiKhoan
            // 
            this.btnDeleteTaiKhoan.Location = new System.Drawing.Point(101, 3);
            this.btnDeleteTaiKhoan.Name = "btnDeleteTaiKhoan";
            this.btnDeleteTaiKhoan.Size = new System.Drawing.Size(74, 57);
            this.btnDeleteTaiKhoan.TabIndex = 2;
            this.btnDeleteTaiKhoan.Text = "Xóa";
            this.btnDeleteTaiKhoan.UseVisualStyleBackColor = true;
            this.btnDeleteTaiKhoan.Click += new System.EventHandler(this.btnDeleteTaiKhoan_Click);
            // 
            // btnEditTaiKhoan
            // 
            this.btnEditTaiKhoan.Location = new System.Drawing.Point(194, 3);
            this.btnEditTaiKhoan.Name = "btnEditTaiKhoan";
            this.btnEditTaiKhoan.Size = new System.Drawing.Size(74, 57);
            this.btnEditTaiKhoan.TabIndex = 1;
            this.btnEditTaiKhoan.Text = "Sửa";
            this.btnEditTaiKhoan.UseVisualStyleBackColor = true;
            this.btnEditTaiKhoan.Click += new System.EventHandler(this.btnEditTaiKhoan_Click);
            // 
            // btnAddTaiKhoan
            // 
            this.btnAddTaiKhoan.Location = new System.Drawing.Point(6, 3);
            this.btnAddTaiKhoan.Name = "btnAddTaiKhoan";
            this.btnAddTaiKhoan.Size = new System.Drawing.Size(74, 57);
            this.btnAddTaiKhoan.TabIndex = 0;
            this.btnAddTaiKhoan.Text = "Thêm";
            this.btnAddTaiKhoan.UseVisualStyleBackColor = true;
            this.btnAddTaiKhoan.Click += new System.EventHandler(this.btnAddTaiKhoan_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 495);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchTaikhoan;
        private System.Windows.Forms.Button btnSearchTaiKhoan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowTaikhoan;
        private System.Windows.Forms.Button btnDeleteTaiKhoan;
        private System.Windows.Forms.Button btnEditTaiKhoan;
        private System.Windows.Forms.Button btnAddTaiKhoan;
        private System.Windows.Forms.TextBox txtUserName;
    }
}