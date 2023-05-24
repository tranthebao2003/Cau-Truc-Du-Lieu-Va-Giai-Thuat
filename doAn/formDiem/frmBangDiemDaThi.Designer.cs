namespace doAn.formDiem
{
    partial class frmBangDiemDaThi
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
            this.lvBangDiemDaThi = new System.Windows.Forms.ListView();
            this.clnMaSv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutpuMon = new System.Windows.Forms.Label();
            this.lblOutputLop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOutputLanThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvBangDiemDaThi
            // 
            this.lvBangDiemDaThi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvBangDiemDaThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaSv,
            this.clnHo,
            this.clnTen,
            this.clnDiem});
            this.lvBangDiemDaThi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBangDiemDaThi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBangDiemDaThi.FullRowSelect = true;
            this.lvBangDiemDaThi.GridLines = true;
            this.lvBangDiemDaThi.HideSelection = false;
            this.lvBangDiemDaThi.Location = new System.Drawing.Point(0, 166);
            this.lvBangDiemDaThi.MultiSelect = false;
            this.lvBangDiemDaThi.Name = "lvBangDiemDaThi";
            this.lvBangDiemDaThi.Size = new System.Drawing.Size(495, 242);
            this.lvBangDiemDaThi.TabIndex = 24;
            this.lvBangDiemDaThi.UseCompatibleStateImageBehavior = false;
            this.lvBangDiemDaThi.View = System.Windows.Forms.View.Details;
            // 
            // clnMaSv
            // 
            this.clnMaSv.Text = "Mã sinh viên";
            this.clnMaSv.Width = 140;
            // 
            // clnHo
            // 
            this.clnHo.Text = "Họ";
            this.clnHo.Width = 160;
            // 
            // clnTen
            // 
            this.clnTen.Text = "Tên";
            this.clnTen.Width = 90;
            // 
            // clnDiem
            // 
            this.clnDiem.Text = "Điểm";
            this.clnDiem.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "BẢNG ĐIỂM MÔN HỌC";
            // 
            // lblOutpuMon
            // 
            this.lblOutpuMon.AutoSize = true;
            this.lblOutpuMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutpuMon.Location = new System.Drawing.Point(96, 128);
            this.lblOutpuMon.Name = "lblOutpuMon";
            this.lblOutpuMon.Size = new System.Drawing.Size(171, 23);
            this.lblOutpuMon.TabIndex = 30;
            this.lblOutpuMon.Text = "Thiết kế hình động";
            // 
            // lblOutputLop
            // 
            this.lblOutputLop.AutoSize = true;
            this.lblOutputLop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLop.Location = new System.Drawing.Point(59, 96);
            this.lblOutputLop.Name = "lblOutputLop";
            this.lblOutputLop.Size = new System.Drawing.Size(243, 23);
            this.lblOutputLop.TabIndex = 31;
            this.lblOutputLop.Text = "Công nghệ đa phương tiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Lần Thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Môn học:";
            // 
            // lblOutputLanThi
            // 
            this.lblOutputLanThi.AutoSize = true;
            this.lblOutputLanThi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLanThi.Location = new System.Drawing.Point(411, 119);
            this.lblOutputLanThi.Name = "lblOutputLanThi";
            this.lblOutputLanThi.Size = new System.Drawing.Size(30, 32);
            this.lblOutputLanThi.TabIndex = 35;
            this.lblOutputLanThi.Text = "3";
            // 
            // frmBangDiemDaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(495, 408);
            this.Controls.Add(this.lblOutputLanThi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOutputLop);
            this.Controls.Add(this.lblOutpuMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBangDiemDaThi);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiemDaThi";
            this.Text = "Bảng điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvBangDiemDaThi;
        private System.Windows.Forms.ColumnHeader clnMaSv;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblOutpuMon;
        public System.Windows.Forms.Label lblOutputLop;
        public System.Windows.Forms.Label lblOutputLanThi;
    }
}