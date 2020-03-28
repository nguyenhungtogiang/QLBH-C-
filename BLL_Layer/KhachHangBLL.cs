using DAL_Layer2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Layer
{
    public class KhachHangBLL
    {
        KhachHangDAL khDAL = new KhachHangDAL();
        private static KhachHangBLL instance;
        public static KhachHangBLL Instance
        {
            get { if (instance == null) instance = new KhachHangBLL(); return KhachHangBLL.instance; }
            set { instance = value; }
        }

        public DataTable KhachHang_Select()
        {
            return khDAL.KhachHang_Select();
        }
        public DataTable KhachHang_SelectByMa(string maLH)
        {
            return khDAL.KhachHang_SelectByMa(maLH);
        }
        public DataTable KhachHang_SearchByName(string tenKH)
        {
            return khDAL.KhachHang_SearchByName(tenKH);
        }
        public int KhachHang_Insert(string tenKH, string diaChi, string sdt, string STK, string MST)
        {
            return khDAL.KhachHang_Insert(tenKH, diaChi, sdt, STK, MST);
        }
        public int KhachHang_Delete(string maKH)
        {
            return khDAL.KhachHang_Delete(maKH);
        }
        public int KhachHang_Update(string maKH, string tenKH, string diaChi, string sdt, string STK, string MST)
        {
            return khDAL.KhachHang_Update(maKH, tenKH, diaChi, sdt,STK,MST);
        }
    }
}
