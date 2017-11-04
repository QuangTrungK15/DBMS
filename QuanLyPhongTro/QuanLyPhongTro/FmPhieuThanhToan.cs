using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyPhongTro.DS_Layer;
using System.Data.SqlClient;

namespace QuanLyPhongTro
{
    public partial class FmPhieuThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public FmPhieuThanhToan()
        {
            InitializeComponent();
        }

        BLPhieuThanhToan dbptt = new BLPhieuThanhToan();
        DataTable dtptt = new DataTable();
        bool them = false;
        string err;
        void LoadData()
        {
            try
            {
                txbMaPTT.ResetText();
                txbMaPĐK.ResetText();
                txbSoThang.ResetText();
                dtpkNgThToan.ResetText();
                txbTienPhaiTra.ResetText();
                txbTongTien.ResetText();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                pnInfor.Enabled = false;

                System.Data.DataSet ds = dbptt.LayPhThanhToan();
                dtptt = ds.Tables[0];
                dgvPhThToan.DataSource = dtptt;
                dgvPhThToan.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu !!!!");
            }

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            pnInfor.Enabled = true;
            txbMaPĐK.ResetText();
            txbMaPTT.ResetText();
            txbSoThang.ResetText();
            dtpkNgThToan.ResetText();
            txbTienPhaiTra.ResetText();
            txbTongTien.ResetText();
            txbMaPTT.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            pnInfor.Enabled = true;

            txbMaPTT.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvPhThToan.CurrentCell.RowIndex;

                string strMaPTT = dgvPhThToan.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbptt.XoaPhThToan(ref err, strMaPTT);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!!!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được lỗi rồi!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLPhieuThanhToan btptt = new BLPhieuThanhToan();
                    btptt.ThemPhThToan (this.txbMaPTT.Text, this.txbMaPĐK.Text, Int32.Parse(this.txbSoThang.Text), this.dtpkNgThToan.Text, Int32.Parse(this.txbTongTien.Text),Int32.Parse(this.txbTienPhaiTra.Text), ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong !!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được hãy thử lại !!!");
                }
            }
            else
            {
                try
                {
                    BLPhieuThanhToan btptt = new BLPhieuThanhToan();
                    btptt.CapNhatPhThToan(this.txbMaPTT.Text, this.txbMaPĐK.Text, Int32.Parse(this.txbSoThang.Text), this.dtpkNgThToan.Text, Int32.Parse(this.txbTongTien.Text), Int32.Parse(this.txbTienPhaiTra.Text), ref err);
                    LoadData();
                    MessageBox.Show("Đã sửa xong!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được hãy thử lại !!!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FmPhieuThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPhThToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhThToan.CurrentCell.RowIndex;
            txbMaPTT.Text = dgvPhThToan.Rows[r].Cells[0].Value.ToString();
            txbMaPĐK.Text = dgvPhThToan.Rows[r].Cells[1].Value.ToString();
            txbSoThang.Text = dgvPhThToan.Rows[r].Cells[2].Value.ToString();
            dtpkNgThToan.Text = dgvPhThToan.Rows[r].Cells[3].Value.ToString();
            txbTongTien.Text = dgvPhThToan.Rows[r].Cells[4].Value.ToString();
            txbTienPhaiTra.Text = dgvPhThToan.Rows[r].Cells[5].Value.ToString();
        }
    }
}