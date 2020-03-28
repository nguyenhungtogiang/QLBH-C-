using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer2
{
    public class NhanVienDAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable NhanVien_Select()
        {
            return thaotac.ExecuteQuery("[dbo].[Select_NhanVien]");
        }
        public DataTable NhanVien_SelectByMa(string maNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = maNV;
            return thaotac.ExecuteQueryByMa("Select_NhanVienByMa", name, value, 1);
        }
        public DataTable NhanVien_SearchByName(string tenNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenNV"; value[0] = tenNV;
            return thaotac.ExecuteQueryByMa("[dbo].[Search_NhanVienByName]", name, value, 1);
        }
        public int NhanVien_Insert(string tenNV, DateTime NgaySinh, bool gioiTinh, string sdt)
        {
            name = new string[4];
            value = new object[4];
           
            name[0] = "@TenNV"; value[0] = tenNV;
            name[1] = "@NgaySinh"; value[1] = NgaySinh;
            name[2] = "@GioiTinh"; value[2] = gioiTinh;
            name[3] = "@SDT"; value[3] = sdt;
            
            return thaotac.ExecuteNonQuery("[dbo].[Insert_NhanVien]", name, value, 4);
        }
        public int NhanVien_Delete(string maNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV"; value[0] = maNV;
            return thaotac.ExecuteNonQuery("[dbo].[Delete_NhanVien]", name, value, 1);
        }
        public int NhanVien_Update(string maNV, string tenNV, DateTime NgaySinh, bool gioiTinh, string sdt)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@MaNV"; value[0] = maNV;
            name[1] = "@TenNV"; value[1] = tenNV;
            name[2] = "@NgaySinh"; value[2] = NgaySinh;
            name[3] = "@GioiTinh"; value[3] = gioiTinh;
            name[4] = "@SDT"; value[4] = sdt;
            return thaotac.ExecuteNonQuery("Update_NhanVien", name, value, 5);
        }
    }
}
