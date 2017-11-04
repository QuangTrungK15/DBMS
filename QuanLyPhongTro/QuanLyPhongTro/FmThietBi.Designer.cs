namespace QuanLyPhongTro
{
    partial class FmThietBi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmThietBi));
            this.pnInfor = new System.Windows.Forms.Panel();
            this.txbTenTB = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaTB = new DevExpress.XtraEditors.TextEdit();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.pnbtn = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.pnInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.pnbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInfor
            // 
            this.pnInfor.Controls.Add(this.txbTenTB);
            this.pnInfor.Controls.Add(this.label2);
            this.pnInfor.Controls.Add(this.label1);
            this.pnInfor.Controls.Add(this.txbMaTB);
            this.pnInfor.Location = new System.Drawing.Point(1, 2);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(373, 95);
            this.pnInfor.TabIndex = 7;
            // 
            // txbTenTB
            // 
            this.txbTenTB.Location = new System.Drawing.Point(207, 39);
            this.txbTenTB.Name = "txbTenTB";
            this.txbTenTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTB.Properties.Appearance.Options.UseFont = true;
            this.txbTenTB.Size = new System.Drawing.Size(144, 28);
            this.txbTenTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thiết bị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thiết bị:";
            // 
            // txbMaTB
            // 
            this.txbMaTB.Location = new System.Drawing.Point(3, 39);
            this.txbMaTB.Name = "txbMaTB";
            this.txbMaTB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaTB.Properties.Appearance.Options.UseFont = true;
            this.txbMaTB.Size = new System.Drawing.Size(132, 28);
            this.txbMaTB.TabIndex = 1;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(1, 99);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.Size = new System.Drawing.Size(485, 153);
            this.dgvDichVu.TabIndex = 20;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // pnbtn
            // 
            this.pnbtn.Controls.Add(this.btnXoa);
            this.pnbtn.Controls.Add(this.btnSua);
            this.pnbtn.Controls.Add(this.btnThem);
            this.pnbtn.Location = new System.Drawing.Point(1, 258);
            this.pnbtn.Name = "pnbtn";
            this.pnbtn.Size = new System.Drawing.Size(485, 64);
            this.pnbtn.TabIndex = 21;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(366, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(190, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(21, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(380, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 34);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(380, 59);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 34);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 323);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.pnbtn);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.pnInfor);
            this.Name = "FmThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmThietBi";
            this.Load += new System.EventHandler(this.FmThietBi_Load);
            this.pnInfor.ResumeLayout(false);
            this.pnInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.pnbtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInfor;
        private DevExpress.XtraEditors.TextEdit txbTenTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txbMaTB;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel pnbtn;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}