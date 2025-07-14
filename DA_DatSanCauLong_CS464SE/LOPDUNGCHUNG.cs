using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsForms_DataBase
{
    internal class LOPDUNGCHUNG
    {
        // Chuỗi kết nối
        private string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\TRIEU TRAN\DA_DatSanCauLong_CS464SE\DA_DatSanCauLong_CS464SE\DB_QLSan.mdf"";Integrated Security=True";
        private SqlConnection conn;

        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoikn);
        }

        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }

        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }

        public DataTable LoadDL(string sql)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();

            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();  // nhớ đóng
            return dt;
        }
    }
}
