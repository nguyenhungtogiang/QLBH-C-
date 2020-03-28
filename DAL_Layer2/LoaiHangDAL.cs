using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DAL_Layer2
{
    public class LoaiHangDAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable LoaiHang_Select()
        {
            return thaotac.ExecuteQuery("[dbo].[Select_LoaiHang]");
        }
        public DataTable LoaiHang_SelectByMa(string maLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = maLH;
            return thaotac.ExecuteQueryByMa("Select_LoaiHangByMa", name, value, 1);
        }
        public DataTable LoaiHang_SearchByName(string tenLoaiHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenLoaiHang";
            value[0] = tenLoaiHang;
            return thaotac.ExecuteQueryByMa("[dbo].[Search_LoaiHangByName]", name, value, 1);
        }
        public int LoaiHang_Insert(string tenLH, string ghichu)
        {
            name = new string[2];
            value = new object[2];
            
            name[0] = "@TenLoaiHang"; value[0] = tenLH;
            name[1] = "@ghichu"; value[1] = ghichu;
            return thaotac.ExecuteNonQuery("[dbo].[Insert_LoaiHang]", name, value, 2);
        }
        public int LoaiHang_Delete(string maLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = maLH;
            return thaotac.ExecuteNonQuery("[dbo].[Delete_LoaiHang]", name, value, 1);
        }
        public int LoaiHang_Update(string maLH, string tenLH, string ghichu)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLoaiHang"; value[0] = maLH;
            name[1] = "@TenLoaiHang"; value[1] = tenLH;
            name[2] = "@ghichu"; value[2] = ghichu;
            return thaotac.ExecuteNonQuery("Update_LoaiHang", name, value, 3);
        }
    }
}
