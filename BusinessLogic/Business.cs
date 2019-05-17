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
    public class Business
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
            string sql = string.Format("insert into CanBo(sohieu,hoten,ngaysinh,gioitinh,capbac,chucvu) values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')", s1, s2, s3, s4, s5,s6);
            da.getNon(sql);
        }
        public void Sua_Canbo(string s1, string s2, string s3, string s4, string s5, string s6, string s7)
        {
            int id = Int32.Parse(s7);
            string sql = string.Format("Update CanBo set sohieu = N'{0}',hoten =N'{1}',ngaysinh =N'{2}',gioitinh =N'{3}',capbac =N'{4}',chucvu =N'{5}' where ID = '{6}'", s1, s2, s3, s4, s5, s6,s7);
            da.getNon(sql);
        }
        public void Them_Taikhoan(int s1, string s2, string s3, string s4)
        {
            string sql = string.Format("insert into TaiKhoan(macanbo,taikhoan,matkhau,quyen) values('{0}', N'{1}', N'{2}', N'{3}')", s1, s2, s3, s4);
            da.getNon(sql);
        }
        public void Sua_Taikhoan(int s1, string s2, string s3, string s4, string s5)
        {
            int id = Int32.Parse(s5);
            string sql = string.Format("Update TaiKhoan set macanbo = '{0}',taikhoan =N'{1}',matkhau =N'{2}',quyen =N'{3}' where ID = '{4}'", s1, s2, s3, s4, s5);
            da.getNon(sql);
        }
        public int Dem_Canbo(string s1)
        {
            string sql;
            if (s1.Equals(""))
            {
                sql = "Select * from canbo";
            }
            else
            {
                sql = String.Format("Select * from canbo where {0}",s1);
            }
            DataTable dt = new DataTable();
            dt = get_Table(sql);
            return Int32.Parse(dt.Rows.Count.ToString());
        }
        public int Dem_Taikhoan(string s1)
        {
            string sql;
            if (s1.Equals(""))
            {
                sql = "Select * from taikhoan";
            }
            else
            {
                sql = String.Format("Select * from taikhoan where {0}", s1);
            }
            DataTable dt = new DataTable();
            dt = get_Table(sql);
            return Int32.Parse(dt.Rows.Count.ToString());
        }
        public int Dem_CB(string s1)
        {
            string sql;
            if (s1.Equals(""))
            {
                sql = "Select * from chiban";
            }
            else
            {
                sql = String.Format("Select * from chiban where {0}", s1);
            }
            DataTable dt = new DataTable();
            dt = get_Table(sql);
            return Int32.Parse(dt.Rows.Count.ToString());
        }
        public int Dem_TK(string s1)
        {
            string sql;
            if (s1.Equals(""))
            {
                sql = "Select * from tokhai";
            }
            else
            {
                sql = String.Format("Select * from tokhai where {0}", s1);
            }
            DataTable dt = new DataTable();
            dt = get_Table(sql);
            return Int32.Parse(dt.Rows.Count.ToString());
        }
        public int Dem_CMND(string s1)
        {
            string sql;
            if (s1.Equals(""))
            {
                sql = "Select * from cmnd";
            }
            else
            {
                sql = String.Format("Select * from cmnd where {0}", s1);
            }
            DataTable dt = new DataTable();
            dt = get_Table(sql);
            return Int32.Parse(dt.Rows.Count.ToString());
        }


        public DataSet dataset()
        {
            DataSet datas = new DataSet();
            string sql1 = "select * from Canbo";
            DataTable Canbo = new DataTable();
            Canbo = da.getTable(sql1);
            datas.Tables.Add(Canbo);
            string sql2 = "select * from Taikhoan";
            DataTable TKhoan = new DataTable();
            TKhoan = da.getTable(sql2);
            datas.Tables.Add(TKhoan);
            string sql3 = "select * from Tokhai";
            DataTable TK = new DataTable();
            TK = da.getTable(sql3);
            datas.Tables.Add(TK);
            string sql4 = "select * from CMND";
            DataTable CMND = new DataTable();
            CMND = da.getTable(sql4);
            datas.Tables.Add(CMND);
            string sql5 = "select * from Chiban";
            DataTable CB = new DataTable();
            CB = da.getTable(sql5);
            datas.Tables.Add(CB);
            return datas;
        }
        public void xoa(string s1, string s2, string s3)
        {
            if (s3.Equals(""))
            {
                string s = string.Format("delete from " + s1 + " where " + s2 + "");
                da.getNon(s);
            }
            else
            {
                string sql = string.Format("delete from {0} where {1} like N'{2}'", s1, s2, s3);
                da.getNon(sql);
            }
        }
    }
}
