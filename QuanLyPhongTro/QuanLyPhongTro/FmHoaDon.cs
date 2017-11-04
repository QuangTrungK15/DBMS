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
    public partial class FmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public FmHoaDon()
        {
            InitializeComponent();
        }


        DataTable dtHĐ = new DataTable();
        BLHoaDon dbHĐ = new BLHoaDon();
        bool them = false;
        bool tinhTien = false;
        string err;
        void LoadData()
        {
            pnInfor.Enabled = false;
            txbMaHD.ResetText();
            txbMaPTT.ResetText();
            dtpkNgLapHD.ResetText();
            txbThueVAT.ResetText();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dtHĐ = new DataTable();
            dtHĐ.Clear();

            System.Data.DataSet ds = dbHĐ.LayHoaDon();
            dtHĐ = ds.Tables[0];

            dgvHoaDon.DataSource = dtHĐ;
            dgvHoaDon.AutoResizeColumns();

        }

        private void FmHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            pnInfor.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnInfor.Enabled = true;
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
                int r = dgvHoaDon.CurrentCell.RowIndex;

                string strMaHD = dgvHoaDon.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbHĐ.XoaHoaDon(ref err, strMaHD);
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
                    BLHoaDon btHD = new BLHoaDon();
                    btHD.ThemHoaDon(this.txbMaHD.Text, this.txbMaPTT.Text, this.dtpkNgLapHD.Text, float.Parse(this.txbThueVAT.Text), ref err);
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
                    BLHoaDon btHD = new BLHoaDon();
                    btHD.CapNhatHoaDon(this.txbMaHD.Text, this.txbMaPTT.Text, this.dtpkNgLapHD.Text, float.Parse(this.txbThueVAT.Text), ref err);
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

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;

            txbMaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            txbMaPTT.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            dtpkNgLapHD.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            txbThueVAT.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            
        }
    }
}