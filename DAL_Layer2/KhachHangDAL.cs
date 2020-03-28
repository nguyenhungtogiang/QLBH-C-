using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer2
{
    public class KhachHangDAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable KhachHang_Select()
        {
            return thaotac.ExecuteQuery("[dbo].[Select_KhachHang]");
        }
        public DataTable KhachHang_SelectByMa(string maKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaKH"; value[0] = maKH;
            return thaotac.ExecuteQueryByMa("Select_KhachHangByMa", name, value, 1);
        }
        public DataTable KhachHang_SearchByName(string tenKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@tenKH"; value[0] = tenKH;
            return thaotac.ExecuteQueryByMa("[dbo].[Search_KhachHangByName]",name,value,1);
        }
        public int KhachHang_Insert(string tenKH, string diaChi, string sdt, string STK, string MST)
        {
            name = new string[6];
            value = new object[6];
          
            name[0] = "@TenKH"; value[0] = tenKH;
            name[1] = "@DiaChi"; value[1] = diaChi;
            name[2] = "@SDT"; value[2] = sdt;
            name[3] = "@STK"; value[3] = STK;
            name[4] = "@MST"; value[4] = MST;
            return thaotac.ExecuteNonQuery("[dbo].[Insert_KhachHang]", name, value, 5);
        }
        public int KhachHang_Delete(string maKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaKH"; value[0] = maKH;
            return thaotac.ExecuteNonQuery("[dbo].[Delete_KhachHang]", name, value, 1);
        }
        public int KhachHang_Update(string maKH, string tenKH, string diaChi, string sdt, string STK, string MST)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaKH"; value[0] = maKH;
            name[1] = "@TenKH"; value[1] = tenKH;
            name[2] = "@DiaChi"; value[2] = diaChi;
            name[3] = "@SDT"; value[3] = sdt;
            name[4] = "@STK"; value[4] = STK;
            name[5] = "@MST"; value[5] = MST;
            return thaotac.ExecuteNonQuery("Update_KhachHang", name, value, 6);
        }
    }
}
