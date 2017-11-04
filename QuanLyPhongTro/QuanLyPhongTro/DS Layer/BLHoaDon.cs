using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLHoaDon
    {

        DBMain db = null;
        public BLHoaDon()
        {
            db = new DBMain();
        }

        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet("select *from HOADON",CommandType.Text);
        }
        public System.Data.DataSet Lay1HoaDon(string sqlString)
        {
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemHoaDon(string MaHĐ, string MaPTT, string NgLapHD, float ThueV, ref string err)
        {
            string sqlString = "Insert Into HOADON Values('" +
            MaHĐ + "','" + MaPTT + "','" + NgLapHD + "','" + ThueV +  "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHoaDon(ref string err, string MaHĐ)
        {
            string sqlString = "Delete From HOADON Where MAHD ='" + MaHĐ + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatHoaDon(string MaHĐ, string MaPTT, string NgLapHD, float ThueV, ref string err)
        {
            string sqlString = "Update HOADON Set MAPTT  ='" +
            MaPTT + "',NGAYLAPHD ='" + NgLapHD + "',THUEVAT =" + ThueV + " Where MAHD ='" + MaHĐ + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}
