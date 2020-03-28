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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            LoadKhachHang();
        }
        void LoadKhachHang()
        {
            dtgvKhachHang.DataSource = KhachHangBLL.Instance.KhachHang_Select();
        }
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            
            KhachHangBLL.Instance.KhachHang_Insert(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtSTK.Text, txtMST.Text);
            LoadKhachHang();
            


        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            KhachHangBLL.Instance.KhachHang_Delete(txtMaKH.Text);
            LoadKhachHang();
        }

        private void btnEditKH_Click(object sender, EventArgs e)
        {
            KhachHangBLL.Instance.KhachHang_Update(txtMaKH.Text,txtTenKH.Text, txtDiaChi.Text, txtDiaChi.Text, txtSTK.Text, txtMST.Text);
            LoadKhachHang();

        }

        private void btnShowKH_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = KhachHangBLL.Instance.KhachHang_SearchByName(txtSearchKH.Text);
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dtgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtSTK.Text = row.Cells[4].Value.ToString();
                txtMST.Text = row.Cells[5].Value.ToString();
            }
            dtgvKhachHang.Rows[e.RowIndex].Selected = true;



        }
    }
}
