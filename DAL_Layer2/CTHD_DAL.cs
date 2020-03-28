using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer2
{
    public class CTHD_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable CTHD_Select()
        {
            return thaotac.ExecuteQuery("[dbo].[Select_CTHD]");
        }
        public DataTable CTHD_SelectByMaHD(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;
            
            return thaotac.ExecuteQueryByMa("Select_CTHDByMaHD", name, value, 1);
        }
        public DataTable CTHD_HDBH(string maHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = maHD;

            return thaotac.ExecuteQueryByMa("CTHD_HDBH", name, value, 1);
        }
        public DataTable CTHD_Insert(string maHD, string maHang, int SL)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaHang"; value[1] = maHang;
            name[2] = "@SL"; value[2] = SL;
            return thaotac.ExecuteQueryByMa("[dbo].[Insert_CTHD]", name, value, 3);
        }
        public int CTHD_Delete(string maHD, string maHang, string SL)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaHang"; value[1] = maHang;
            return thaotac.ExecuteNonQuery("[dbo].[Delete_CTHD]", name, value, 2);
        }
        public int CTHD_Update(string maHD, string maHang, string SL)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD"; value[0] = maHD;
            name[1] = "@MaHang"; value[1] = maHang;
            name[2] = "@SL"; value[2] = SL;
            return thaotac.ExecuteNonQuery("Update_CTHD", name, value, 3);
        }
    }
}
