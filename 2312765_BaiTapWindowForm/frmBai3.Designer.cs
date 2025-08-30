namespace _2312765_BaiTapWindowForm
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTong2So = new System.Windows.Forms.RadioButton();
			this.rd1N = new System.Windows.Forms.RadioButton();
			this.btnTinh = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblKQ = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(51, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số a";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(51, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Số b";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(51, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số n";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(96, 53);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 20);
			this.txtA.TabIndex = 1;
			this.txtA.Text = "0";
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(96, 94);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 20);
			this.txtB.TabIndex = 1;
			this.txtB.Text = "0";
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(96, 137);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(100, 20);
			this.txtN.TabIndex = 1;
			this.txtN.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rd1N);
			this.groupBox1.Controls.Add(this.rdTong2So);
			this.groupBox1.Location = new System.Drawing.Point(54, 199);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán";
			// 
			// rdTong2So
			// 
			this.rdTong2So.AutoSize = true;
			this.rdTong2So.Location = new System.Drawing.Point(28, 31);
			this.rdTong2So.Name = "rdTong2So";
			this.rdTong2So.Size = new System.Drawing.Size(90, 17);
			this.rdTong2So.TabIndex = 0;
			this.rdTong2So.TabStop = true;
			this.rdTong2So.Text = "Tính tổng a,b";
			this.rdTong2So.UseVisualStyleBackColor = true;
			// 
			// rd1N
			// 
			this.rd1N.AutoSize = true;
			this.rd1N.Location = new System.Drawing.Point(28, 67);
			this.rd1N.Name = "rd1N";
			this.rd1N.Size = new System.Drawing.Size(102, 17);
			this.rd1N.TabIndex = 0;
			this.rd1N.TabStop = true;
			this.rd1N.Text = "Tính tổng từ 1-n";
			this.rd1N.UseVisualStyleBackColor = true;
			// 
			// btnTinh
			// 
			this.btnTinh.Location = new System.Drawing.Point(208, 315);
			this.btnTinh.Name = "btnTinh";
			this.btnTinh.Size = new System.Drawing.Size(75, 26);
			this.btnTinh.TabIndex = 3;
			this.btnTinh.Text = "Xem kết quả";
			this.btnTinh.UseVisualStyleBackColor = true;
			this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(120, 361);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Kết quả: ";
			// 
			// lblKQ
			// 
			this.lblKQ.AutoSize = true;
			this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKQ.Location = new System.Drawing.Point(188, 363);
			this.lblKQ.Name = "lblKQ";
			this.lblKQ.Size = new System.Drawing.Size(0, 18);
			this.lblKQ.TabIndex = 0;
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 450);
			this.Controls.Add(this.btnTinh);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblKQ);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "frmBai3";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rd1N;
		private System.Windows.Forms.RadioButton rdTong2So;
		private System.Windows.Forms.Button btnTinh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblKQ;
	}
}