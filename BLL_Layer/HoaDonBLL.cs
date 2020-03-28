using DAL_Layer2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Layer
{
    public class HoaDonBLL
    {
        HoaDonDAL hdDAL = new HoaDonDAL();
        private static HoaDonBLL instance;
        public static HoaDonBLL Instance
        {
            get { if (instance == null) instance = new HoaDonBLL(); return HoaDonBLL.instance; }
            set { instance = value; }
        }

        public DataTable HoaDon_Select()
        {
            return hdDAL.HoaDon_Select();
        }
        public DataTable HoaDon_SelectByMa(string maLH)
        {
            return hdDAL.HoaDon_SelectByMa(maLH);
        }
        public DataTable HoaDon_SelectNewID()
        {
            return hdDAL.HoaDon_SelectNewID();
        }
        public int HoaDon_Insert(string maKH, string maNV)
        {
            return hdDAL.HoaDon_Insert(maKH, maNV);
        }
        public int HoaDon_InsertByMa(string maHD, string maKH, string maNV)
        {
            return hdDAL.HoaDon_InsertByMa(maHD, maKH, maNV);
        }
        public int HoaDon_Update(string maHD, string maKH, string maNV)
        {
            return hdDAL.HoaDon_Update(maHD, maKH, maNV);
        }
        public int HoaDon_Delete(string maHD)
        {
            return hdDAL.HoaDon_Delete(maHD);
        }
    }



}
