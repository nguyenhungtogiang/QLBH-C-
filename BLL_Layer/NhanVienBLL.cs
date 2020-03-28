using DAL_Layer2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Layer
{
    public class NhanVienBLL
    {
        NhanVienDAL nvDAL = new NhanVienDAL();
        private static NhanVienBLL instance;
        public static NhanVienBLL Instance
        {
            get { if (instance == null) instance = new NhanVienBLL(); return NhanVienBLL.instance; }
            set { instance = value; }
        }

        public DataTable NhanVien_Select()
        {
            return nvDAL.NhanVien_Select();
        }
        public DataTable NhanVien_SelectByMa(string maLH)
        {
            return nvDAL.NhanVien_SelectByMa(maLH);
        }
        public DataTable NhanVien_SearchByName(string tenNV)
        {
            return nvDAL.NhanVien_SearchByName(tenNV);
        }
        public int NhanVien_Insert(string tenNV, DateTime ngaySinh, bool gioiTinh, string sdt)
        {
            return nvDAL.NhanVien_Insert(tenNV, ngaySinh, gioiTinh, sdt);
        }
        public int NhanVien_Delete(string maLH)
        {
            return nvDAL.NhanVien_Delete(maLH);
        }
        public int NhanVien_Update(string maNV, string tenNV, DateTime ngaySinh, bool gioiTinh, string sdt)
        {
            return nvDAL.NhanVien_Update(maNV, tenNV, ngaySinh, gioiTinh, sdt);
        }
    }
}
