namespace _2312765_BaiTapThietKeForm
{
	partial class frmBai4
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSo = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.lbl = new System.Windows.Forms.Label();
			this.lblTimThay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(65, 80);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(230, 277);
			this.listBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(357, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhập số cần tìm";
			// 
			// txtSo
			// 
			this.txtSo.Location = new System.Drawing.Point(460, 124);
			this.txtSo.Name = "txtSo";
			this.txtSo.Size = new System.Drawing.Size(74, 20);
			this.txtSo.TabIndex = 2;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(415, 171);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(75, 23);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm số";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.Location = new System.Drawing.Point(368, 247);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(65, 18);
			this.lbl.TabIndex = 1;
			this.lbl.Text = "Kết quả";
			// 
			// lblTimThay
			// 
			this.lblTimThay.AutoSize = true;
			this.lblTimThay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimThay.ForeColor = System.Drawing.Color.Red;
			this.lblTimThay.Location = new System.Drawing.Point(439, 247);
			this.lblTimThay.Name = "lblTimThay";
			this.lblTimThay.Size = new System.Drawing.Size(0, 18);
			this.lblTimThay.TabIndex = 1;
			// 
			// frmBai4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 450);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtSo);
			this.Controls.Add(this.lblTimThay);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Name = "frmBai4";
			this.Text = "Tìm số trong danh sách";
			this.Load += new System.EventHandler(this.frmBai4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSo;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label lblTimThay;
	}
}