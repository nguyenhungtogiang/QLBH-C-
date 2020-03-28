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
    public partial class frmCTHD : Form
    {
        DataTable dt;
        public frmCTHD()
        {
            InitializeComponent();
            LoadHoaDon();
            dtpkHoaDon.Value = DateTime.Now;
            LoadLoaiHang();
        }

        private void dtgv1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txtDVT.Text = row2.Cells[3].Value.ToString();
                txtDonGia.Text = row2.Cells[4].Value.ToString();
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
                    Convert.ToInt32(dtgv2.Rows[row.Index].Cells[3].Value) *
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
        void LoadLoaiHang()
        {
            cmbLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_Select();
            cmbLoaiHang.DisplayMember = "TenLoaiHang";
            cmbLoaiHang.ValueMember = "MaLoaiHang";
        }
        void LoadHoaDon()
        {
            dtgv1.DataSource = HoaDonBLL.Instance.HoaDon_Select();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTenHang.DataSource = HangHoaBLL.Instance.HangHoa_SelectByMaLH(cmbLoaiHang.SelectedValue.ToString());
            cmbTenHang.DisplayMember = "TenHang";
            cmbTenHang.ValueMember = "MaHang";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = HangHoaBLL.Instance.HangHoa_SelectByMa(cmbTenHang.SelectedValue.ToString());
            txtDVT.Text = dt.Rows[0]["DVT"].ToString();
            txtDonGia.Text = dt.Rows[0]["DonGia"].ToString();
            txtMaHang.Text = cmbTenHang.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = HangHoaBLL.Instance.HangHoa_SelectByMa(txtMaHang.Text);
            int SLCon = int.Parse(dt.Rows[0]["SLcon"].ToString());
            if (dtgv2.RowCount == 0)
            {
                if (nmrSL.Value <= 0 || nmrSL.Value>SLCon)
                {
                    if (nmrSL.Value <= 0)
                        MessageBox.Show("Số lượng nhập phải lớn hơn 0.");
                    else MessageBox.Show("Vượt quá số lượng còn: " + SLCon);
                    return;
                }
                dtgv2.Rows.Add(txtMaHang.Text, cmbTenHang.Text, nmrSL.Value, txtDVT.Text, txtDonGia.Text, cmbLoaiHang.Text);
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
                            if(SL > SLCon)
                            {
                                MessageBox.Show("Vượt quá số lượng còn: "+SLCon);
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
            dtgv2.Rows.Add(txtMaHang.Text, cmbTenHang.Text, nmrSL.Value, txtDVT.Text, txtDonGia.Text, cmbLoaiHang.Text);
            TinhTongTien();


        }

        private void dtgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv2.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells[0].Value.ToString();               
                cmbTenHang.Text = row.Cells[1].Value.ToString();
                nmrSL.Value = Convert.ToInt32(row.Cells[2].Value.ToString());
                txtDVT.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[4].Value.ToString();
                cmbLoaiHang.Text = row.Cells[5].Value.ToString();
            }
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
            txtDVT.Text = "";
            txtDonGia.Text = "";
            dtgv2.Rows.Clear();
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
                    MessageBox.Show("Them thanh cong");
                }
                else
                    MessageBox.Show("Them that bai");

                LoadHoaDon();
                //foreach (DataGridViewRow row in dtgv1.Rows)
                //{
                //    if (row.Cells[0].Value.ToString().Trim().Equals(txtMaHD.Text.ToString().Trim()))
                //    {
                //        dtgv1.Rows[row.Index].Selected = true;
                //        return;
                //    }
                //}
            }
            else
            {
                MessageBox.Show("Chọn Khách Hàng và Nhân Viên để thêm");
            }

        }

        private void btnEditHoaDon_Click(object sender, EventArgs e)
        {
            if(HoaDonBLL.Instance.HoaDon_Delete(txtMaHD.Text) > 0)
            {
                HoaDonBLL.Instance.HoaDon_InsertByMa(txtMaHD.Text, cmbKhachHang.SelectedValue.ToString(), cmbNhanVien.SelectedValue.ToString());
                foreach (DataGridViewRow row in dtgv2.Rows)
                {
                    CTHD_BLL.Instance.CTHD_Insert(txtMaHD.Text, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                }
                MessageBox.Show("Sua thanh cong");
            }
            else MessageBox.Show("Sua that bai");
            LoadHoaDon();
        }

        private void btnDeleteHoaDon_Click(object sender, EventArgs e)
        {
            if (HoaDonBLL.Instance.HoaDon_Delete(txtMaHD.Text) > 0)
            {
                MessageBox.Show("Xoa thanh cong");
            }
            else
                MessageBox.Show("Xoa that bai");
            LoadHoaDon();
        }

        private void CTHD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //frmKhachHang frm = new frmKhachHang();
            //frm.Show();
            //frm.
        }

        private void dtgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void nmrSL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
