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
    public partial class FmPhieuDangKy : DevExpress.XtraEditors.XtraForm
    {
        public FmPhieuDangKy()
        {
            InitializeComponent();
        }

        DataTable dtpdk = new DataTable();
        BLPhieuDangKy dbpdk = new BLPhieuDangKy();
        bool them = false;
        string err;
        void LoadData()
        {
            try
            {

                txbMaPDK.ResetText();
                txbMaKH.ResetText();
                dtpkNgThue.ResetText();
                dtpkNgayTra.ResetText();
                txbSoPhg.ResetText();
                txbMaTB.ResetText();
                txbTraTruoc.ResetText();
                txbTraSau.ResetText();
                txbChuThich.ResetText();

                pnInfor.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;


                dtpdk = new DataTable();
                dtpdk.Clear();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds = dbpdk.LayPhDangKy();
                dtpdk = ds.Tables[0];

                dgvPhieuDangKy.DataSource = dtpdk;
                dgvPhieuDangKy.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu !!!!");
            }
        }

        private void FmPhieuDangKy_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPhieuDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhieuDangKy.CurrentCell.RowIndex;
            txbMaPDK.Text = dgvPhieuDangKy.Rows[r].Cells[0].Value.ToString();
            txbMaKH.Text = dgvPhieuDangKy.Rows[r].Cells[1].Value.ToString();
            dtpkNgThue.Text = dgvPhieuDangKy.Rows[r].Cells[2].Value.ToString();
            dtpkNgayTra.Text = dgvPhieuDangKy.Rows[r].Cells[3].Value.ToString();
            txbSoPhg.Text = dgvPhieuDangKy.Rows[r].Cells[4].Value.ToString();
            txbMaTB.Text = dgvPhieuDangKy.Rows[r].Cells[5].Value.ToString();
            txbTraTruoc.Text = dgvPhieuDangKy.Rows[r].Cells[6].Value.ToString();
            txbTraSau.Text = dgvPhieuDangKy.Rows[r].Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            pnInfor.Enabled = true;
            txbMaKH.ResetText();
            txbMaPDK.ResetText();
            dtpkNgThue.ResetText();
            dtpkNgayTra.ResetText();
            txbSoPhg.ResetText();
            txbMaTB.ResetText();
            txbTraTruoc.ResetText();
            txbTraSau.ResetText();
            txbMaPDK.Focus();
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

            txbMaPDK.Focus();
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
                int r = dgvPhieuDangKy.CurrentCell.RowIndex;

                string strMaPDK = dgvPhieuDangKy.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbpdk.XoaPhDangKy(ref err, strMaPDK);
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
                    BLPhieuDangKy btPDK = new BLPhieuDangKy();
                    btPDK.ThemPhDangKy(this.txbMaPDK.Text, this.txbMaKH.Text, this.dtpkNgThue.Text, this.dtpkNgayTra.Text, this.txbSoPhg.Text, this.txbMaTB.Text, Int32.Parse(this.txbTraTruoc.Text), Int32.Parse(this.txbTraSau.Text), this.txbChuThich.Text, ref err);
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
                    BLPhieuDangKy btKH = new BLPhieuDangKy();
                    btKH.CapNhatPhDangKy(this.txbMaPDK.Text, this.txbMaKH.Text, this.dtpkNgThue.Text, this.dtpkNgayTra.Text, this.txbSoPhg.Text, this.txbMaTB.Text, Int32.Parse(this.txbTraTruoc.Text), Int32.Parse(this.txbTraSau.Text), this.txbChuThich.Text, ref err);
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
    }
}