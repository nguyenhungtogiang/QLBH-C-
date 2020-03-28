using DAL_Layer2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Layer
{
    public class HangHoaBLL
    {
        private static HangHoaBLL instance;
        public static HangHoaBLL Instance
        {
            get { if (instance == null) instance = new HangHoaBLL(); return HangHoaBLL.instance; }
            set { HangHoaBLL.instance = value; }
        }
        HangHoaDAL hhDAL = new HangHoaDAL();
        public DataTable HangHoa_Select()
        {
            return hhDAL.HangHoa_Select();
        }
        public DataTable HangHoa_SelectByMa(string maHH)
        {
            return hhDAL.HangHoa_SelectByMa(maHH);
        }
        public DataTable HangHoa_SelectByMaLH(string maLH)
        {
            return hhDAL.HangHoa_SelectByMaLH(maLH);
        }
        public DataTable HangHoa_SearchByName(string tenHang)
        {
            return hhDAL.HangHoa_SearchByName(tenHang);
        }
       
        public int HangHoa_Insert(string tenHang, string dvt, int donGia, int SLCon, string maLH)
        {
            return hhDAL.HangHoa_Insert(tenHang, dvt, donGia, SLCon, maLH);
        }
        public int HangHoa_Update(string maHang, string tenHang, string dvt, int donGia, int SLCon, string maLH)
        {
            return hhDAL.HangHoa_Update(maHang, tenHang, dvt, donGia, SLCon, maLH);
        }
        public int HangHoa_Delete(string maHang)
        {
            return hhDAL.HangHoa_Delete(maHang);
        }
    }
}
