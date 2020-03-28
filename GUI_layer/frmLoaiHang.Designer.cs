namespace GUI_layer
{
    partial class frmLoaiHang
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchLH = new System.Windows.Forms.TextBox();
            this.btnSearchLH = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowLH = new System.Windows.Forms.Button();
            this.btnDeleteLH = new System.Windows.Forms.Button();
            this.btnEditLH = new System.Windows.Forms.Button();
            this.btnAddLH = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(682, 122);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 557);
            this.panel6.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(4, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 82);
            this.panel1.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(201, 14);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(218, 26);
            this.txtGhiChu.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi Chú";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTenLH);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(4, 102);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(426, 71);
            this.panel8.TabIndex = 2;
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(201, 14);
            this.txtTenLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(218, 26);
            this.txtTenLH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Hàng";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMaLH);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(4, 22);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(426, 71);
            this.panel7.TabIndex = 1;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(201, 14);
            this.txtMaLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.ReadOnly = true;
            this.txtMaLH.Size = new System.Drawing.Size(218, 26);
            this.txtMaLH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Hàng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchLH);
            this.panel5.Controls.Add(this.btnSearchLH);
            this.panel5.Location = new System.Drawing.Point(682, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 97);
            this.panel5.TabIndex = 8;
            // 
            // txtSearchLH
            // 
            this.txtSearchLH.Location = new System.Drawing.Point(4, 34);
            this.txtSearchLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchLH.Name = "txtSearchLH";
            this.txtSearchLH.Size = new System.Drawing.Size(310, 26);
            this.txtSearchLH.TabIndex = 5;
            // 
            // btnSearchLH
            // 
            this.btnSearchLH.Location = new System.Drawing.Point(344, 5);
            this.btnSearchLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchLH.Name = "btnSearchLH";
            this.btnSearchLH.Size = new System.Drawing.Size(111, 88);
            this.btnSearchLH.TabIndex = 4;
            this.btnSearchLH.Text = "Tìm ";
            this.btnSearchLH.UseVisualStyleBackColor = true;
            this.btnSearchLH.Click += new System.EventHandler(this.btnSearchLH_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvLoaiHang);
            this.panel4.Location = new System.Drawing.Point(58, 122);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 557);
            this.panel4.TabIndex = 9;
            // 
            // dtgvLoaiHang
            // 
            this.dtgvLoaiHang.AllowUserToAddRows = false;
            this.dtgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiHang.Location = new System.Drawing.Point(9, 5);
            this.dtgvLoaiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvLoaiHang.Name = "dtgvLoaiHang";
            this.dtgvLoaiHang.Size = new System.Drawing.Size(602, 532);
            this.dtgvLoaiHang.TabIndex = 0;
            this.dtgvLoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiHang_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowLH);
            this.panel3.Controls.Add(this.btnDeleteLH);
            this.panel3.Controls.Add(this.btnEditLH);
            this.panel3.Controls.Add(this.btnAddLH);
            this.panel3.Location = new System.Drawing.Point(58, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 97);
            this.panel3.TabIndex = 6;
            // 
            // btnShowLH
            // 
            this.btnShowLH.Location = new System.Drawing.Point(438, 5);
            this.btnShowLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowLH.Name = "btnShowLH";
            this.btnShowLH.Size = new System.Drawing.Size(111, 88);
            this.btnShowLH.TabIndex = 3;
            this.btnShowLH.Text = "Xem";
            this.btnShowLH.UseVisualStyleBackColor = true;
            this.btnShowLH.Click += new System.EventHandler(this.btnShowLH_Click);
            // 
            // btnDeleteLH
            // 
            this.btnDeleteLH.Location = new System.Drawing.Point(152, 5);
            this.btnDeleteLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteLH.Name = "btnDeleteLH";
            this.btnDeleteLH.Size = new System.Drawing.Size(111, 88);
            this.btnDeleteLH.TabIndex = 2;
            this.btnDeleteLH.Text = "Xóa";
            this.btnDeleteLH.UseVisualStyleBackColor = true;
            this.btnDeleteLH.Click += new System.EventHandler(this.btnDeleteLH_Click);
            // 
            // btnEditLH
            // 
            this.btnEditLH.Location = new System.Drawing.Point(291, 5);
            this.btnEditLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditLH.Name = "btnEditLH";
            this.btnEditLH.Size = new System.Drawing.Size(111, 88);
            this.btnEditLH.TabIndex = 1;
            this.btnEditLH.Text = "Sửa";
            this.btnEditLH.UseVisualStyleBackColor = true;
            this.btnEditLH.Click += new System.EventHandler(this.btnEditLH_Click);
            // 
            // btnAddLH
            // 
            this.btnAddLH.Location = new System.Drawing.Point(9, 5);
            this.btnAddLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddLH.Name = "btnAddLH";
            this.btnAddLH.Size = new System.Drawing.Size(111, 88);
            this.btnAddLH.TabIndex = 0;
            this.btnAddLH.Text = "Thêm";
            this.btnAddLH.UseVisualStyleBackColor = true;
            this.btnAddLH.Click += new System.EventHandler(this.btnAddLH_Click);
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLoaiHang";
            this.Text = "QLLoaiHang";
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchLH;
        private System.Windows.Forms.Button btnSearchLH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvLoaiHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowLH;
        private System.Windows.Forms.Button btnDeleteLH;
        private System.Windows.Forms.Button btnEditLH;
        private System.Windows.Forms.Button btnAddLH;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}