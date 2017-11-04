namespace QuanLyPhongTro
{
    partial class FmAdMin
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAdMin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDMHĐ = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDMTB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDMQL = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnDMQL = new System.Windows.Forms.Panel();
            this.btnQLPTT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLSDDV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLPĐK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLPT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLKH = new Bunifu.Framework.UI.BunifuFlatButton();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.pnTB = new System.Windows.Forms.Panel();
            this.btnQLTB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnHĐ = new System.Windows.Forms.Panel();
            this.btnHĐ = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.pnDMQL.SuspendLayout();
            this.pnTB.SuspendLayout();
            this.pnHĐ.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.sideMenu.Controls.Add(this.btnMenu);
            this.sideMenu.Controls.Add(this.btnDMHĐ);
            this.sideMenu.Controls.Add(this.btnDMTB);
            this.sideMenu.Controls.Add(this.btnDMQL);
            this.PanelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 53);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(228, 456);
            this.sideMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(196, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 34);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDMHĐ
            // 
            this.btnDMHĐ.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.btnDMHĐ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMHĐ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDMHĐ.BorderRadius = 0;
            this.btnDMHĐ.ButtonText = "   Danh mục hóa đơn";
            this.btnDMHĐ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnDMHĐ, BunifuAnimatorNS.DecorationType.None);
            this.btnDMHĐ.DisabledColor = System.Drawing.Color.Gray;
            this.btnDMHĐ.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDMHĐ.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDMHĐ.Iconimage")));
            this.btnDMHĐ.Iconimage_right = null;
            this.btnDMHĐ.Iconimage_right_Selected = null;
            this.btnDMHĐ.Iconimage_Selected = null;
            this.btnDMHĐ.IconMarginLeft = 0;
            this.btnDMHĐ.IconMarginRight = 0;
            this.btnDMHĐ.IconRightVisible = true;
            this.btnDMHĐ.IconRightZoom = 0D;
            this.btnDMHĐ.IconVisible = true;
            this.btnDMHĐ.IconZoom = 60D;
            this.btnDMHĐ.IsTab = true;
            this.btnDMHĐ.Location = new System.Drawing.Point(0, 190);
            this.btnDMHĐ.Name = "btnDMHĐ";
            this.btnDMHĐ.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMHĐ.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMHĐ.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.btnDMHĐ.selected = false;
            this.btnDMHĐ.Size = new System.Drawing.Size(226, 48);
            this.btnDMHĐ.TabIndex = 2;
            this.btnDMHĐ.Text = "   Danh mục hóa đơn";
            this.btnDMHĐ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMHĐ.Textcolor = System.Drawing.Color.Gainsboro;
            this.btnDMHĐ.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMHĐ.Click += new System.EventHandler(this.btnDMHĐ_Click);
            // 
            // btnDMTB
            // 
            this.btnDMTB.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.btnDMTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDMTB.BorderRadius = 0;
            this.btnDMTB.ButtonText = "   Danh mục thiết bị";
            this.btnDMTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnDMTB, BunifuAnimatorNS.DecorationType.None);
            this.btnDMTB.DisabledColor = System.Drawing.Color.Gray;
            this.btnDMTB.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDMTB.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDMTB.Iconimage")));
            this.btnDMTB.Iconimage_right = null;
            this.btnDMTB.Iconimage_right_Selected = null;
            this.btnDMTB.Iconimage_Selected = null;
            this.btnDMTB.IconMarginLeft = 0;
            this.btnDMTB.IconMarginRight = 0;
            this.btnDMTB.IconRightVisible = true;
            this.btnDMTB.IconRightZoom = 0D;
            this.btnDMTB.IconVisible = true;
            this.btnDMTB.IconZoom = 60D;
            this.btnDMTB.IsTab = true;
            this.btnDMTB.Location = new System.Drawing.Point(0, 139);
            this.btnDMTB.Name = "btnDMTB";
            this.btnDMTB.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMTB.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMTB.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.btnDMTB.selected = false;
            this.btnDMTB.Size = new System.Drawing.Size(226, 48);
            this.btnDMTB.TabIndex = 1;
            this.btnDMTB.Text = "   Danh mục thiết bị";
            this.btnDMTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMTB.Textcolor = System.Drawing.Color.Gainsboro;
            this.btnDMTB.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMTB.Click += new System.EventHandler(this.btnDMTB_Click);
            // 
            // btnDMQL
            // 
            this.btnDMQL.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.btnDMQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDMQL.BorderRadius = 0;
            this.btnDMQL.ButtonText = "   Danh mục quản lý";
            this.btnDMQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnDMQL, BunifuAnimatorNS.DecorationType.None);
            this.btnDMQL.DisabledColor = System.Drawing.Color.Gray;
            this.btnDMQL.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDMQL.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDMQL.Iconimage")));
            this.btnDMQL.Iconimage_right = null;
            this.btnDMQL.Iconimage_right_Selected = null;
            this.btnDMQL.Iconimage_Selected = null;
            this.btnDMQL.IconMarginLeft = 0;
            this.btnDMQL.IconMarginRight = 0;
            this.btnDMQL.IconRightVisible = true;
            this.btnDMQL.IconRightZoom = 0D;
            this.btnDMQL.IconVisible = true;
            this.btnDMQL.IconZoom = 60D;
            this.btnDMQL.IsTab = true;
            this.btnDMQL.Location = new System.Drawing.Point(0, 85);
            this.btnDMQL.Name = "btnDMQL";
            this.btnDMQL.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMQL.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btnDMQL.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.btnDMQL.selected = false;
            this.btnDMQL.Size = new System.Drawing.Size(226, 48);
            this.btnDMQL.TabIndex = 0;
            this.btnDMQL.Text = "   Danh mục quản lý";
            this.btnDMQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMQL.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnDMQL.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMQL.Click += new System.EventHandler(this.btnDMQL_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 53);
            this.panel2.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(249, 33);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Quản lý phòng trọ";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(211)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(673, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnDMQL
            // 
            this.pnDMQL.Controls.Add(this.btnQLPTT);
            this.pnDMQL.Controls.Add(this.btnQLSDDV);
            this.pnDMQL.Controls.Add(this.btnQLPĐK);
            this.pnDMQL.Controls.Add(this.btnQLPT);
            this.pnDMQL.Controls.Add(this.btnQLKH);
            this.PanelAnimator.SetDecoration(this.pnDMQL, BunifuAnimatorNS.DecorationType.None);
            this.pnDMQL.Location = new System.Drawing.Point(301, 122);
            this.pnDMQL.Name = "pnDMQL";
            this.pnDMQL.Size = new System.Drawing.Size(362, 375);
            this.pnDMQL.TabIndex = 2;
            // 
            // btnQLPTT
            // 
            this.btnQLPTT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLPTT.BorderRadius = 0;
            this.btnQLPTT.ButtonText = "Quản lý phiếu thanh toán";
            this.btnQLPTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnQLPTT, BunifuAnimatorNS.DecorationType.None);
            this.btnQLPTT.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLPTT.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLPTT.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLPTT.Iconimage")));
            this.btnQLPTT.Iconimage_right = null;
            this.btnQLPTT.Iconimage_right_Selected = null;
            this.btnQLPTT.Iconimage_Selected = null;
            this.btnQLPTT.IconMarginLeft = 0;
            this.btnQLPTT.IconMarginRight = 0;
            this.btnQLPTT.IconRightVisible = true;
            this.btnQLPTT.IconRightZoom = 0D;
            this.btnQLPTT.IconVisible = true;
            this.btnQLPTT.IconZoom = 90D;
            this.btnQLPTT.IsTab = false;
            this.btnQLPTT.Location = new System.Drawing.Point(49, 178);
            this.btnQLPTT.Name = "btnQLPTT";
            this.btnQLPTT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPTT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLPTT.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLPTT.selected = false;
            this.btnQLPTT.Size = new System.Drawing.Size(241, 48);
            this.btnQLPTT.TabIndex = 3;
            this.btnQLPTT.Text = "Quản lý phiếu thanh toán";
            this.btnQLPTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPTT.Textcolor = System.Drawing.Color.White;
            this.btnQLPTT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPTT.Click += new System.EventHandler(this.btnQLPTT_Click);
            // 
            // btnQLSDDV
            // 
            this.btnQLSDDV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLSDDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLSDDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLSDDV.BorderRadius = 0;
            this.btnQLSDDV.ButtonText = "Quản lý phiếu sử dụng dịch vụ ";
            this.btnQLSDDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnQLSDDV, BunifuAnimatorNS.DecorationType.None);
            this.btnQLSDDV.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLSDDV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLSDDV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLSDDV.Iconimage")));
            this.btnQLSDDV.Iconimage_right = null;
            this.btnQLSDDV.Iconimage_right_Selected = null;
            this.btnQLSDDV.Iconimage_Selected = null;
            this.btnQLSDDV.IconMarginLeft = 0;
            this.btnQLSDDV.IconMarginRight = 0;
            this.btnQLSDDV.IconRightVisible = true;
            this.btnQLSDDV.IconRightZoom = 0D;
            this.btnQLSDDV.IconVisible = true;
            this.btnQLSDDV.IconZoom = 90D;
            this.btnQLSDDV.IsTab = false;
            this.btnQLSDDV.Location = new System.Drawing.Point(49, 232);
            this.btnQLSDDV.Name = "btnQLSDDV";
            this.btnQLSDDV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLSDDV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLSDDV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLSDDV.selected = false;
            this.btnQLSDDV.Size = new System.Drawing.Size(241, 48);
            this.btnQLSDDV.TabIndex = 4;
            this.btnQLSDDV.Text = "Quản lý phiếu sử dụng dịch vụ ";
            this.btnQLSDDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSDDV.Textcolor = System.Drawing.Color.White;
            this.btnQLSDDV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSDDV.Click += new System.EventHandler(this.btnQLSDDV_Click);
            // 
            // btnQLPĐK
            // 
            this.btnQLPĐK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPĐK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPĐK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLPĐK.BorderRadius = 0;
            this.btnQLPĐK.ButtonText = "Quản lý phiếu đăng ký";
            this.btnQLPĐK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnQLPĐK, BunifuAnimatorNS.DecorationType.None);
            this.btnQLPĐK.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLPĐK.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLPĐK.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLPĐK.Iconimage")));
            this.btnQLPĐK.Iconimage_right = null;
            this.btnQLPĐK.Iconimage_right_Selected = null;
            this.btnQLPĐK.Iconimage_Selected = null;
            this.btnQLPĐK.IconMarginLeft = 0;
            this.btnQLPĐK.IconMarginRight = 0;
            this.btnQLPĐK.IconRightVisible = true;
            this.btnQLPĐK.IconRightZoom = 0D;
            this.btnQLPĐK.IconVisible = true;
            this.btnQLPĐK.IconZoom = 90D;
            this.btnQLPĐK.IsTab = false;
            this.btnQLPĐK.Location = new System.Drawing.Point(49, 124);
            this.btnQLPĐK.Name = "btnQLPĐK";
            this.btnQLPĐK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPĐK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLPĐK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLPĐK.selected = false;
            this.btnQLPĐK.Size = new System.Drawing.Size(241, 48);
            this.btnQLPĐK.TabIndex = 2;
            this.btnQLPĐK.Text = "Quản lý phiếu đăng ký";
            this.btnQLPĐK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPĐK.Textcolor = System.Drawing.Color.White;
            this.btnQLPĐK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPĐK.Click += new System.EventHandler(this.btnQLPĐK_Click);
            // 
            // btnQLPT
            // 
            this.btnQLPT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLPT.BorderRadius = 0;
            this.btnQLPT.ButtonText = "Quản lý phòng trọ";
            this.btnQLPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnQLPT, BunifuAnimatorNS.DecorationType.None);
            this.btnQLPT.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLPT.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLPT.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLPT.Iconimage")));
            this.btnQLPT.Iconimage_right = null;
            this.btnQLPT.Iconimage_right_Selected = null;
            this.btnQLPT.Iconimage_Selected = null;
            this.btnQLPT.IconMarginLeft = 0;
            this.btnQLPT.IconMarginRight = 0;
            this.btnQLPT.IconRightVisible = true;
            this.btnQLPT.IconRightZoom = 0D;
            this.btnQLPT.IconVisible = true;
            this.btnQLPT.IconZoom = 90D;
            this.btnQLPT.IsTab = false;
            this.btnQLPT.Location = new System.Drawing.Point(49, 70);
            this.btnQLPT.Name = "btnQLPT";
            this.btnQLPT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLPT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLPT.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLPT.selected = false;
            this.btnQLPT.Size = new System.Drawing.Size(241, 48);
            this.btnQLPT.TabIndex = 1;
            this.btnQLPT.Text = "Quản lý phòng trọ";
            this.btnQLPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPT.Textcolor = System.Drawing.Color.White;
            this.btnQLPT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPT.Click += new System.EventHandler(this.btnQLPT_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLKH.BorderRadius = 0;
            this.btnQLKH.ButtonText = "Quản lý khách hàng";
            this.btnQLKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnQLKH, BunifuAnimatorNS.DecorationType.None);
            this.btnQLKH.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLKH.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLKH.Iconimage = global::QuanLyPhongTro.Properties.Resources.Custommer;
            this.btnQLKH.Iconimage_right = null;
            this.btnQLKH.Iconimage_right_Selected = null;
            this.btnQLKH.Iconimage_Selected = null;
            this.btnQLKH.IconMarginLeft = 0;
            this.btnQLKH.IconMarginRight = 0;
            this.btnQLKH.IconRightVisible = true;
            this.btnQLKH.IconRightZoom = 0D;
            this.btnQLKH.IconVisible = true;
            this.btnQLKH.IconZoom = 90D;
            this.btnQLKH.IsTab = false;
            this.btnQLKH.Location = new System.Drawing.Point(49, 16);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLKH.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLKH.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLKH.selected = false;
            this.btnQLKH.Size = new System.Drawing.Size(241, 48);
            this.btnQLKH.TabIndex = 0;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Textcolor = System.Drawing.Color.White;
            this.btnQLKH.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Quản lý phòng trọ";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = global::QuanLyPhongTro.Properties.Resources.House;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản lý phòng trọ";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.LargeGlyph = global::QuanLyPhongTro.Properties.Resources.House;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // pnTB
            // 
            this.pnTB.Controls.Add(this.btnQLTB);
            this.PanelAnimator.SetDecoration(this.pnTB, BunifuAnimatorNS.DecorationType.None);
            this.pnTB.Location = new System.Drawing.Point(293, 189);
            this.pnTB.Name = "pnTB";
            this.pnTB.Size = new System.Drawing.Size(370, 210);
            this.pnTB.TabIndex = 3;
            // 
            // btnQLTB
            // 
            this.btnQLTB.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLTB.BorderRadius = 0;
            this.btnQLTB.ButtonText = "Quản lý thiết bị";
            this.btnQLTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnQLTB, BunifuAnimatorNS.DecorationType.None);
            this.btnQLTB.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLTB.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLTB.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLTB.Iconimage")));
            this.btnQLTB.Iconimage_right = null;
            this.btnQLTB.Iconimage_right_Selected = null;
            this.btnQLTB.Iconimage_Selected = null;
            this.btnQLTB.IconMarginLeft = 0;
            this.btnQLTB.IconMarginRight = 0;
            this.btnQLTB.IconRightVisible = true;
            this.btnQLTB.IconRightZoom = 0D;
            this.btnQLTB.IconVisible = true;
            this.btnQLTB.IconZoom = 90D;
            this.btnQLTB.IsTab = false;
            this.btnQLTB.Location = new System.Drawing.Point(57, 3);
            this.btnQLTB.Name = "btnQLTB";
            this.btnQLTB.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLTB.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLTB.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLTB.selected = false;
            this.btnQLTB.Size = new System.Drawing.Size(241, 48);
            this.btnQLTB.TabIndex = 5;
            this.btnQLTB.Text = "Quản lý thiết bị";
            this.btnQLTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTB.Textcolor = System.Drawing.Color.White;
            this.btnQLTB.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTB.Click += new System.EventHandler(this.btnQLTB_Click);
            // 
            // pnHĐ
            // 
            this.pnHĐ.Controls.Add(this.btnHĐ);
            this.PanelAnimator.SetDecoration(this.pnHĐ, BunifuAnimatorNS.DecorationType.None);
            this.pnHĐ.Location = new System.Drawing.Point(277, 243);
            this.pnHĐ.Name = "pnHĐ";
            this.pnHĐ.Size = new System.Drawing.Size(437, 94);
            this.pnHĐ.TabIndex = 4;
            // 
            // btnHĐ
            // 
            this.btnHĐ.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHĐ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHĐ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHĐ.BorderRadius = 0;
            this.btnHĐ.ButtonText = "Quản lý hóa đơn";
            this.btnHĐ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnHĐ, BunifuAnimatorNS.DecorationType.None);
            this.btnHĐ.DisabledColor = System.Drawing.Color.Gray;
            this.btnHĐ.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHĐ.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHĐ.Iconimage")));
            this.btnHĐ.Iconimage_right = null;
            this.btnHĐ.Iconimage_right_Selected = null;
            this.btnHĐ.Iconimage_Selected = null;
            this.btnHĐ.IconMarginLeft = 0;
            this.btnHĐ.IconMarginRight = 0;
            this.btnHĐ.IconRightVisible = true;
            this.btnHĐ.IconRightZoom = 0D;
            this.btnHĐ.IconVisible = true;
            this.btnHĐ.IconZoom = 90D;
            this.btnHĐ.IsTab = false;
            this.btnHĐ.Location = new System.Drawing.Point(73, 0);
            this.btnHĐ.Name = "btnHĐ";
            this.btnHĐ.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHĐ.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHĐ.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHĐ.selected = false;
            this.btnHĐ.Size = new System.Drawing.Size(241, 48);
            this.btnHĐ.TabIndex = 5;
            this.btnHĐ.Text = "Quản lý hóa đơn";
            this.btnHĐ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHĐ.Textcolor = System.Drawing.Color.White;
            this.btnHĐ.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHĐ.Click += new System.EventHandler(this.btnHĐ_Click);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 0.3F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // FmAdMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(714, 509);
            this.Controls.Add(this.pnHĐ);
            this.Controls.Add(this.pnTB);
            this.Controls.Add(this.pnDMQL);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.panel2);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAdMin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAdMin";
            this.Load += new System.EventHandler(this.FmAdMin_Load);
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.pnDMQL.ResumeLayout(false);
            this.pnTB.ResumeLayout(false);
            this.pnHĐ.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDMQL;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDMHĐ;
        private Bunifu.Framework.UI.BunifuFlatButton btnDMTB;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel pnDMQL;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLPĐK;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLPT;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLKH;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLSDDV;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLPTT;
        private System.Windows.Forms.Panel pnTB;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLTB;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Panel pnHĐ;
        private Bunifu.Framework.UI.BunifuFlatButton btnHĐ;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
    }
}