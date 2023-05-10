namespace doAn.formSua
{
    partial class frmEditLop
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
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.txtInPuTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoatLop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInPuNam = new System.Windows.Forms.TextBox();
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
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(57, 196);
            this.btnSuaLop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(92, 34);
            this.btnSuaLop.TabIndex = 1;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // txtInPuTenLop
            // 
            this.txtInPuTenLop.Location = new System.Drawing.Point(172, 82);
            this.txtInPuTenLop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInPuTenLop.Name = "txtInPuTenLop";
            this.txtInPuTenLop.Size = new System.Drawing.Size(221, 30);
            this.txtInPuTenLop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sửa lớp";
            // 
            // btnThoatLop
            // 
            this.btnThoatLop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatLop.Location = new System.Drawing.Point(316, 196);
            this.btnThoatLop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoatLop.Name = "btnThoatLop";
            this.btnThoatLop.Size = new System.Drawing.Size(92, 34);
            this.btnThoatLop.TabIndex = 9;
            this.btnThoatLop.Text = "Thoát";
            this.btnThoatLop.UseVisualStyleBackColor = true;
            this.btnThoatLop.Click += new System.EventHandler(this.btnThoatLop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Năm học";
            // 
            // txtInPuNam
            // 
            this.txtInPuNam.Location = new System.Drawing.Point(172, 129);
            this.txtInPuNam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInPuNam.Name = "txtInPuNam";
            this.txtInPuNam.Size = new System.Drawing.Size(134, 30);
            this.txtInPuNam.TabIndex = 11;
            // 
            // frmEditLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton = this.btnThoatLop;
            this.ClientSize = new System.Drawing.Size(461, 257);
            this.Controls.Add(this.txtInPuNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoatLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInPuTenLop);
            this.Controls.Add(this.btnSuaLop);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmEditLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoatNhapLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoatLop;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtInPuTenLop;
        public System.Windows.Forms.TextBox txtInPuNam;
    }
}