using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Data
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=desktop-etieo8q\sqlexpress;Initial Catalog=QLCMND;Integrated Security=True");
        }

        public DataTable getDataTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
