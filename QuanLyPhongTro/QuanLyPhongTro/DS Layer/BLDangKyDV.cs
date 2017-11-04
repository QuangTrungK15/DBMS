using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLDangKyDV
    {
        DBMain db = null;
        public BLDangKyDV()
        {
            db = new DBMain();
        }

        public System.Data.DataSet LayDangKyDV()
        {
            return db.ExecuteQueryDataSet("select * from DANGKY_DV", CommandType.Text);
        }

        public bool ThemDangKyDV(string MaDV, string MaKH, string NgBĐ, string NgKT, ref string err)
        {
            string sqlString = "Insert Into DANGKY_DV Values(" + "'" +
            MaDV + "','" + MaKH + "','" + NgBĐ + "','" + NgKT + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
       
        public bool XoaDangKyDV(ref string err, string MaDV)
        {
            string sqlString = "Delete From SUDUNG Where MADV ='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhapDangKyDV(string MaDV, string MaKH, string NgBĐ,string NgKT, ref string err)
        {
            string sqlString = "Update DANGKY_DV Set MAKH  ='" +
            MaKH + "',NGAYBATDAU ='" + NgBĐ + "',NGAYKETTHUC ='" + NgKT + "' Where MADV ='" + MaDV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
