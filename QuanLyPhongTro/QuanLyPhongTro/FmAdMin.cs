using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class FmAdMin : Form
    {
        public FmAdMin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDMQL_Click(object sender, EventArgs e)
        {
            pnDMQL.Show();
            pnTB.Hide();
            pnHĐ.Hide();
        }

        private void FmAdMin_Load(object sender, EventArgs e)
        {
            pnDMQL.Hide();
            pnTB.Hide();
            pnHĐ.Hide();
        }

        private void btnDMTB_Click(object sender, EventArgs e)
        {
            pnDMQL.Hide();
            pnTB.Show();
            pnHĐ.Hide();
            
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            FmKhachHang kh = new FmKhachHang();
            kh.ShowDialog();
        }

        private void btnQLPT_Click(object sender, EventArgs e)
        {
            FmPhongTro pt = new FmPhongTro();
            pt.ShowDialog();
        }

        private void btnQLPĐK_Click(object sender, EventArgs e)
        {
            FmPhieuDangKy dk = new FmPhieuDangKy();
            dk.ShowDialog();
        }

        private void btnQLPTT_Click(object sender, EventArgs e)
        {
            FmPhieuThanhToan ptt = new FmPhieuThanhToan();
            ptt.ShowDialog();
        }

        private void btnQLSDDV_Click(object sender, EventArgs e)
        {
            FmDangKyDichVu sd = new FmDangKyDichVu();
            sd.ShowDialog();
        }

        private void btnDMHĐ_Click(object sender, EventArgs e)
        {
            pnHĐ.Show();
            pnDMQL.Hide();
            pnTB.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnDMQL.Hide();
            pnHĐ.Hide();
            pnTB.Hide();
            if(sideMenu.Width == 52)
            {
                btnMenu.Location = new Point(196,6);
                sideMenu.Visible = false;
                sideMenu.Width = 228;
                PanelAnimator.ShowSync(sideMenu);
            }
            else
            {
                btnMenu.Location = new Point(12, 6);
                sideMenu.Visible = false;
                sideMenu.Width = 52;
                PanelAnimator.ShowSync(sideMenu);
            }
        }

        private void btnHĐ_Click(object sender, EventArgs e)
        {
            FmHoaDon hd = new FmHoaDon();
            hd.ShowDialog();
        }

        private void btnQLTB_Click(object sender, EventArgs e)
        {
            FmThietBi tb = new FmThietBi();
            tb.ShowDialog();
        }
    }
}
