using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLPhieuDangKy
    {

        DBMain db = null;
        public BLPhieuDangKy()
        {
            db = new DBMain();
        }

        public DataSet LayPhDangKy()
        {
            return db.ExecuteQueryDataSet("select * from PHIEUDANGKY", CommandType.Text);
        }

        public bool ThemPhDangKy(string MaPDK, string MaKH, string NgThue, string NgTra, string SoPhong, string MaTB, int TraTruoc, int TraSau,string ChuThich, ref string err)
        {
            string sqlString = "Insert Into PHIEUDANGKY Values(" + "'" +
            MaPDK + "','" + MaKH + "','" + NgThue + "','" + NgTra + "','" + SoPhong + "','" + MaTB + "'," + TraTruoc + "," + TraSau + ",'"+ChuThich+"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhDangKy(ref string err, string MaPDK)
        {
            string sqlString = "Delete From PHIEUDANGKY Where MAPDK ='" + MaPDK + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhDangKy(string MaPDK, string MaKH, string NgThue, string NgTra, string SoPhong, string MaTB, int TraTruoc, int TraSau,string ChuThich, ref string err)
        {
            string sqlString = "Update PHIEUDANGKY Set MAKH  ='" +
            MaKH + "',NGAYTHUE='" + NgThue + "',NGAYTRA ='" + NgTra + "',SOPHONG='" + SoPhong + "',MATB='" + MaTB + "',TRATRUOC=" + TraTruoc + ",TRASAU=" + TraSau + ",CHUTHICH=N'"+ ChuThich +"' Where MAPDK ='" + MaPDK + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
