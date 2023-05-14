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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.lvDsMon = new System.Windows.Forms.ListView();
            this.clnMaSv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvDsMon
            // 
            this.lvDsMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMaSv,
            this.clnHo,
            this.clnTen,
            this.clnDiem});
            this.lvDsMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDsMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDsMon.FullRowSelect = true;
            this.lvDsMon.GridLines = true;
            this.lvDsMon.HideSelection = false;
            this.lvDsMon.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvDsMon.Location = new System.Drawing.Point(0, 0);
            this.lvDsMon.Name = "lvDsMon";
            this.lvDsMon.Size = new System.Drawing.Size(504, 370);
            this.lvDsMon.TabIndex = 24;
            this.lvDsMon.UseCompatibleStateImageBehavior = false;
            this.lvDsMon.View = System.Windows.Forms.View.Details;
            // 
            // clnMaSv
            // 
            this.clnMaSv.Text = "Mã sinh viên";
            this.clnMaSv.Width = 160;
            // 
            // clnHo
            // 
            this.clnHo.Text = "Họ";
            this.clnHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnHo.Width = 100;
            // 
            // clnTen
            // 
            this.clnTen.Text = "Tên";
            this.clnTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnTen.Width = 140;
            // 
            // clnDiem
            // 
            this.clnDiem.Text = "Điểm";
            this.clnDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnDiem.Width = 100;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(504, 370);
            this.Controls.Add(this.lvDsMon);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBangDiem";
            this.Text = "Bảng điểm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lvDsMon;
        private System.Windows.Forms.ColumnHeader clnMaSv;
        private System.Windows.Forms.ColumnHeader clnHo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnDiem;
    }
}