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
    public partial class FmThietBi : DevExpress.XtraEditors.XtraForm
    {
        public FmThietBi()
        {
            InitializeComponent();
        }


        BLThietBi dbtb = new BLThietBi();
        DataTable dttb = new DataTable();
        bool them = false;
        string err;
        void LoadData()
        {
            try
            {
                txbMaTB.ResetText();
                txbTenTB.ResetText();
                pnInfor.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;



                System.Data.DataSet ds = dbtb.LayThietBi();
                dttb = ds.Tables[0];
                dgvDichVu.DataSource = dttb;
                dgvDichVu.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu !!!!");
            }
        }

        private void FmThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDichVu.CurrentCell.RowIndex;
            txbMaTB.Text = dgvDichVu.Rows[r].Cells[0].Value.ToString();
            txbTenTB.Text = dgvDichVu.Rows[r].Cells[1].Value.ToString();
   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            them = true;
            pnInfor.Enabled = true;
            txbTenTB.ResetText();
            txbMaTB.ResetText();
            txbMaTB.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnInfor.Enabled = true;
            txbMaTB.Focus();

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

                string strMaTB = dgvDichVu.Rows[r].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    dbtb.XoaThietBi(ref err, strMaTB);
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
                    BLThietBi bttb = new BLThietBi();
                    bttb.ThemThietBi(this.txbMaTB.Text, this.txbTenTB.Text, ref err);
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
                    BLThietBi bttb = new BLThietBi();
                    bttb.CapNhapThietBi(this.txbMaTB.Text, this.txbTenTB.Text, ref err);
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