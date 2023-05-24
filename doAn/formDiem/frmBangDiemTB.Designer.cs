namespace doAn.formDiem
{
    partial class frmBangDiemTB
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
            this.lvBangDiemTB = new System.Windows.Forms.ListView();
            this.clnMaSv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutputLop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvBangDiemTB
            // 
            this.lvBangDiemTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvBangDiemTB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaSv,
            this.clnHo,
            this.clnTen,
            this.clnDiem});
            this.lvBangDiemTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBangDiemTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBangDiemTB.FullRowSelect = true;
            this.lvBangDiemTB.GridLines = true;
            this.lvBangDiemTB.HideSelection = false;
            this.lvBangDiemTB.Location = new System.Drawing.Point(0, 149);
            this.lvBangDiemTB.MultiSelect = false;
            this.lvBangDiemTB.Name = "lvBangDiemTB";
            this.lvBangDiemTB.Size = new System.Drawing.Size(495, 259);
            this.lvBangDiemTB.TabIndex = 24;
            this.lvBangDiemTB.UseCompatibleStateImageBehavior = false;
            this.lvBangDiemTB.View = System.Windows.Forms.View.Details;
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
            this.clnDiem.Text = "Điểm TB";
            this.clnDiem.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(69, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 66);
            this.label1.TabIndex = 29;
            this.label1.Text = "BẢNG THỐNG KÊ ĐIỂM TRUNG \r\nBÌNH KHÓA HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputLop
            // 
            this.lblOutputLop.AutoSize = true;
            this.lblOutputLop.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLop.Location = new System.Drawing.Point(121, 111);
            this.lblOutputLop.Name = "lblOutputLop";
            this.lblOutputLop.Size = new System.Drawing.Size(314, 28);
            this.lblOutputLop.TabIndex = 31;
            this.lblOutputLop.Text = "Công nghệ đa phương tiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lớp:";
            // 
            // frmBangDiemTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(495, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOutputLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBangDiemTB);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiemTB";
            this.Text = "Bảng điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvBangDiemTB;
        private System.Windows.Forms.ColumnHeader clnMaSv;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblOutputLop;
    }
}