﻿namespace _2312765_BaiTapThietKeForm
{
	partial class FrmBai1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBai1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTrang = new System.Windows.Forms.RadioButton();
			this.rdDo = new System.Windows.Forms.RadioButton();
			this.rdXanh = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lbltong = new System.Windows.Forms.Label();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(120, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(229, 220);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTrang);
			this.groupBox1.Controls.Add(this.rdDo);
			this.groupBox1.Controls.Add(this.rdXanh);
			this.groupBox1.Location = new System.Drawing.Point(542, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 180);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn màu xe";
			// 
			// rdTrang
			// 
			this.rdTrang.AutoSize = true;
			this.rdTrang.Location = new System.Drawing.Point(22, 120);
			this.rdTrang.Name = "rdTrang";
			this.rdTrang.Size = new System.Drawing.Size(53, 17);
			this.rdTrang.TabIndex = 0;
			this.rdTrang.TabStop = true;
			this.rdTrang.Text = "Trắng";
			this.rdTrang.UseVisualStyleBackColor = true;
			this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
			// 
			// rdDo
			// 
			this.rdDo.AutoSize = true;
			this.rdDo.Location = new System.Drawing.Point(22, 78);
			this.rdDo.Name = "rdDo";
			this.rdDo.Size = new System.Drawing.Size(39, 17);
			this.rdDo.TabIndex = 0;
			this.rdDo.TabStop = true;
			this.rdDo.Text = "Đỏ";
			this.rdDo.UseVisualStyleBackColor = true;
			this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
			// 
			// rdXanh
			// 
			this.rdXanh.AutoSize = true;
			this.rdXanh.Location = new System.Drawing.Point(22, 37);
			this.rdXanh.Name = "rdXanh";
			this.rdXanh.Size = new System.Drawing.Size(50, 17);
			this.rdXanh.TabIndex = 0;
			this.rdXanh.TabStop = true;
			this.rdXanh.Text = "Xanh";
			this.rdXanh.UseVisualStyleBackColor = true;
			this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(512, 302);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Đơn giá:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(512, 333);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Số lượng:";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(565, 299);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(154, 20);
			this.txtDonGia.TabIndex = 3;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(565, 330);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(84, 20);
			this.txtSoLuong.TabIndex = 3;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(564, 378);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
			this.btnTinhTien.TabIndex = 4;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(727, 303);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "$";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// lbltong
			// 
			this.lbltong.AutoSize = true;
			this.lbltong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltong.Location = new System.Drawing.Point(369, 424);
			this.lbltong.Name = "lbltong";
			this.lbltong.Size = new System.Drawing.Size(218, 24);
			this.lbltong.TabIndex = 2;
			this.lbltong.Text = "Tổng số tiền thanh toán :";
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongTien.Location = new System.Drawing.Point(593, 424);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(0, 24);
			this.lblTongTien.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(674, 426);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "$";
			this.label4.Click += new System.EventHandler(this.label3_Click);
			// 
			// FrmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 490);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.lbltong);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FrmBai1";
			this.Text = "Mua bán xe";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTrang;
		private System.Windows.Forms.RadioButton rdDo;
		private System.Windows.Forms.RadioButton rdXanh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbltong;
		private System.Windows.Forms.Label lblTongTien;
		private System.Windows.Forms.Label label4;
	}
}