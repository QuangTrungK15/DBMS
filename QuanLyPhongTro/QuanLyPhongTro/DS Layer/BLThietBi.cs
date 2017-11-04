using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLThietBi
    {
        DBMain db = null;
        public BLThietBi()
        {
            db = new DBMain();
        }

        public DataSet LayThietBi()
        {
            return db.ExecuteQueryDataSet("select * from THIETBI", CommandType.Text);
        }

        public bool ThemThietBi(string MaTB, string TenTB ,ref string err)
        {
            string sqlString = "Insert Into THIETBI Values(" + "'" +
            MaTB + "',N'" + TenTB + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaThietBi(ref string err, string MaTB)
        {
            string sqlString = "Delete From THIETBI Where MATB ='" + MaTB + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhapThietBi(string MaTB, string TenTB, ref string err)
        {
            string sqlString = "Update THIETBI Set TENTB  =N'" +
            TenTB +  "' Where MATB ='" + MaTB + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
