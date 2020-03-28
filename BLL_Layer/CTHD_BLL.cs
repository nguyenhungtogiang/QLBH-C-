using DAL_Layer2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Layer
{
    public class CTHD_BLL
    {
        CTHD_DAL cthdDAL = new CTHD_DAL();
        private static CTHD_BLL instance;
        public static CTHD_BLL Instance
        {
            get { if (instance == null) instance = new CTHD_BLL(); return CTHD_BLL.instance; }
            set { instance = value; }
        }

        public DataTable CTHD_Select()
        {
            return cthdDAL.CTHD_Select();
        }
        public DataTable CTHD_SelectByMaHD(string maHD)
        {
            return cthdDAL.CTHD_SelectByMaHD(maHD);
        }
        public DataTable CTHD_HDBH(string maHD)
        {
            return cthdDAL.CTHD_HDBH(maHD);
        }
        public DataTable CTHD_Insert(string maHD, string maHang, int SL)
        {
            return cthdDAL.CTHD_Insert(maHD, maHang, SL);
        }
    }
}
