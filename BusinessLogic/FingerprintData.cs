using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class FingerprintData
    {
        Data da = new Data();
        
        public DataTable SelectFromFingerprintData()
        {
            
            string sql = "SELECT * FROM FingerprintData";
            DataTable dt = da.getDataTable(sql);
            return dt;
        }

        public void InsertIntoFingerprintData(string fullname, string information, string fingerprint, string fingerpath, string status)
        {
           
            string sql = "INSERT INTO FingerprintData (fullname, information, fingerprint, fingerpath, status) VALUES (N'" + fullname + "', N'" + information + "', N'" + fingerprint + "', N'" + fingerpath + "', N'" + status + "')";
            da.ExecuteNonQuery(sql);
        }


        public void DeleteFromFingerprintData(int id)
        {
            
            string sql = "DELETE FROM FingerprintData WHERE id=" + id + ";";
            da.ExecuteNonQuery(sql);
        }

        public void UpdateIntoFingerprintData(int id)
        {
            
            string sql = "UPDATE FingerprintData SET status = 'Extracted' WHERE id = " + id + ";";
            da.ExecuteNonQuery(sql);
        }
        public DataTable Datatable_SQL(String sql)
        {
            DataTable dt = da.getDataTable(sql);
            return dt;
        }

        public void Insert_SQL(String sql)
        {

           da.ExecuteNonQuery(sql);
        }


        public void Delete_SQL(String sql)
        {
            da.ExecuteNonQuery(sql);
        }

        public void Update_SQL(String  sql)
        {
            da.ExecuteNonQuery(sql);
        }

    }
}
