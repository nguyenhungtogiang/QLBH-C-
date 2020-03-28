using DAL_Layer2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Layer
{
    public class LoaiHangBLL
    {
        LoaiHangDAL lhDAL = new LoaiHangDAL();
        private static LoaiHangBLL instance;
        public static LoaiHangBLL Instance
        {
            get { if (instance == null) instance = new LoaiHangBLL(); return LoaiHangBLL.instance; }
            set { instance = value; }
        }
        
        public DataTable LoaiHang_Select()
        {
            return lhDAL.LoaiHang_Select();
        }
        public DataTable LoaiHang_SelectByMa(string maLH)
        {
            return lhDAL.LoaiHang_SelectByMa(maLH);
        }
        public DataTable LoaiHang_SearchByName(string tenLoaiHang)
        {
            return lhDAL.LoaiHang_SearchByName(tenLoaiHang);
        }
        public int LoaiHang_Insert(string tenLoaiHang, string ghichu)
        {
            return lhDAL.LoaiHang_Insert(tenLoaiHang, ghichu);
        }
        public int LoaiHang_Delete(string maLoaiHang)
        {
            return lhDAL.LoaiHang_Delete(maLoaiHang);
        }
        public int LoaiHang_Update(string maLoaiHang, string tenLoaiHang, string ghichu)
        {
            return lhDAL.LoaiHang_Update(maLoaiHang, tenLoaiHang, ghichu);
        }
    }
}
