using QuanLyPhongTro.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DS_Layer
{
    class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }
        public System.Data.DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("select * from KHACHHANG", CommandType.Text);
        }
        public System.Data.DataSet Lay1KhachHang(string sqlString)
        {
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemKhachHang(string MaKH, string TenKH,string NgSinh, string Scmnd,  string Diachi, string NgNghiep, string Sdt, ref string err)
        {
            string sqlString = "Insert Into KHACHHANG Values(" + "'" +
            MaKH + "',N'" + TenKH + "','"+NgSinh+"','" + Scmnd + "',N'" + Diachi + "',N'" + NgNghiep + "','" + Sdt + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            string sqlString = "Delete From KHACHHANG Where MAKH ='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKH, string TenKH,string NgSinh, string Scmnd, string Diachi, string NgNghiep, string Sdt, ref string err)
        {
            string sqlString = "Update KHACHHANG Set TENKH  =N'" +
            TenKH +"',NGAYSINH='"+NgSinh+"',SOCMND ='" + Scmnd + "',DIACHI=N'" + Diachi + "',NGHENGHIEP=N'" + NgNghiep + "',SDT='" + Sdt +
            "' Where MAKH ='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool TimKiemKhachHang(string MaKH, string TenKH, string Cmnd, ref string err)
        {
            string sqlString = "Select *from KhachHang where MaKH = '" + MaKH + "' AND TenKH = N'" + TenKH + "' AND SoCMND='" + Cmnd + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
