using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLPhieuThanhToan
    {

        DBMain db = null;
        public BLPhieuThanhToan()
        {
            db = new DBMain();
        }

        public DataSet LayPhThanhToan()
        {
            return db.ExecuteQueryDataSet("Select *from PHIEUTHANHTOAN",CommandType.Text);
        }


        public bool ThemPhThToan(string MaPTT, string MaPDK, int SoThang, string NgThToan, int TongTien,int TienPhTra, ref string err)
        {
            string sqlString = "Insert Into PHIEUTHANHTOAN Values('" +
            MaPTT + "','" + MaPDK + "'," + SoThang + ",'" + NgThToan + "'," + TongTien + ","+ TienPhTra + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaPhThToan(ref string err, string MaPTT)
        {
            string sqlString = "Delete From PHIEUTHANHTOAN Where MAPTT ='" + MaPTT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatPhThToan(string MaPTT, string MaPDK, int SoThang, string NgThToan, int TongTien, int TienPhTra, ref string err)
        {
            string sqlString = "Update PHIEUTHANHTOAN Set MAPDK  ='" +
            MaPDK + "',SOTHANG =" + SoThang + ",NGAYTT = '" + NgThToan + "',TONGTIEN=" + TongTien + ",TIENPHAITRA=" + TienPhTra + " Where MAPTT = '" + MaPTT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}
