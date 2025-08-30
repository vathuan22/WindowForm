namespace _2312765_BaiTapWindowForm
{
	partial class frmBai1
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
			this.lblThongBao = new System.Windows.Forms.Label();
			this.lblTT = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblThongBao
			// 
			this.lblThongBao.AutoSize = true;
			this.lblThongBao.Location = new System.Drawing.Point(114, 57);
			this.lblThongBao.Name = "lblThongBao";
			this.lblThongBao.Size = new System.Drawing.Size(100, 13);
			this.lblThongBao.TabIndex = 0;
			this.lblThongBao.Text = "Thông tin hàng hóa";
			// 
			// lblTT
			// 
			this.lblTT.AutoSize = true;
			this.lblTT.Location = new System.Drawing.Point(102, 104);
			this.lblTT.Name = "lblTT";
			this.lblTT.Size = new System.Drawing.Size(0, 13);
			this.lblTT.TabIndex = 0;
			this.lblTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTT);
			this.Controls.Add(this.lblThongBao);
			this.Name = "frmBai1";
			this.Text = "Hàng hóa";
			this.Load += new System.EventHandler(this.frmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblThongBao;
		private System.Windows.Forms.Label lblTT;
	}
}