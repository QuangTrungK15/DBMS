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
    public partial class FmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FmKhachHang()
        {
            InitializeComponent();
        }

        DataTable dtkh = new DataTable();
        BLKhachHang dbkh = new BLKhachHang();
        bool them = false;
        string err;
        void LoadData()
        {
            try
            {
                txbMaKH.ResetText();
                txbTenKH.ResetText();
                dtpkNgSinh.ResetText();
                txbCMND.ResetText();
                txbDiaChi.ResetText();
                txbNgheNghiep.ResetText();
                txbSoDienThoai.ResetText();

                pnInfor.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;


                dtkh = new DataTable();
                dtkh.Clear();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds = dbkh.LayKhachHang();
                dtkh = ds.Tables[0];

                dgvKhachHang.DataSource = dtkh;
                dgvKhachHang.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu !!!!");
            }
        }

        private void FmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            pnInfor.Enabled = true;
            txbMaKH.ResetText();
            txbTenKH.ResetText();
            dtpkNgSinh.ResetText();
            txbCMND.ResetText();
            txbDiaChi.ResetText();
            txbNgheNghiep.ResetText();
            txbSoDienThoai.ResetText();
            txbMaKH.Focus();
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

            txbMaKH.Focus();
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
                int r = dgvKhachHang.CurrentCell.RowIndex;

                string strMaKH = dgvKhachHang.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbkh.XoaKhachHang(ref err, strMaKH);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!!!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện được việc xóa!!!");
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
                    BLKhachHang btKH = new BLKhachHang();
                    btKH.ThemKhachHang(this.txbMaKH.Text, this.txbTenKH.Text,this.dtpkNgSinh.Text, this.txbCMND.Text, this.txbDiaChi.Text, this.txbNgheNghiep.Text, this.txbSoDienThoai.Text, ref err);
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
                    BLKhachHang btKH = new BLKhachHang();
                    btKH.CapNhatKhachHang(this.txbMaKH.Text, this.txbTenKH.Text, this.dtpkNgSinh.Text, this.txbCMND.Text, this.txbDiaChi.Text, this.txbNgheNghiep.Text, this.txbSoDienThoai.Text, ref err);
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            txbMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txbTenKH.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            dtpkNgSinh.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            txbCMND.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            txbDiaChi.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            txbNgheNghiep.Text = dgvKhachHang.Rows[r].Cells[5].Value.ToString();
            txbSoDienThoai.Text = dgvKhachHang.Rows[r].Cells[6].Value.ToString();
        }
    }
}