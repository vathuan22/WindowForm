namespace _2312765_BaiTapThietKeForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.btnChon = new System.Windows.Forms.Button();
			this.btnBo = new System.Windows.Forms.Button();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnChon);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 37);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 307);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnTinhTien);
			this.panel2.Controls.Add(this.btnBo);
			this.panel2.Controls.Add(this.listBox2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.lblTongTien);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(395, 37);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(379, 307);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(93, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Danh sách hàng hóa";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Các mặt hàng khách mua";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
			this.listBox1.Location = new System.Drawing.Point(21, 73);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(217, 121);
			this.listBox1.TabIndex = 1;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(140, 73);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(217, 121);
			this.listBox2.TabIndex = 1;
			// 
			// btnChon
			// 
			this.btnChon.Location = new System.Drawing.Point(261, 124);
			this.btnChon.Name = "btnChon";
			this.btnChon.Size = new System.Drawing.Size(92, 27);
			this.btnChon.TabIndex = 2;
			this.btnChon.Text = "Chọn hàng >";
			this.btnChon.UseVisualStyleBackColor = true;
			this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
			// 
			// btnBo
			// 
			this.btnBo.Location = new System.Drawing.Point(32, 124);
			this.btnBo.Name = "btnBo";
			this.btnBo.Size = new System.Drawing.Size(92, 27);
			this.btnBo.TabIndex = 2;
			this.btnBo.Text = "< Bỏ hàng";
			this.btnBo.UseVisualStyleBackColor = true;
			this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(199, 219);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(92, 27);
			this.btnTinhTien.TabIndex = 2;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 272);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(215, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tổng tiền thanh toán :";
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongTien.Location = new System.Drawing.Point(226, 275);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(0, 24);
			this.lblTongTien.TabIndex = 1;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmBai2";
			this.Text = "Bán hàng";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnChon;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Button btnBo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTongTien;
	}
}