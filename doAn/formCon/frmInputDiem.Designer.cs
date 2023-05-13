namespace doAn.formCon
{
    partial class frmInputDiem
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
            this.txtInPutMaMonHoc = new System.Windows.Forms.TextBox();
            this.txtInPutDiem = new System.Windows.Forms.TextBox();
            this.txtInLan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInPutMaMonHoc
            // 
            this.txtInPutMaMonHoc.Location = new System.Drawing.Point(46, 132);
            this.txtInPutMaMonHoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInPutMaMonHoc.Name = "txtInPutMaMonHoc";
            this.txtInPutMaMonHoc.Size = new System.Drawing.Size(171, 30);
            this.txtInPutMaMonHoc.TabIndex = 2;
            // 
            // txtInPutDiem
            // 
            this.txtInPutDiem.Location = new System.Drawing.Point(363, 138);
            this.txtInPutDiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInPutDiem.Name = "txtInPutDiem";
            this.txtInPutDiem.Size = new System.Drawing.Size(81, 30);
            this.txtInPutDiem.TabIndex = 3;
            // 
            // txtInLan
            // 
            this.txtInLan.Location = new System.Drawing.Point(363, 90);
            this.txtInLan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInLan.Name = "txtInLan";
            this.txtInLan.Size = new System.Drawing.Size(81, 30);
            this.txtInLan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập Điểm";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(306, 231);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 34);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(79, 231);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(92, 34);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // frmInputDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInLan);
            this.Controls.Add(this.txtInPutDiem);
            this.Controls.Add(this.txtInPutMaMonHoc);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmInputDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInPutMaMonHoc;
        private System.Windows.Forms.TextBox txtInPutDiem;
        private System.Windows.Forms.TextBox txtInLan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhap;
    }
}