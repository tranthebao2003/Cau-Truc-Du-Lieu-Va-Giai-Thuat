namespace doAn.formDiem
{
    partial class frmBangDiemTK
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
            this.lvBangDiemTK = new System.Windows.Forms.ListView();
            this.clnMaSv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutputLop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutputNam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvBangDiemTK
            // 
            this.lvBangDiemTK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvBangDiemTK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaSv,
            this.clnHoTen});
            this.lvBangDiemTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBangDiemTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBangDiemTK.FullRowSelect = true;
            this.lvBangDiemTK.GridLines = true;
            this.lvBangDiemTK.HideSelection = false;
            this.lvBangDiemTK.Location = new System.Drawing.Point(0, 100);
            this.lvBangDiemTK.MultiSelect = false;
            this.lvBangDiemTK.Name = "lvBangDiemTK";
            this.lvBangDiemTK.Size = new System.Drawing.Size(495, 294);
            this.lvBangDiemTK.TabIndex = 24;
            this.lvBangDiemTK.UseCompatibleStateImageBehavior = false;
            this.lvBangDiemTK.View = System.Windows.Forms.View.Details;
            // 
            // clnMaSv
            // 
            this.clnMaSv.Text = "Mã sinh viên";
            this.clnMaSv.Width = 140;
            // 
            // clnHoTen
            // 
            this.clnHoTen.Text = "Họ Tên";
            this.clnHoTen.Width = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(80, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 33);
            this.label1.TabIndex = 29;
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputLop
            // 
            this.lblOutputLop.AutoSize = true;
            this.lblOutputLop.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLop.Location = new System.Drawing.Point(84, 69);
            this.lblOutputLop.Name = "lblOutputLop";
            this.lblOutputLop.Size = new System.Drawing.Size(279, 26);
            this.lblOutputLop.TabIndex = 31;
            this.lblOutputLop.Text = "Công nghệ đa phương tiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Năm:";
            // 
            // lblOutputNam
            // 
            this.lblOutputNam.AutoSize = true;
            this.lblOutputNam.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputNam.Location = new System.Drawing.Point(403, 70);
            this.lblOutputNam.Name = "lblOutputNam";
            this.lblOutputNam.Size = new System.Drawing.Size(64, 26);
            this.lblOutputNam.TabIndex = 34;
            this.lblOutputNam.Text = "2022";
            // 
            // frmBangDiemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(495, 394);
            this.Controls.Add(this.lblOutputNam);
            this.Controls.Add(this.lblOutputLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBangDiemTK);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiemTK";
            this.Text = "Bảng điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvBangDiemTK;
        private System.Windows.Forms.ColumnHeader clnMaSv;
        private System.Windows.Forms.ColumnHeader clnHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblOutputLop;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblOutputNam;
    }
}