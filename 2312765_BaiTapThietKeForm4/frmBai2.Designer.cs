﻿namespace _2312765_BaiTapThietKeForm4
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
            this.txtLT = new System.Windows.Forms.TextBox();
            this.txtTH = new System.Windows.Forms.TextBox();
            this.btnXep = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm lý thuyết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập điểm thực hành";
            // 
            // txtLT
            // 
            this.txtLT.Location = new System.Drawing.Point(199, 100);
            this.txtLT.Name = "txtLT";
            this.txtLT.Size = new System.Drawing.Size(100, 20);
            this.txtLT.TabIndex = 1;
            // 
            // txtTH
            // 
            this.txtTH.Location = new System.Drawing.Point(199, 152);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(100, 20);
            this.txtTH.TabIndex = 1;
            // 
            // btnXep
            // 
            this.btnXep.Location = new System.Drawing.Point(118, 200);
            this.btnXep.Name = "btnXep";
            this.btnXep.Size = new System.Drawing.Size(75, 23);
            this.btnXep.TabIndex = 2;
            this.btnXep.Text = "Xếp loại";
            this.btnXep.UseVisualStyleBackColor = true;
            this.btnXep.Click += new System.EventHandler(this.btnXep_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả xếp loại :";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.Red;
            this.lblKQ.Location = new System.Drawing.Point(221, 258);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(10, 16);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 359);
            this.Controls.Add(this.btnXep);
            this.Controls.Add(this.txtTH);
            this.Controls.Add(this.txtLT);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Xếp loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLT;
        private System.Windows.Forms.TextBox txtTH;
        private System.Windows.Forms.Button btnXep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKQ;
    }
}