namespace doAn.formDiem
{
    partial class frmBangDiem
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
            this.lvBangDiem = new System.Windows.Forms.ListView();
            this.clnMaSv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputDiem = new System.Windows.Forms.TextBox();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvBangDiem
            // 
            this.lvBangDiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvBangDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaSv,
            this.clnHo,
            this.clnTen,
            this.clnDiem});
            this.lvBangDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvBangDiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBangDiem.FullRowSelect = true;
            this.lvBangDiem.GridLines = true;
            this.lvBangDiem.HideSelection = false;
            this.lvBangDiem.Location = new System.Drawing.Point(0, 0);
            this.lvBangDiem.Name = "lvBangDiem";
            this.lvBangDiem.Size = new System.Drawing.Size(495, 287);
            this.lvBangDiem.TabIndex = 24;
            this.lvBangDiem.UseCompatibleStateImageBehavior = false;
            this.lvBangDiem.View = System.Windows.Forms.View.Details;
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
            this.label1.Location = new System.Drawing.Point(49, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nhập điểm";
            // 
            // txtInputDiem
            // 
            this.txtInputDiem.Location = new System.Drawing.Point(172, 313);
            this.txtInputDiem.Name = "txtInputDiem";
            this.txtInputDiem.Size = new System.Drawing.Size(114, 30);
            this.txtInputDiem.TabIndex = 26;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(321, 312);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(123, 30);
            this.btnNhapDiem.TabIndex = 27;
            this.btnNhapDiem.Text = "Nhập";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(495, 370);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.txtInputDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBangDiem);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiem";
            this.Text = "Bảng điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvBangDiem;
        private System.Windows.Forms.ColumnHeader clnMaSv;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputDiem;
        private System.Windows.Forms.Button btnNhapDiem;
    }
}