namespace _2312765_BaiTapWindowForm
{
	partial class frmBai2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.cbbTenHang = new System.Windows.Forms.ComboBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdCash = new System.Windows.Forms.RadioButton();
			this.rdTransfer = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSoTien = new System.Windows.Forms.Label();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.lblTT = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Đơn giá";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số lượng";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(97, 82);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(110, 20);
			this.txtDonGia.TabIndex = 1;
			// 
			// cbbTenHang
			// 
			this.cbbTenHang.FormattingEnabled = true;
			this.cbbTenHang.Items.AddRange(new object[] {
            "Chuột ",
            "Máy in",
            "Bàn phím"});
			this.cbbTenHang.Location = new System.Drawing.Point(97, 48);
			this.cbbTenHang.Name = "cbbTenHang";
			this.cbbTenHang.Size = new System.Drawing.Size(121, 21);
			this.cbbTenHang.TabIndex = 2;
			this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(97, 118);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(75, 20);
			this.txtSoLuong.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdCash);
			this.groupBox1.Controls.Add(this.rdTransfer);
			this.groupBox1.Location = new System.Drawing.Point(97, 167);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hình thức thanh toán";
			// 
			// rdCash
			// 
			this.rdCash.AutoSize = true;
			this.rdCash.Checked = true;
			this.rdCash.Location = new System.Drawing.Point(22, 62);
			this.rdCash.Name = "rdCash";
			this.rdCash.Size = new System.Drawing.Size(66, 17);
			this.rdCash.TabIndex = 0;
			this.rdCash.TabStop = true;
			this.rdCash.Text = "Tiền mặt";
			this.rdCash.UseVisualStyleBackColor = true;
			// 
			// rdTransfer
			// 
			this.rdTransfer.AutoSize = true;
			this.rdTransfer.Location = new System.Drawing.Point(22, 30);
			this.rdTransfer.Name = "rdTransfer";
			this.rdTransfer.Size = new System.Drawing.Size(94, 17);
			this.rdTransfer.TabIndex = 0;
			this.rdTransfer.Text = "Chuyển khoản";
			this.rdTransfer.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 338);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số tiền thanh toán";
			// 
			// txtSoTien
			// 
			this.txtSoTien.AutoSize = true;
			this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoTien.Location = new System.Drawing.Point(213, 306);
			this.txtSoTien.Name = "txtSoTien";
			this.txtSoTien.Size = new System.Drawing.Size(0, 24);
			this.txtSoTien.TabIndex = 0;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(162, 280);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(75, 29);
			this.btnTinhTien.TabIndex = 4;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// lblTT
			// 
			this.lblTT.AutoSize = true;
			this.lblTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTT.Location = new System.Drawing.Point(197, 338);
			this.lblTT.Name = "lblTT";
			this.lblTT.Size = new System.Drawing.Size(0, 24);
			this.lblTT.TabIndex = 0;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 450);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbbTenHang);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSoTien);
			this.Controls.Add(this.lblTT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "frmBai2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.ComboBox cbbTenHang;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTransfer;
		private System.Windows.Forms.RadioButton rdCash;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label txtSoTien;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Label lblTT;
	}
}