namespace _2312765_BaiTapWindowForm3
{
    partial class frmChinh
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
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(45, 63);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(103, 44);
            this.btnB1.TabIndex = 0;
            this.btnB1.Text = "Bài 1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(256, 63);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(103, 44);
            this.btnB2.TabIndex = 0;
            this.btnB2.Text = "Bài 2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(478, 63);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(103, 44);
            this.btnB3.TabIndex = 0;
            this.btnB3.Text = "Bài 3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Name = "frmChinh";
            this.Text = "Chương trình chính ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
    }
}

