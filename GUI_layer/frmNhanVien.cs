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
    public partial class frmNhanVien : Form
    {

        public frmNhanVien()
        {
            InitializeComponent();
            LoadNV();
        }
        void LoadNV()
        {
            dtgvNhanVien.DataSource = NhanVienBLL.Instance.NhanVien_Select();
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnShowNhanVien_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            bool r = rdbtnNam.Checked  ? r = true : false;
            NhanVienBLL.Instance.NhanVien_Insert(txtTenNV.Text, dtpkBirthDay.Value, r, txtSDT.Text);
            LoadNV();
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienBLL.Instance.NhanVien_Delete(txtMaNV.Text);
            LoadNV();
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                dtpkBirthDay.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                bool r = Convert.ToBoolean(row.Cells[3].Value.ToString());
                if (r)
                    rdbtnNam.Checked = true;
                else rdbtnNu.Checked = true;
                txtSDT.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void btnEditNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienBLL.Instance.NhanVien_Update(txtMaNV.Text, txtTenNV.Text, dtpkBirthDay.Value, rdbtnNam.Checked ? true : false, txtSDT.Text);
            LoadNV();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = NhanVienBLL.Instance.NhanVien_SearchByName(txtSearchNV.Text);
        }
    }
}
