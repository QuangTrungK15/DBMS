namespace QuanLyPhongTro
{
    partial class FmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDichVu));
            this.pnInfor = new System.Windows.Forms.Panel();
            this.VNĐ = new System.Windows.Forms.Label();
            this.txbGiaDV = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenDV = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaDV = new DevExpress.XtraEditors.TextEdit();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.pnbtn = new System.Windows.Forms.Panel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.pnInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbGiaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.pnbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInfor
            // 
            this.pnInfor.Controls.Add(this.VNĐ);
            this.pnInfor.Controls.Add(this.txbGiaDV);
            this.pnInfor.Controls.Add(this.label4);
            this.pnInfor.Controls.Add(this.txbTenDV);
            this.pnInfor.Controls.Add(this.label2);
            this.pnInfor.Controls.Add(this.label1);
            this.pnInfor.Controls.Add(this.txbMaDV);
            this.pnInfor.Location = new System.Drawing.Point(0, 0);
            this.pnInfor.Name = "pnInfor";
            this.pnInfor.Size = new System.Drawing.Size(525, 95);
            this.pnInfor.TabIndex = 6;
            // 
            // VNĐ
            // 
            this.VNĐ.AutoSize = true;
            this.VNĐ.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VNĐ.Location = new System.Drawing.Point(471, 42);
            this.VNĐ.Name = "VNĐ";
            this.VNĐ.Size = new System.Drawing.Size(43, 21);
            this.VNĐ.TabIndex = 16;
            this.VNĐ.Text = "VNĐ";
            // 
            // txbGiaDV
            // 
            this.txbGiaDV.Location = new System.Drawing.Point(338, 39);
            this.txbGiaDV.Name = "txbGiaDV";
            this.txbGiaDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGiaDV.Properties.Appearance.Options.UseFont = true;
            this.txbGiaDV.Size = new System.Drawing.Size(127, 28);
            this.txbGiaDV.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gía dịch vụ:";
            // 
            // txbTenDV
            // 
            this.txbTenDV.Location = new System.Drawing.Point(170, 39);
            this.txbTenDV.Name = "txbTenDV";
            this.txbTenDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDV.Properties.Appearance.Options.UseFont = true;
            this.txbTenDV.Size = new System.Drawing.Size(144, 28);
            this.txbTenDV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ:";
            // 
            // txbMaDV
            // 
            this.txbMaDV.Location = new System.Drawing.Point(3, 39);
            this.txbMaDV.Name = "txbMaDV";
            this.txbMaDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaDV.Properties.Appearance.Options.UseFont = true;
            this.txbMaDV.Size = new System.Drawing.Size(132, 28);
            this.txbMaDV.TabIndex = 1;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(3, 101);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.Size = new System.Drawing.Size(522, 192);
            this.dgvDichVu.TabIndex = 19;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // pnbtn
            // 
            this.pnbtn.Controls.Add(this.btnLuu);
            this.pnbtn.Controls.Add(this.btnHuy);
            this.pnbtn.Controls.Add(this.btnXoa);
            this.pnbtn.Controls.Add(this.btnSua);
            this.pnbtn.Controls.Add(this.btnThem);
            this.pnbtn.Location = new System.Drawing.Point(0, 298);
            this.pnbtn.Name = "pnbtn";
            this.pnbtn.Size = new System.Drawing.Size(525, 64);
            this.pnbtn.TabIndex = 20;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(312, 13);
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
            this.btnHuy.Location = new System.Drawing.Point(416, 13);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 34);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(208, 13);
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
            this.btnSua.Location = new System.Drawing.Point(104, 13);
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
            this.btnThem.Location = new System.Drawing.Point(3, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 365);
            this.Controls.Add(this.pnbtn);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.pnInfor);
            this.Name = "FmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmDichVu";
            this.Load += new System.EventHandler(this.FmDichVu_Load);
            this.pnInfor.ResumeLayout(false);
            this.pnInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbGiaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.pnbtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInfor;
        private DevExpress.XtraEditors.TextEdit txbGiaDV;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txbTenDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txbMaDV;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel pnbtn;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label VNĐ;
    }
}