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
    public partial class FmDichVu : DevExpress.XtraEditors.XtraForm
    {
        public FmDichVu()
        {
            InitializeComponent();
        }


        BLDichVu dbdv = new BLDichVu();
        DataTable dtdv = new DataTable();
        bool them = false;
        string err;
        void LoadData()
        {
            try
            {
                txbGiaDV.ResetText();
                txbMaDV.ResetText();
                txbTenDV.ResetText();
                pnInfor.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;



                System.Data.DataSet ds = dbdv.LayDichVu();
                dtdv = ds.Tables[0];
                dgvDichVu.DataSource = dtdv;
                dgvDichVu.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu !!!!");
            }
        }


        private void FmDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            pnInfor.Enabled = true;
            txbMaDV.ResetText();
            txbTenDV.ResetText();
            txbGiaDV.ResetText();
            txbMaDV.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnInfor.Enabled = true;
            txbMaDV.Focus();

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
                int r = dgvDichVu.CurrentCell.RowIndex;

                string strMaDV = dgvDichVu.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbdv.XoaDichVu(ref err, strMaDV);
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
                    BLDichVu btDV = new BLDichVu();
                    btDV.ThemDichVu(this.txbMaDV.Text, this.txbTenDV.Text, Int32.Parse(this.txbGiaDV.Text), ref err);
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
                    BLDichVu btDV = new BLDichVu();
                    btDV.CapNhatDichVu(this.txbMaDV.Text, this.txbTenDV.Text, Int32.Parse(this.txbGiaDV.Text), ref err);
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

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDichVu.CurrentCell.RowIndex;
            txbMaDV.Text = dgvDichVu.Rows[r].Cells[0].Value.ToString();
            txbTenDV.Text = dgvDichVu.Rows[r].Cells[1].Value.ToString();
            txbGiaDV.Text = dgvDichVu.Rows[r].Cells[2].Value.ToString();
        }
    }
}