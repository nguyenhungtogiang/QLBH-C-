using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer2
{
    public class TaiKhoanDAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable TaiKhoan_Select()
        {
            return thaotac.ExecuteQuery("Select_TaiKhoan");
        }
        public DataTable TaiKhoan_SelectByTenTk(string userName)
        {
            name = new string[1];
            value = new string[1];
            name[0] = "@UserName"; value[0] = userName;
            return thaotac.ExecuteQueryByMa("Select_TaikhoanByTenTK", name, value, 1);
        }
        public DataTable TaiKhoan_SearchByTenTk(string userName)
        {
            name = new string[1];
            value = new string[1];
            name[0] = "@UserName"; value[0] = userName;
            return thaotac.ExecuteQueryByMa("Search_TaikhoanByName", name, value, 1);
        }
        public int TaiKhoan_Login(string userName, string passWord)
        {
            name = new string[2];
            value = new string[2];
            name[0] = "@UserName"; value[0] = userName;
            name[1] = "@PassWord"; value[1] = passWord;
            return thaotac.ExecuteNonQuery("Login_TaiKhoan", name, value, 2);
        }
        public int TaiKhoan_Insert(string userName, string passWord, string MaNV)
        {
            name = new string[3];
            value = new string[3];
            name[0] = "@UserName"; value[0] = userName;
            name[1] = "@PassWord"; value[1] = passWord;
            name[2] = "@MaNV"; value[2] = MaNV;
            return thaotac.ExecuteNonQuery("Insert_TaiKhoan", name, value, 3);

        }
        public int TaiKhoan_Update(string userName, string passWord, string MaNV)
        {
            name = new string[3];
            value = new string[3];
            name[0] = "@UserName"; value[0] = userName;
            name[1] = "@PassWord"; value[1] = passWord;
            name[2] = "@MaNV"; value[2] = MaNV;
            return thaotac.ExecuteNonQuery("Update_TaiKhoan", name, value, 3);
        }
        public int TaiKhoan_Delete(string userName)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "UserName"; value[0] = userName;
            return thaotac.ExecuteNonQuery("Delete_TaiKhoan", name, value, 1);
        }
    }
}
