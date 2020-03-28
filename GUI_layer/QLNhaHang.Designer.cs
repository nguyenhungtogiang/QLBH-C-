namespace GUI_layer
{
    partial class QLNhaHang
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
            this.lsvCTHD = new System.Windows.Forms.ListView();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.nmrSL = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmrSL)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvCTHD
            // 
            this.lsvCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9});
            this.lsvCTHD.Location = new System.Drawing.Point(12, 43);
            this.lsvCTHD.Name = "lsvCTHD";
            this.lsvCTHD.Size = new System.Drawing.Size(424, 159);
            this.lsvCTHD.TabIndex = 18;
            this.lsvCTHD.UseCompatibleStateImageBehavior = false;
            this.lsvCTHD.View = System.Windows.Forms.View.Details;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lsvHoaDon.Location = new System.Drawing.Point(21, 247);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(415, 186);
            this.lsvHoaDon.TabIndex = 17;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Loại hàng";
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(137, 16);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiHang.TabIndex = 15;
            this.cmbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHang_SelectedIndexChanged);
            // 
            // nmrSL
            // 
            this.nmrSL.Location = new System.Drawing.Point(201, 218);
            this.nmrSL.Name = "nmrSL";
            this.nmrSL.Size = new System.Drawing.Size(57, 20);
            this.nmrSL.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "V";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hàng";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Hàng";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DVT";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số lượng còn";
            this.columnHeader9.Width = 78;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mã Hàng";
            this.columnHeader12.Width = 84;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tên Hàng";
            this.columnHeader13.Width = 101;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Số lượng";
            this.columnHeader14.Width = 145;
            // 
            // QLNhaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.lsvCTHD);
            this.Controls.Add(this.lsvHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLoaiHang);
            this.Controls.Add(this.nmrSL);
            this.Controls.Add(this.button1);
            this.Name = "QLNhaHang";
            this.Text = "QLNhaHang";
            this.Load += new System.EventHandler(this.QLNhaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvCTHD;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.NumericUpDown nmrSL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}