using BLL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_layer
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        void LoadTaiKhoan()
        {
            dtgvTaiKhoan.DataSource = TaiKhoanBLL.Instance.TaiKhoan_Select();
        }
        void LoadNhanVien()
        {
            cmbNhanVien.DataSource = NhanVienBLL.Instance.NhanVien_Select();
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btnShowTaikhoan_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btnAddTaiKhoan_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBLL.Instance.TaiKhoan_Insert(txtUserName.Text, txtPassWord.Text, cmbNhanVien.SelectedValue.ToString()) > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvTaiKhoan.Rows[e.RowIndex];
                txtUserName.Text = row.Cells[0].Value.ToString();
                cmbNhanVien.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnDeleteTaiKhoan_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBLL.Instance.Taikhoan_Delete(txtUserName.Text) > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnEditTaiKhoan_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBLL.Instance.TaiKhoan_Update(txtUserName.Text, txtPassWord.Text, cmbNhanVien.SelectedValue.ToString()) > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btnSearchTaiKhoan_Click(object sender, EventArgs e)
        {
            dtgvTaiKhoan.DataSource = TaiKhoanBLL.Instance.TaiKhoan_SearchByTenTK(txtSearchTaikhoan.Text);
        }
    }
}
