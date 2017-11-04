using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DB_Layer
{
    class DBMain
    {
        string ConnStr = "Data Source = TRUNG;Initial Catalog = QuanLyPhongTro; Integrated Security = True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public System.Data.DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            System.Data.DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
