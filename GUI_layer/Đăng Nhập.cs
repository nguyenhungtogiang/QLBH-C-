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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            CTHD_BLL CTHD = new CTHD_BLL();
            HangHoaBLL HH = new HangHoaBLL();
            HoaDonBLL HD = new HoaDonBLL();
            KhachHangBLL KH = new KhachHangBLL();
            LoaiHangBLL LH = new LoaiHangBLL();
            NhanVienBLL NV = new NhanVienBLL();
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL TK = new TaiKhoanBLL();
            if (txtusername.Text != "" && txtpass.Text != "")
            {
              
                int DT = TK.TaiKhoan_Login(txtusername.Text, txtpass.Text);
                if (DT != 0)
                {
                    Quản_lý_bán_hàng_cừa_hàng_Cao_Minh frm = new Quản_lý_bán_hàng_cừa_hàng_Cao_Minh();
                    this.Hide();
                    frm.Show();

                }
                else if (DT == 0)
                {
                    MessageBox.Show("Taif khoanr khong ton tai");
                }
            }
            else if (txtusername.Text == "")
                MessageBox.Show("Tên đăng nhập không được để trống");
            else
                MessageBox.Show("Mật khẩu không được để trống");

            if (TaiKhoanBLL.Instance.TaiKhoan_Login(txtusername.Text, txtpass.Text) > 0)
            {
                Quản_lý_bán_hàng_cừa_hàng_Cao_Minh frm = new Quản_lý_bán_hàng_cừa_hàng_Cao_Minh();
                this.Hide();
                frm.Show();
            }
        }
    }
}
