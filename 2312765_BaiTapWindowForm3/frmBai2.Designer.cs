﻿namespace _2312765_BaiTapWindowForm3
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTong = new System.Windows.Forms.RadioButton();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên dương N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(250, 80);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGiaiThua);
            this.groupBox1.Controls.Add(this.rdTong);
            this.groupBox1.Location = new System.Drawing.Point(139, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdTong
            // 
            this.rdTong.AutoSize = true;
            this.rdTong.Location = new System.Drawing.Point(20, 28);
            this.rdTong.Name = "rdTong";
            this.rdTong.Size = new System.Drawing.Size(122, 17);
            this.rdTong.TabIndex = 0;
            this.rdTong.TabStop = true;
            this.rdTong.Text = "Tính tổng 1+2+...+N";
            this.rdTong.UseVisualStyleBackColor = true;
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(20, 68);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(105, 17);
            this.rdGiaiThua.TabIndex = 0;
            this.rdGiaiThua.TabStop = true;
            this.rdGiaiThua.Text = "Tính giai thừa N!";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(185, 267);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(96, 32);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Xem kết quả";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(156, 330);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(10, 16);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblKQ);
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
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.RadioButton rdTong;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblKQ;
    }
}