namespace doAn.User
{
    partial class frmUserInDiem
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
            this.btnThoatNhapLop = new System.Windows.Forms.Button();
            this.btnNhapInforUser = new System.Windows.Forms.Button();
            this.txtInPutMaLop = new System.Windows.Forms.TextBox();
            this.txtInPutLanThi = new System.Windows.Forms.TextBox();
            this.txtInPutMaMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoatNhapLop
            // 
            this.btnThoatNhapLop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatNhapLop.Location = new System.Drawing.Point(0, 0);
            this.btnThoatNhapLop.Name = "btnThoatNhapLop";
            this.btnThoatNhapLop.Size = new System.Drawing.Size(75, 23);
            this.btnThoatNhapLop.TabIndex = 0;
            // 
            // btnNhapInforUser
            // 
            this.btnNhapInforUser.Location = new System.Drawing.Point(57, 234);
            this.btnNhapInforUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNhapInforUser.Name = "btnNhapInforUser";
            this.btnNhapInforUser.Size = new System.Drawing.Size(92, 34);
            this.btnNhapInforUser.TabIndex = 1;
            this.btnNhapInforUser.Text = "Nhập";
            this.btnNhapInforUser.UseVisualStyleBackColor = true;
            this.btnNhapInforUser.Click += new System.EventHandler(this.btnNhapInforUser_Click);
            // 
            // txtInPutMaLop
            // 
            this.txtInPutMaLop.Location = new System.Drawing.Point(192, 70);
            this.txtInPutMaLop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInPutMaLop.Name = "txtInPutMaLop";
            this.txtInPutMaLop.Size = new System.Drawing.Size(216, 30);
            this.txtInPutMaLop.TabIndex = 2;
            // 
            // txtInPutLanThi
            // 
            this.txtInPutLanThi.Location = new System.Drawing.Point(192, 166);
            this.txtInPutLanThi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInPutLanThi.Name = "txtInPutLanThi";
            this.txtInPutLanThi.Size = new System.Drawing.Size(216, 30);
            this.txtInPutLanThi.TabIndex = 3;
            // 
            // txtInPutMaMon
            // 
            this.txtInPutMaMon.Location = new System.Drawing.Point(192, 118);
            this.txtInPutMaMon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInPutMaMon.Name = "txtInPutMaMon";
            this.txtInPutMaMon.Size = new System.Drawing.Size(216, 30);
            this.txtInPutMaMon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(56, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(56, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lần thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(56, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "User In Điểm";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(316, 234);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 34);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmUserInDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInPutMaMon);
            this.Controls.Add(this.txtInPutLanThi);
            this.Controls.Add(this.txtInPutMaLop);
            this.Controls.Add(this.btnNhapInforUser);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmUserInDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoatNhapLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.TextBox txtInPutMaLop;
        public System.Windows.Forms.TextBox txtInPutLanThi;
        public System.Windows.Forms.TextBox txtInPutMaMon;
        public System.Windows.Forms.Button btnNhapInforUser;
    }
}