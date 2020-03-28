using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class ThaoTacCSDL
    {
        SqlConnection con;
        private void KetNoiCSDL()
        {
            con = new SqlConnection("Data Source=HUNGTO-PC;Initial Catalog=QLBH;Integrated Security=True");
            con.Open();
        }
        private void NgatKetNoi()
        {
            con.Close();
            con.Dispose();
        }
        public DataTable ExecuteQuery(string tenSP)
        {
            KetNoiCSDL();
            SqlCommand command = new SqlCommand(tenSP, con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        //public DataTable ExecuteQuery(string tenSP, object[] Npara = null)
        //{
        //    KetNoiCSDL();
        //    SqlCommand command = new SqlCommand(tenSP, con);
        //    command.CommandType = CommandType.StoredProcedure;
        //    string[] listPara = tenSP.Split(' ');
        //    int i = 0;
        //    foreach (string item in listPara)
        //    {
        //        if (item.Contains('@'))
        //        {
        //            //Gán parameter vào các biến
        //            command.Parameters.AddWithValue(item, Npara[i]);
        //            i++;
        //        }
        //    }
        //    SqlDataAdapter adap = new SqlDataAdapter(command);
        //    DataTable dt = new DataTable();
        //    adap.Fill(dt);
        //    NgatKetNoi();
        //    return dt;
        //}
        public int ExecuteNonQuery(string tenSP, string[] name, object[] value, int Npara)
        {
            KetNoiCSDL();
            SqlCommand command = new SqlCommand(tenSP, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            
            return command.ExecuteNonQuery();

        }
        public DataTable ExecuteQueryByMa(string tenSP, string[] name, object[] value, int Npara)
        {
            KetNoiCSDL();
            SqlCommand command = new SqlCommand(tenSP, con);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < Npara; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            NgatKetNoi();
            return dt;

        }
        
    }
}
