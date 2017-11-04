using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLDichVu
    {
        DBMain db = null;
        public BLDichVu()
        {
            db = new DBMain();
        }
        public System.Data.DataSet LayDichVu()
        {
            return db.ExecuteQueryDataSet("select * from DICHVU", CommandType.Text);
        }
        public bool ThemDichVu(string MaDV, string TenDV, int GiaDV, ref string err)
        {
            string sqlString = "Insert Into DICHVU Values(" + "'" +
            MaDV + "',N'" + TenDV + "','" + GiaDV + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaDichVu(ref string err, string MaDV)
        {
            string sqlString = "Delete From DICHVU Where MADV ='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatDichVu(string MaDV, string TenDV, int GiaDV, ref string err)
        {
            string sqlString = "Update DICHVU Set TENDV  =N'" +
            TenDV + "',GIADV ='" + GiaDV +  "' Where MADV ='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
