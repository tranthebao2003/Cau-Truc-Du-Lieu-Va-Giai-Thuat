namespace doAn
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.btnNhapLop = new System.Windows.Forms.Button();
            this.lblPhanMem = new System.Windows.Forms.Label();
            this.btnNhapSv = new System.Windows.Forms.Button();
            this.btnNhapMon = new System.Windows.Forms.Button();
            this.btnInDiemTK = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnInDiemTB = new System.Windows.Forms.Button();
            this.btnInDiem = new System.Windows.Forms.Button();
            this.grbLop = new System.Windows.Forms.GroupBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.btnInLop = new System.Windows.Forms.Button();
            this.grbSinhVien = new System.Windows.Forms.GroupBox();
            this.grbMonHoc = new System.Windows.Forms.GroupBox();
            this.grbDiemSo = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnSuaSv = new System.Windows.Forms.Button();
            this.btnXoaSv = new System.Windows.Forms.Button();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.clnMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSodt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbDssv = new System.Windows.Forms.GroupBox();
            this.grbDsLop = new System.Windows.Forms.GroupBox();
            this.lvLop = new System.Windows.Forms.ListView();
            this.clnMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNamNhapHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.grbDsMon = new System.Windows.Forms.GroupBox();
            this.lvDsMon = new System.Windows.Forms.ListView();
            this.clnMaMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTenMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSTCLT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSTCTH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.grbLop.SuspendLayout();
            this.grbSinhVien.SuspendLayout();
            this.grbMonHoc.SuspendLayout();
            this.grbDiemSo.SuspendLayout();
            this.grbDssv.SuspendLayout();
            this.grbDsLop.SuspendLayout();
            this.grbDsMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNhapLop
            // 
            this.btnNhapLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNhapLop.Location = new System.Drawing.Point(39, 39);
            this.btnNhapLop.Margin = new System.Windows.Forms.Padding(5);
            this.btnNhapLop.Name = "btnNhapLop";
            this.btnNhapLop.Size = new System.Drawing.Size(281, 43);
            this.btnNhapLop.TabIndex = 1;
            this.btnNhapLop.Text = "Nhập lớp";
            this.btnNhapLop.UseVisualStyleBackColor = true;
            this.btnNhapLop.Click += new System.EventHandler(this.btnNhapLop_Click);
            // 
            // lblPhanMem
            // 
            this.lblPhanMem.AutoSize = true;
            this.lblPhanMem.BackColor = System.Drawing.Color.Transparent;
            this.lblPhanMem.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.lblPhanMem.Location = new System.Drawing.Point(23, 19);
            this.lblPhanMem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhanMem.Name = "lblPhanMem";
            this.lblPhanMem.Size = new System.Drawing.Size(815, 55);
            this.lblPhanMem.TabIndex = 2;
            this.lblPhanMem.Text = "Phần Mềm Quản Lí Điểm Sinh Viên ";
            // 
            // btnNhapSv
            // 
            this.btnNhapSv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNhapSv.Location = new System.Drawing.Point(39, 37);
            this.btnNhapSv.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapSv.Name = "btnNhapSv";
            this.btnNhapSv.Size = new System.Drawing.Size(281, 43);
            this.btnNhapSv.TabIndex = 5;
            this.btnNhapSv.Text = "Nhập sinh viên";
            this.btnNhapSv.UseVisualStyleBackColor = true;
            this.btnNhapSv.Click += new System.EventHandler(this.btnNhapSv_Click);
            // 
            // btnNhapMon
            // 
            this.btnNhapMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNhapMon.Location = new System.Drawing.Point(37, 37);
            this.btnNhapMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapMon.Name = "btnNhapMon";
            this.btnNhapMon.Size = new System.Drawing.Size(281, 43);
            this.btnNhapMon.TabIndex = 7;
            this.btnNhapMon.Text = "Nhập môn học";
            this.btnNhapMon.UseVisualStyleBackColor = true;
            this.btnNhapMon.Click += new System.EventHandler(this.btnNhapMon_Click);
            // 
            // btnInDiemTK
            // 
            this.btnInDiemTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInDiemTK.Location = new System.Drawing.Point(1160, 42);
            this.btnInDiemTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnInDiemTK.Name = "btnInDiemTK";
            this.btnInDiemTK.Size = new System.Drawing.Size(281, 43);
            this.btnInDiemTK.TabIndex = 9;
            this.btnInDiemTK.Text = "In bảng điểm tổng kết";
            this.btnInDiemTK.UseVisualStyleBackColor = true;
            this.btnInDiemTK.Click += new System.EventHandler(this.btnInDiemTK_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNhapDiem.Location = new System.Drawing.Point(35, 42);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(281, 43);
            this.btnNhapDiem.TabIndex = 11;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnInDiemTB
            // 
            this.btnInDiemTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInDiemTB.Location = new System.Drawing.Point(785, 42);
            this.btnInDiemTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnInDiemTB.Name = "btnInDiemTB";
            this.btnInDiemTB.Size = new System.Drawing.Size(281, 43);
            this.btnInDiemTB.TabIndex = 12;
            this.btnInDiemTB.Text = "In điểm trung bình";
            this.btnInDiemTB.UseVisualStyleBackColor = true;
            this.btnInDiemTB.Visible = false;
            this.btnInDiemTB.Click += new System.EventHandler(this.btnInDiemTB_Click);
            // 
            // btnInDiem
            // 
            this.btnInDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInDiem.Location = new System.Drawing.Point(410, 42);
            this.btnInDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnInDiem.Name = "btnInDiem";
            this.btnInDiem.Size = new System.Drawing.Size(281, 43);
            this.btnInDiem.TabIndex = 13;
            this.btnInDiem.Text = "In bảng điểm";
            this.btnInDiem.UseVisualStyleBackColor = true;
            this.btnInDiem.Visible = false;
            this.btnInDiem.Click += new System.EventHandler(this.btnInDiem_Click);
            // 
            // grbLop
            // 
            this.grbLop.BackColor = System.Drawing.Color.Transparent;
            this.grbLop.Controls.Add(this.txtNamHoc);
            this.grbLop.Controls.Add(this.btnInLop);
            this.grbLop.Controls.Add(this.btnNhapLop);
            this.grbLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grbLop.Location = new System.Drawing.Point(33, 493);
            this.grbLop.Margin = new System.Windows.Forms.Padding(4);
            this.grbLop.Name = "grbLop";
            this.grbLop.Padding = new System.Windows.Forms.Padding(4);
            this.grbLop.Size = new System.Drawing.Size(349, 145);
            this.grbLop.TabIndex = 14;
            this.grbLop.TabStop = false;
            this.grbLop.Text = "Lớp";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.Location = new System.Drawing.Point(247, 94);
            this.txtNamHoc.Multiline = true;
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(73, 34);
            this.txtNamHoc.TabIndex = 3;
            this.txtNamHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInLop
            // 
            this.btnInLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInLop.Location = new System.Drawing.Point(39, 94);
            this.btnInLop.Margin = new System.Windows.Forms.Padding(5);
            this.btnInLop.Name = "btnInLop";
            this.btnInLop.Size = new System.Drawing.Size(200, 34);
            this.btnInLop.TabIndex = 2;
            this.btnInLop.Text = "In lớp theo năm";
            this.btnInLop.UseVisualStyleBackColor = true;
            this.btnInLop.Click += new System.EventHandler(this.btnInLop_Click);
            // 
            // grbSinhVien
            // 
            this.grbSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.grbSinhVien.Controls.Add(this.btnNhapSv);
            this.grbSinhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grbSinhVien.Location = new System.Drawing.Point(561, 493);
            this.grbSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.grbSinhVien.Name = "grbSinhVien";
            this.grbSinhVien.Padding = new System.Windows.Forms.Padding(4);
            this.grbSinhVien.Size = new System.Drawing.Size(349, 96);
            this.grbSinhVien.TabIndex = 15;
            this.grbSinhVien.TabStop = false;
            this.grbSinhVien.Text = "Sinh viên";
            // 
            // grbMonHoc
            // 
            this.grbMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.grbMonHoc.Controls.Add(this.btnNhapMon);
            this.grbMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grbMonHoc.Location = new System.Drawing.Point(1158, 493);
            this.grbMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.grbMonHoc.Name = "grbMonHoc";
            this.grbMonHoc.Padding = new System.Windows.Forms.Padding(4);
            this.grbMonHoc.Size = new System.Drawing.Size(349, 96);
            this.grbMonHoc.TabIndex = 16;
            this.grbMonHoc.TabStop = false;
            this.grbMonHoc.Text = "Môn học";
            // 
            // grbDiemSo
            // 
            this.grbDiemSo.BackColor = System.Drawing.Color.Transparent;
            this.grbDiemSo.Controls.Add(this.btnNhapDiem);
            this.grbDiemSo.Controls.Add(this.btnInDiem);
            this.grbDiemSo.Controls.Add(this.btnInDiemTK);
            this.grbDiemSo.Controls.Add(this.btnInDiemTB);
            this.grbDiemSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grbDiemSo.Location = new System.Drawing.Point(33, 655);
            this.grbDiemSo.Margin = new System.Windows.Forms.Padding(4);
            this.grbDiemSo.Name = "grbDiemSo";
            this.grbDiemSo.Padding = new System.Windows.Forms.Padding(4);
            this.grbDiemSo.Size = new System.Drawing.Size(1476, 118);
            this.grbDiemSo.TabIndex = 17;
            this.grbDiemSo.TabStop = false;
            this.grbDiemSo.Text = "Điểm số";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnthoat.FlatAppearance.BorderSize = 0;
            this.btnthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.ForeColor = System.Drawing.Color.DimGray;
            this.btnthoat.Location = new System.Drawing.Point(1376, 785);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(133, 34);
            this.btnthoat.TabIndex = 21;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnSuaSv
            // 
            this.btnSuaSv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSuaSv.Location = new System.Drawing.Point(72, 333);
            this.btnSuaSv.Name = "btnSuaSv";
            this.btnSuaSv.Size = new System.Drawing.Size(90, 36);
            this.btnSuaSv.TabIndex = 25;
            this.btnSuaSv.Text = "Sửa";
            this.btnSuaSv.UseVisualStyleBackColor = true;
            this.btnSuaSv.Click += new System.EventHandler(this.btnSuaSv_Click);
            // 
            // btnXoaSv
            // 
            this.btnXoaSv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoaSv.Location = new System.Drawing.Point(440, 333);
            this.btnXoaSv.Name = "btnXoaSv";
            this.btnXoaSv.Size = new System.Drawing.Size(90, 36);
            this.btnXoaSv.TabIndex = 26;
            this.btnXoaSv.Text = "Xóa";
            this.btnXoaSv.UseVisualStyleBackColor = true;
            this.btnXoaSv.Click += new System.EventHandler(this.btnXoaSv_Click);
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaSV,
            this.clnHo,
            this.clnTen,
            this.clnGioiTinh,
            this.clnSodt});
            this.lvSinhVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvSinhVien.Location = new System.Drawing.Point(0, 41);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(610, 254);
            this.lvSinhVien.TabIndex = 23;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // clnMaSV
            // 
            this.clnMaSV.Text = "Mã sinh viên";
            this.clnMaSV.Width = 140;
            // 
            // clnHo
            // 
            this.clnHo.Text = "Họ";
            this.clnHo.Width = 140;
            // 
            // clnTen
            // 
            this.clnTen.Text = "Tên";
            this.clnTen.Width = 80;
            // 
            // clnGioiTinh
            // 
            this.clnGioiTinh.Text = "Giới tính";
            this.clnGioiTinh.Width = 100;
            // 
            // clnSodt
            // 
            this.clnSodt.Text = "Số điện thoại";
            this.clnSodt.Width = 160;
            // 
            // grbDssv
            // 
            this.grbDssv.BackColor = System.Drawing.Color.Transparent;
            this.grbDssv.Controls.Add(this.lvSinhVien);
            this.grbDssv.Controls.Add(this.btnXoaSv);
            this.grbDssv.Controls.Add(this.btnSuaSv);
            this.grbDssv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.grbDssv.Location = new System.Drawing.Point(430, 97);
            this.grbDssv.Name = "grbDssv";
            this.grbDssv.Size = new System.Drawing.Size(610, 380);
            this.grbDssv.TabIndex = 27;
            this.grbDssv.TabStop = false;
            this.grbDssv.Text = "Danh sách sinh viên";
            // 
            // grbDsLop
            // 
            this.grbDsLop.BackColor = System.Drawing.Color.Transparent;
            this.grbDsLop.Controls.Add(this.lvLop);
            this.grbDsLop.Controls.Add(this.btnXoaLop);
            this.grbDsLop.Controls.Add(this.btnSuaLop);
            this.grbDsLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.grbDsLop.Location = new System.Drawing.Point(33, 97);
            this.grbDsLop.Name = "grbDsLop";
            this.grbDsLop.Size = new System.Drawing.Size(391, 380);
            this.grbDsLop.TabIndex = 28;
            this.grbDsLop.TabStop = false;
            this.grbDsLop.Text = "Danh sách Lớp";
            // 
            // lvLop
            // 
            this.lvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaLop,
            this.clnTenLop,
            this.clnNamNhapHoc});
            this.lvLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLop.FullRowSelect = true;
            this.lvLop.GridLines = true;
            this.lvLop.HideSelection = false;
            this.lvLop.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvLop.Location = new System.Drawing.Point(0, 41);
            this.lvLop.Name = "lvLop";
            this.lvLop.Size = new System.Drawing.Size(391, 254);
            this.lvLop.TabIndex = 23;
            this.lvLop.UseCompatibleStateImageBehavior = false;
            this.lvLop.View = System.Windows.Forms.View.Details;
            this.lvLop.DoubleClick += new System.EventHandler(this.lvLop_DoubleClick);
            // 
            // clnMaLop
            // 
            this.clnMaLop.Text = "Mã lớp";
            this.clnMaLop.Width = 130;
            // 
            // clnTenLop
            // 
            this.clnTenLop.Text = "Tên lớp";
            this.clnTenLop.Width = 170;
            // 
            // clnNamNhapHoc
            // 
            this.clnNamNhapHoc.Text = "Năm học";
            this.clnNamNhapHoc.Width = 100;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoaLop.Location = new System.Drawing.Point(270, 333);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(90, 36);
            this.btnXoaLop.TabIndex = 26;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSuaLop.Location = new System.Drawing.Point(35, 333);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(90, 36);
            this.btnSuaLop.TabIndex = 25;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // grbDsMon
            // 
            this.grbDsMon.BackColor = System.Drawing.Color.Transparent;
            this.grbDsMon.Controls.Add(this.lvDsMon);
            this.grbDsMon.Controls.Add(this.btnXoaMon);
            this.grbDsMon.Controls.Add(this.btnSuaMon);
            this.grbDsMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.grbDsMon.Location = new System.Drawing.Point(1046, 97);
            this.grbDsMon.Name = "grbDsMon";
            this.grbDsMon.Size = new System.Drawing.Size(461, 380);
            this.grbDsMon.TabIndex = 28;
            this.grbDsMon.TabStop = false;
            this.grbDsMon.Text = "Danh sách môn";
            // 
            // lvDsMon
            // 
            this.lvDsMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaMonHoc,
            this.clnTenMonHoc,
            this.clnSTCLT,
            this.clnSTCTH});
            this.lvDsMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDsMon.FullRowSelect = true;
            this.lvDsMon.GridLines = true;
            this.lvDsMon.HideSelection = false;
            this.lvDsMon.Location = new System.Drawing.Point(0, 41);
            this.lvDsMon.Name = "lvDsMon";
            this.lvDsMon.Size = new System.Drawing.Size(463, 254);
            this.lvDsMon.TabIndex = 23;
            this.lvDsMon.UseCompatibleStateImageBehavior = false;
            this.lvDsMon.View = System.Windows.Forms.View.Details;
            // 
            // clnMaMonHoc
            // 
            this.clnMaMonHoc.Text = "Mã môn học";
            this.clnMaMonHoc.Width = 120;
            // 
            // clnTenMonHoc
            // 
            this.clnTenMonHoc.Text = "Tên môn học";
            this.clnTenMonHoc.Width = 180;
            // 
            // clnSTCLT
            // 
            this.clnSTCLT.Text = "STCLT";
            this.clnSTCLT.Width = 70;
            // 
            // clnSTCTH
            // 
            this.clnSTCTH.Text = "STCTH";
            this.clnSTCTH.Width = 90;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoaMon.Location = new System.Drawing.Point(312, 333);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(90, 36);
            this.btnXoaMon.TabIndex = 26;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSuaMon.Location = new System.Drawing.Point(65, 333);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(90, 36);
            this.btnSuaMon.TabIndex = 25;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = true;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.grbDsMon);
            this.Controls.Add(this.grbDssv);
            this.Controls.Add(this.grbDsLop);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbDiemSo);
            this.Controls.Add(this.lblPhanMem);
            this.Controls.Add(this.grbSinhVien);
            this.Controls.Add(this.grbLop);
            this.Controls.Add(this.grbMonHoc);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbLop.ResumeLayout(false);
            this.grbLop.PerformLayout();
            this.grbSinhVien.ResumeLayout(false);
            this.grbMonHoc.ResumeLayout(false);
            this.grbDiemSo.ResumeLayout(false);
            this.grbDssv.ResumeLayout(false);
            this.grbDsLop.ResumeLayout(false);
            this.grbDsMon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapLop;
        private System.Windows.Forms.Label lblPhanMem;
        private System.Windows.Forms.Button btnNhapSv;
        private System.Windows.Forms.Button btnNhapMon;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.GroupBox grbLop;
        private System.Windows.Forms.GroupBox grbSinhVien;
        private System.Windows.Forms.GroupBox grbMonHoc;
        private System.Windows.Forms.GroupBox grbDiemSo;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox grbDssv;
        public System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader clnMaSV;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnGioiTinh;
        private System.Windows.Forms.ColumnHeader clnSodt;
        private System.Windows.Forms.Button btnXoaSv;
        private System.Windows.Forms.Button btnSuaSv;
        private System.Windows.Forms.GroupBox grbDsLop;
        public System.Windows.Forms.ListView lvLop;
        private System.Windows.Forms.ColumnHeader clnMaLop;
        private System.Windows.Forms.ColumnHeader clnTenLop;
        private System.Windows.Forms.ColumnHeader clnNamNhapHoc;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.GroupBox grbDsMon;
        public System.Windows.Forms.ListView lvDsMon;
        private System.Windows.Forms.ColumnHeader clnMaMonHoc;
        private System.Windows.Forms.ColumnHeader clnTenMonHoc;
        private System.Windows.Forms.ColumnHeader clnSTCLT;
        private System.Windows.Forms.ColumnHeader clnSTCTH;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnInLop;
        public System.Windows.Forms.TextBox txtNamHoc;
        public System.Windows.Forms.Button btnInDiemTK;
        public System.Windows.Forms.Button btnInDiemTB;
        public System.Windows.Forms.Button btnInDiem;
    }
}

