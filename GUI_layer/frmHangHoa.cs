
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
    public partial class frmHangHoa : Form
    {

        DataTable dt;
        
        public frmHangHoa()
        {
            InitializeComponent();
        }

        void LoadLoaiHangg()
        {
            cbLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_Select();
            cbLoaiHang.DisplayMember = "TenLoaiHang";
            cbLoaiHang.ValueMember = "MaLoaiHang";

        }
        void LoadListHangHoa()
        {
            dtgvHangHoa.DataSource = HangHoaBLL.Instance.HangHoa_Select();
             
        }
        private void QLHangHoa_Load(object sender, EventArgs e)
        {
            LoadListHangHoa();
            
        }

        private void dtgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadLoaiHangg();
            if(e.RowIndex > 0) { 
            DataGridViewRow row = dtgvHangHoa.Rows[e.RowIndex];
            txtMaHH.Text = row.Cells[0].Value.ToString();
            txtTenHH.Text = row.Cells[1].Value.ToString();
            txtDVT.Text = row.Cells[2].Value.ToString();
            txtDonGia.Text = row.Cells[3].Value.ToString();
            txtSLCon.Text = row.Cells[4].Value.ToString();
            cbLoaiHang.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnAddHH_Click(object sender, EventArgs e)
        {
            HangHoaBLL.Instance.HangHoa_Insert(txtTenHH.Text, txtDVT.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtSLCon.Text), cbLoaiHang.SelectedValue.ToString());
            LoadListHangHoa();
        }

        private void btnDeleteHH_Click(object sender, EventArgs e)
        {
            HangHoaBLL.Instance.HangHoa_Delete(txtMaHH.Text);
            LoadListHangHoa();
        }

        private void btnEditHH_Click(object sender, EventArgs e)
        {
            HangHoaBLL.Instance.HangHoa_Update(txtMaHH.Text, txtTenHH.Text, txtDVT.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtSLCon.Text), cbLoaiHang.SelectedValue.ToString());
            LoadListHangHoa();
        }

        private void btnSearchHH_Click(object sender, EventArgs e)
        {
            
            dtgvHangHoa.DataSource = HangHoaBLL.Instance.HangHoa_SearchByName(txtSearchHH.Text);
            
        }

        private void btnShowHH_Click(object sender, EventArgs e)
        {
            LoadListHangHoa();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
