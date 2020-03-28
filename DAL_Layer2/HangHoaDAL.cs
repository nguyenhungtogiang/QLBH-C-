using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer2
{
    public class HangHoaDAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable HangHoa_Select()
        {
            return thaotac.ExecuteQuery("[dbo].[Select_HangHoa]");
        }
        public DataTable HangHoa_SelectByMa(string maHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = maHang;
            return thaotac.ExecuteQueryByMa("Select_HangHoaByMa", name, value, 1);
        }
        public DataTable HangHoa_SelectByMaLH(string maLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@maLH"; value[0] = maLH;
            return thaotac.ExecuteQueryByMa("Select_HangHoaByMaLH", name, value, 1);
        }
        public DataTable HangHoa_SearchByName(string tenHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TenHang"; value[0] = tenHang;
            return thaotac.ExecuteQueryByMa("Search_HangHoaByName", name, value, 1);
        }
        
        public int HangHoa_Insert(string tenHang, string dvt, int donGia, int SLCon, string MaLH)
        {
            name = new string[6];
            value = new object[6];
            
            name[0] = "@TenHang"; value[0] = tenHang;
            name[1] = "@dvt"; value[1] = dvt;
            name[2] = "@DonGia"; value[2] = donGia;
            name[3] = "@SLCon"; value[3] = SLCon;
            name[4] = "@MaLoaiHang"; value[4] = MaLH;
            return thaotac.ExecuteNonQuery("[dbo].[Insert_HangHoa]", name, value, 5);
        }
        public int HangHoa_Delete(string maHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = maHang;
            return thaotac.ExecuteNonQuery("[dbo].[Delete_HangHoa]", name, value, 1);
        }
        public int HangHoa_Update(string maHang, string tenHang, string dvt, int donGia, int SLCon, string MaLH)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaHang"; value[0] = maHang;
            name[1] = "@TenHang"; value[1] = tenHang;
            name[2] = "@dvt"; value[2] = dvt;
            name[3] = "@DonGia"; value[3] = donGia;
            name[4] = "@SLCon"; value[4] = SLCon;
            name[5] = "@MaLoaiHang"; value[5] = MaLH;
            return thaotac.ExecuteNonQuery("Update_HangHoa", name, value, 6);
        }
    }
}
