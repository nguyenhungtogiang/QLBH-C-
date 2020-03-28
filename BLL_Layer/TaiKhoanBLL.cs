using DAL_Layer2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Layer
{
    public class TaiKhoanBLL
    {
        private static TaiKhoanBLL instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBLL();
                return TaiKhoanBLL.instance;
            }
            set { instance = value; }
        }
        TaiKhoanDAL tkDAL = new TaiKhoanDAL();
        public DataTable TaiKhoan_Select()
        {
            return tkDAL.TaiKhoan_Select();
        }

        public DataTable TaiKhoan_SelectByTenTK(string userName)
        {
            return tkDAL.TaiKhoan_SelectByTenTk(userName);
        }
        public DataTable TaiKhoan_SearchByTenTK(string userName)
        {
            return tkDAL.TaiKhoan_SearchByTenTk(userName);
        }
        public int TaiKhoan_Login(string userName,string passWord)
        {
            return tkDAL.TaiKhoan_Login(userName, passWord);
        }
        public int TaiKhoan_Insert(string userName, string passWord, string maNV)
        {
            return tkDAL.TaiKhoan_Insert(userName, passWord, maNV);
        }
        public int TaiKhoan_Update(string userName, string passWord, string maNV)
        {
            return tkDAL.TaiKhoan_Update(userName, passWord, maNV);
        }
        public int Taikhoan_Delete(string userName)
        {
            return tkDAL.TaiKhoan_Delete(userName);
        }


    }
}
