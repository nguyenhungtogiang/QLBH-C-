using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Layer;
using System.Data.SqlClient;

namespace GUI_layer
{
    public partial class Quản_lý_bán_hàng_cừa_hàng_Cao_Minh : Form
    {
        SqlConnection con;
        private void KetNoiCSDL()
        {
            con = new SqlConnection("Data Source=HUNGTO-PC;Initial Catalog=QLBH;Integrated Security=True");
            con.Open();
        }
        private void NgatKetNoi()
        {
            con.Close();
            con.Dispose();
        }
        DataTable dt;
        public Quản_lý_bán_hàng_cừa_hàng_Cao_Minh()
            
        {
            InitializeComponent();
            LoadHoaDon();
            dtpkHoaDon.Value = DateTime.Now;
            LoadLoaiHang();
            LoadKhachHangg();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }
        void LoadListHangHoa()
        {
            dtgvHangHoa.DataSource = HangHoaBLL.Instance.HangHoa_Select();

        }
        void LoadHoaDon()
        {
            dtgv1.DataSource = HoaDonBLL.Instance.HoaDon_Select();
        }
        void LoadLoaiHang()
        {
            cmbLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_Select();
            cmbLoaiHang.DisplayMember = "TenLoaiHang";
            cmbLoaiHang.ValueMember = "MaLoaiHang";
        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadKhachHang();
            LoadNhanVien();
            Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv1.Rows[e.RowIndex];

                txtMaHD.Text = row.Cells[0].Value.ToString();
                dtpkHoaDon.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
                cmbKhachHang.Text = row.Cells[2].Value.ToString();
                cmbNhanVien.Text = row.Cells[3].Value.ToString();
            }

            dt = CTHD_BLL.Instance.CTHD_SelectByMaHD(txtMaHD.Text);
            foreach (DataRow dr in dt.Rows)
            {

                dtgv2.Rows.Add(dr.ItemArray);

            }

            if (dtgv2.Rows.Count > 0)
            {
                DataGridViewRow row2 = dtgv2.Rows[0];
                txtMaHang.Text = row2.Cells[0].Value.ToString();
                cmbTenHang.Text = row2.Cells[1].Value.ToString();
                nmrSL.Value = Convert.ToInt32(row2.Cells[2].Value.ToString());
                txtDVT2.Text = row2.Cells[3].Value.ToString();
                txtDonGia2.Text = row2.Cells[4].Value.ToString();
                cmbLoaiHang.Text = row2.Cells[5].Value.ToString();
                TinhTongTien();
            }

            //set button
            btnEditHoaDon.Enabled = true;
            btnDeleteHoaDon.Enabled = true;
            btnAddHoaDon.Enabled = false;
        }
        void TinhTongTien()
        {
            //Tinh tong tien
            txtTongTien.Text = "";
            double tongTien = 0;
            foreach (DataGridViewRow row in dtgv2.Rows)
            {
                tongTien += Convert.ToInt32(dtgv2.Rows[row.Index].Cells[2].Value) *
                    //Convert.ToInt32(dtgv2.Rows[row.Index].Cells[3].Value) *
                    Convert.ToInt32(dtgv2.Rows[row.Index].Cells[4].Value);
            }
            txtTongTien.Text = tongTien.ToString();
        }
        void LoadKhachHang()
        {
            cmbKhachHang.DataSource = KhachHangBLL.Instance.KhachHang_Select();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
        }
        void LoadNhanVien()
        {
            cmbNhanVien.DataSource = NhanVienBLL.Instance.NhanVien_Select();
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
        }
        void Clear()
        {
            txtMaHD.Text = "";
            dtpkHoaDon.Value = DateTime.Now;
            cmbKhachHang.Text = "";
            cmbNhanVien.Text = "";
            cmbLoaiHang.Text = "";
            cmbTenHang.Text = "";
            nmrSL.Value = 0;
            txtDVT2.Text = "";
            txtDonGia2.Text = "";
            dtgv2.Rows.Clear();
        }

