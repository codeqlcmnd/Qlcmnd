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
        public DataTable get_Table(string sql)
        {
            return da.getTable(sql);
        }

        public void ExecuteNonQuery(string sql)
        {
            da.getNon(sql);
        }
        public void Them_Canbo(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            string sql = string.Format("insert into CanBo values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')", s1, s2, s3, s4, s5,s6);
            da.getNon(sql);
        }
    }
}
