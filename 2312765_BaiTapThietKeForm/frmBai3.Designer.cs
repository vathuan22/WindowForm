﻿namespace _2312765_BaiTapThietKeForm
{
	partial class frmBai3
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
			this.txtTuMoi = new System.Windows.Forms.TextBox();
			this.txtNghia = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtHienNghia = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(206, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ mới";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(170, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nghĩa của từ";
			// 
			// txtTuMoi
			// 
			this.txtTuMoi.Location = new System.Drawing.Point(276, 62);
			this.txtTuMoi.Name = "txtTuMoi";
			this.txtTuMoi.Size = new System.Drawing.Size(165, 20);
			this.txtTuMoi.TabIndex = 0;
			// 
			// txtNghia
			// 
			this.txtNghia.Location = new System.Drawing.Point(276, 104);
			this.txtNghia.Name = "txtNghia";
			this.txtNghia.Size = new System.Drawing.Size(197, 20);
			this.txtNghia.TabIndex = 1;
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(295, 143);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(104, 30);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm từ mới";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Danh sách từ mới";
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(117, 247);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(214, 164);
			this.listBox1.TabIndex = 3;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(464, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Nghĩa của từ";
			// 
			// txtHienNghia
			// 
			this.txtHienNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHienNghia.Location = new System.Drawing.Point(406, 247);
			this.txtHienNghia.Multiline = true;
			this.txtHienNghia.Name = "txtHienNghia";
			this.txtHienNghia.Size = new System.Drawing.Size(219, 164);
			this.txtHienNghia.TabIndex = 4;
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 450);
			this.Controls.Add(this.txtHienNghia);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtNghia);
			this.Controls.Add(this.txtTuMoi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Từ điển Anh-Việt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTuMoi;
		private System.Windows.Forms.TextBox txtNghia;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtHienNghia;
	}
}