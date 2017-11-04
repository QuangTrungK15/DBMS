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
    public partial class FmPhongTro : DevExpress.XtraEditors.XtraForm
    {
        public FmPhongTro()
        {
            InitializeComponent();
        }

        BLPhongTro dbpt = new BLPhongTro();
        DataTable dtpt = new DataTable();
        bool them = false;
        string err;
        void LoadData()
        {
            try
            {
                txbMaPT.ResetText();
                txbTenPT.ResetText();
                txbHienTrang.ResetText();
                txbGiaPh.ResetText();
                txbSoLuongNg.ResetText();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                pnInfor.Enabled = false;

                System.Data.DataSet ds = dbpt.LayPhongTro();
                dtpt = ds.Tables[0];
                dgvPhongTro.DataSource = dtpt;
                dgvPhongTro.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu !!!!");
            }

        }

        private void FmPhongTro_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPhongTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhongTro.CurrentCell.RowIndex;
            txbMaPT.Text = dgvPhongTro.Rows[r].Cells[0].Value.ToString();
            txbTenPT.Text = dgvPhongTro.Rows[r].Cells[1].Value.ToString();
            if (dgvPhongTro.Rows[r].Cells[2].Value.ToString() == "True")
                txbHienTrang.Text = "Không";
            else
                txbHienTrang.Text = "Còn";
            txbGiaPh.Text = dgvPhongTro.Rows[r].Cells[3].Value.ToString();
            txbSoLuongNg.Text = dgvPhongTro.Rows[r].Cells[4].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            pnInfor.Enabled = true;
            txbMaPT.ResetText();
            txbTenPT.ResetText();
            txbHienTrang.ResetText();
            txbGiaPh.ResetText();
            txbSoLuongNg.ResetText();
            txbMaPT.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    int Htp = 0;
                    BLPhongTro btPT = new BLPhongTro();
                    if(this.txbHienTrang.Text.ToUpper() == "CÒN")
                        Htp = 1;
                    else
                        Htp = 0;
                    btPT.ThemPhongTro(this.txbMaPT.Text, this.txbTenPT.Text, Htp, this.txbGiaPh.Text, this.txbSoLuongNg.Text, ref err);
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
                    int Htp = 0;
                    BLPhongTro btKH = new BLPhongTro();
                    if (this.txbHienTrang.Text.ToUpper() == "CÒN")
                        Htp = 1;
                    else
                        Htp = 0;
                    btKH.CapNhatPhongTro(this.txbMaPT.Text, this.txbTenPT.Text, Htp, this.txbGiaPh.Text, this.txbSoLuongNg.Text, ref err);
                    LoadData();
                    MessageBox.Show("Đã sửa xong!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được hãy thử lại !!!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvPhongTro.CurrentCell.RowIndex;

                string strMaPT = dgvPhongTro.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbpt.XoaPhongTro(ref err, strMaPT);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!!!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được lỗi rồi!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            pnInfor.Enabled = true;

            txbMaPT.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}