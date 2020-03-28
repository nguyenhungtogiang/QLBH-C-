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
    public partial class frmLoaiHang : Form
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }
        void LoadLoaiHang()
        {
            dtgvLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_Select();
        }

        private void btnAddLH_Click(object sender, EventArgs e)
        {
            LoaiHangBLL.Instance.LoaiHang_Insert(txtTenLH.Text, txtGhiChu.Text);
            LoadLoaiHang();
        }

        private void dtgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvLoaiHang.Rows[e.RowIndex];
                txtMaLH.Text = row.Cells[0].Value.ToString();
                txtTenLH.Text = row.Cells[1].Value.ToString();
                txtGhiChu.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnEditLH_Click(object sender, EventArgs e)
        {
            LoaiHangBLL.Instance.LoaiHang_Update(txtMaLH.Text, txtTenLH.Text, txtGhiChu.Text);
            LoadLoaiHang();
        }

        private void btnDeleteLH_Click(object sender, EventArgs e)
        {
            LoaiHangBLL.Instance.LoaiHang_Delete(txtMaLH.Text);
            LoadLoaiHang();
        }

        private void btnShowLH_Click(object sender, EventArgs e)
        {
            LoadLoaiHang();
        }

        private void btnSearchLH_Click(object sender, EventArgs e)
        {
            dtgvLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_SearchByName(txtSearchLH.Text);
        }
    }
}
