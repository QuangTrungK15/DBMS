using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLPhongTro
    {
        DBMain db = null;
        public BLPhongTro()
        {
            db = new DBMain();
        }
        public System.Data.DataSet LayPhongTro()
        {
            return db.ExecuteQueryDataSet("select * from PHONGTRO", CommandType.Text);
        }
        public bool ThemPhongTro(string MaPT, string TenPT, int Htp, string giaPhong, string Sng, ref string err)
        {
            string sqlString = "Insert Into PHONGTRO Values('" +
            MaPT + "',N'" + TenPT + "'," + Htp + ",'" + giaPhong + "','" + Sng + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhongTro(ref string err, string MaPT)
        {
            string sqlString = "Delete From PHONGTRO Where MAPHONG ='" + MaPT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhongTro(string MaPT, string TenPT, int Htp, string giaPhong, string Sng, ref string err)
        {
            string sqlString = "Update PHONGTRO Set TENPHONG  =N'" +
            TenPT + "',HIENTRANGPHONG =" + Htp + ",GIAPHONG = '" + giaPhong + "',SOLUONGNGUOI='" + Sng + "' Where MAPHONG = '" + MaPT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool TimKiemPhongTro(string MaKH, string TenKH, string Cmnd, ref string err)
        {
            string sqlString = "Select *from PHONGTRO where MaKH = '" + MaKH + "' AND TenKH = N'" + TenKH + "' AND SoCMND='" + Cmnd + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