        private void dtgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv2.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells[0].Value.ToString();
                cmbTenHang.Text = row.Cells[1].Value.ToString();
                nmrSL.Value = Convert.ToInt32(row.Cells[2].Value.ToString());
                txtDVT2.Text = row.Cells[3].Value.ToString();
                txtDonGia2.Text = row.Cells[4].Value.ToString();
                cmbLoaiHang.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnAddHoaDon.Enabled = true;
            btnEditHoaDon.Enabled = false;
            btnDeleteHoaDon.Enabled = false;
            Clear();
            dt = HoaDonBLL.Instance.HoaDon_SelectNewID();
            txtMaHD.Text = dt.Rows[0][0].ToString();
            LoadKhachHang();
            LoadNhanVien();
        }

        private void btnAddHoaDon_Click(object sender, EventArgs e)
        {
            if (cmbKhachHang.Text != "" && cmbNhanVien.Text != "")
            {

                if (HoaDonBLL.Instance.HoaDon_Insert(cmbKhachHang.SelectedValue.ToString(), cmbNhanVien.SelectedValue.ToString()) > 0)
                {
                    foreach (DataGridViewRow row in dtgv2.Rows)
                    {
                        CTHD_BLL.Instance.CTHD_Insert(txtMaHD.Text, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                    }
                    MessageBox.Show("Thêm hóa đơn thành công");
                }
                else
                    MessageBox.Show("Thêm hóa đơn thất bại");

                LoadHoaDon();
            }

            else
            {
                MessageBox.Show("Chọn Khách Hàng và Nhân Viên để thêm");
            }
        }

        private void btnEditHoaDon_Click(object sender, EventArgs e)
        {
            if (HoaDonBLL.Instance.HoaDon_Delete(txtMaHD.Text) > 0)
            {
                HoaDonBLL.Instance.HoaDon_InsertByMa(txtMaHD.Text, cmbKhachHang.SelectedValue.ToString(), cmbNhanVien.SelectedValue.ToString());
                foreach (DataGridViewRow row in dtgv2.Rows)
                {
                    CTHD_BLL.Instance.CTHD_Insert(txtMaHD.Text, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                }
                MessageBox.Show("Sửa hóa đơn thành công");
            }
            else MessageBox.Show("Sửa hóa đơn thất bại");
            LoadHoaDon();
        }

        private void btnDeleteHoaDon_Click(object sender, EventArgs e)
        {
            if (HoaDonBLL.Instance.HoaDon_Delete(txtMaHD.Text) > 0)
            {
                MessageBox.Show("Xóa hóa đơn thành công");
            }
            else
                MessageBox.Show("Xóa hóa đơn thất bại");
            LoadHoaDon();
        }

        private void btnAddCTHD_Click(object sender, EventArgs e)
        {
            dt = HangHoaBLL.Instance.HangHoa_SelectByMa(txtMaHang.Text);
            int SLCon = int.Parse(dt.Rows[0]["SLcon"].ToString());
            if (dtgv2.RowCount == 0)
            {
                if (nmrSL.Value <= 0 || nmrSL.Value > SLCon)
                {
                    if (nmrSL.Value <= 0)
                        MessageBox.Show("Số lượng nhập phải lớn hơn 0.");
                    else MessageBox.Show("Vượt quá số lượng còn: " + SLCon);
                    return;
                }
                dtgv2.Rows.Add(txtMaHang.Text, cmbTenHang.Text, nmrSL.Value, txtDVT2.Text, txtDonGia2.Text, cmbLoaiHang.Text);
                TinhTongTien();
                return;
            }
            else
                foreach (DataGridViewRow row in dtgv2.Rows)
                {
                    if (txtMaHang.Text == row.Cells[0].Value.ToString())
                    {
                        //SL moi + SL cu > 0
                        int SL = Convert.ToInt32(row.Cells[2].Value) + (int)nmrSL.Value;
                        if (SL > 0)
                        {
                            if (SL > SLCon)
                            {
                                MessageBox.Show("Vượt quá số lượng còn: " + SLCon);
                            }
                            else
                            {
                                row.Cells[2].Value = (Convert.ToInt32(row.Cells[2].Value) + nmrSL.Value).ToString();

                            }
                            TinhTongTien();
                            return;
                        }
                        else //SLmoi + SL cu <= 0, Xoa hang trong datagridview
                        {
                            dtgv2.Rows.RemoveAt(row.Index);
                            TinhTongTien();
                        }
                    }
                }
            if (nmrSL.Value <= 0)
                return;
            dtgv2.Rows.Add(txtMaHang.Text, cmbTenHang.Text, nmrSL.Value, txtDVT2.Text, txtDonGia2.Text, cmbLoaiHang.Text);
            TinhTongTien();
        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTenHang.DataSource = HangHoaBLL.Instance.HangHoa_SelectByMaLH(cmbLoaiHang.SelectedValue.ToString());
            cmbTenHang.DisplayMember = "TenHang";
            cmbTenHang.ValueMember = "MaHang";
        }

        private void cmbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = HangHoaBLL.Instance.HangHoa_SelectByMa(cmbTenHang.SelectedValue.ToString());
            txtDVT2.Text = dt.Rows[0]["DVT"].ToString();
            txtDonGia2.Text = dt.Rows[0]["DonGia"].ToString();
            txtMaHang.Text = cmbTenHang.SelectedValue.ToString();
        }
        //hàng hóa
        private void QLHangHoa_Load(object sender, EventArgs e)
        {
            LoadListHangHoa();

        }

        private void dtgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadLoaiHang1();
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dtgvHangHoa.Rows[e.RowIndex];
                txtMaHH.Text = row.Cells[0].Value.ToString();
                txtTenHH.Text = row.Cells[1].Value.ToString();
                txtDVT.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtSLCon.Text = row.Cells[4].Value.ToString();
                cbLhang.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnAddHH_Click(object sender, EventArgs e)
        {
            HangHoaBLL.Instance.HangHoa_Insert(txtTenHH.Text, txtDVT.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtSLCon.Text), cbLhang.SelectedValue.ToString());
            LoadListHangHoa();
        }

        private void btnDeleteHH_Click(object sender, EventArgs e)
        {
            HangHoaBLL.Instance.HangHoa_Delete(txtMaHH.Text);
            LoadListHangHoa();
        }

        private void btnEditHH_Click(object sender, EventArgs e)
        {
            HangHoaBLL.Instance.HangHoa_Update(txtMaHH.Text, txtTenHH.Text, txtDVT.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtSLCon.Text), cbLhang.SelectedValue.ToString());
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

        private void txtsoluongcon_TextChanged(object sender, EventArgs e)
        {

        }
        // lọai hàng hóa
        void LoadLoaiHang1()
        {
            cbLhang.DataSource = LoaiHangBLL.Instance.LoaiHang_Select();
            cbLhang.DisplayMember = "TenLoaiHang";
            cbLhang.ValueMember = "MaLoaiHang";

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        void LoadLoaiHangg()
        {
            dtgvLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_Select();
        }

        private void btnAddLH_Click(object sender, EventArgs e)
        {
            LoaiHangBLL.Instance.LoaiHang_Insert(txtTenLH.Text, txtGhiChu.Text);
            LoadLoaiHangg();
        }

        private void dtgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
            LoadLoaiHangg();
        }

        private void btnDeleteLH_Click(object sender, EventArgs e)
        {
            LoaiHangBLL.Instance.LoaiHang_Delete(txtMaLH.Text);
            LoadLoaiHangg();
        }

        private void btnShowLH_Click(object sender, EventArgs e)
        {
            LoadLoaiHangg();
        }

        private void btnSearchLH_Click(object sender, EventArgs e)
        {
            dtgvLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_SearchByName(txtSearchLH.Text);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        void LoadNV()
        {
            dtgvNhanVien.DataSource = NhanVienBLL.Instance.NhanVien_Select();
        }

        private void btnShowNhanVien_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            bool r = rdbtnNam.Checked ? r = true : false;
            NhanVienBLL.Instance.NhanVien_Insert(txtTenNV.Text, dtpkBirthDay.Value, r, txtSDT.Text);
            LoadNV();
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienBLL.Instance.NhanVien_Delete(txtMaNV.Text);
            LoadNV();
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        void LoadKhachHangg()
        {
            dtgvKhachHang.DataSource = KhachHangBLL.Instance.KhachHang_Select();
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            KhachHangBLL.Instance.KhachHang_Insert(txtTenKH.Text, txtDiaChi.Text, txtSDTT.Text, txtSTK.Text, txtMST.Text);
            LoadKhachHangg();
        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            KhachHangBLL.Instance.KhachHang_Delete(txtMaKH.Text);
            LoadKhachHangg();
        }

        private void btnEditKH_Click(object sender, EventArgs e)
        {
            KhachHangBLL.Instance.KhachHang_Update(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDTT.Text, txtSTK.Text, txtMST.Text);
            LoadKhachHangg();
        }

        private void btnShowKH_Click(object sender, EventArgs e)
        {
            LoadKhachHangg();
        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            dtgvKhachHang.DataSource = KhachHangBLL.Instance.KhachHang_SearchByName(txtSearchKH.Text);
        }

        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDTT.Text = row.Cells[3].Value.ToString();
                txtSTK.Text = row.Cells[4].Value.ToString();
                txtMST.Text = row.Cells[5].Value.ToString();
            }
            dtgvKhachHang.Rows[e.RowIndex].Selected = true;
        }

        private void cbLhang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpkHoaDon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            KetNoiCSDL();
            SqlCommand command = new SqlCommand('Select_inhoadon', con);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Select_inhoadon";

        }
    }
}

