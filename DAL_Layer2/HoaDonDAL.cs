using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer2
{
    public class HoaDonDAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable HoaDon_Select()
        {
            return thaotac.ExecuteQuery("[dbo].[Select_HoaDon]");
        }
        public DataTable HoaDon_SelectByMa(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;
            return thaotac.ExecuteQueryByMa("Select_HoaDonByMa", name, value, 1);
        }
        public DataTable HoaDon_SelectNewID()
        {
            return thaotac.ExecuteQuery("[dbo].[Select_HoaDonNewID]");
        }
        
        public int HoaDon_Insert(string maKH, string maNV)
        {
            
            name = new string[2];
            value = new object[2];
            
            name[0] = "@MaKH"; value[0] = maKH;
            name[1] = "@MaNV"; value[1] = maNV;
            return thaotac.ExecuteNonQuery("[dbo].[Insert_HoaDon]", name, value, 2);
        }
        public int HoaDon_InsertByMa(string maHD, string maKH, string maNV)
        {

            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaKH"; value[1] = maKH;
            name[2] = "@MaNV"; value[2] = maNV;
            return thaotac.ExecuteNonQuery("[dbo].[Insert_HoaDonByMa]", name, value, 3);
        }
        public int HoaDon_Delete(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;
            return thaotac.ExecuteNonQuery("[dbo].[Delete_HoaDon]", name, value, 1);
        }
        public int HoaDon_Update(string maHD, string maKH, string maNV)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaKH"; value[1] = maKH;
            name[2] = "@MaNV"; value[2] = maNV;
            return thaotac.ExecuteNonQuery("Update_HoaDon", name, value, 3);
        }
    }
}
