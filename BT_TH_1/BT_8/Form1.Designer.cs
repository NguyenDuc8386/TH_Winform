namespace BT_8
{
    partial class Form1
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
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.labA = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(233, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = " GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX+B = 0";
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(392, 307);
            this.txtNghiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.Size = new System.Drawing.Size(398, 33);
            this.txtNghiem.TabIndex = 1;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(285, 423);
            this.btnGiai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(112, 36);
            this.btnGiai.TabIndex = 2;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            // 
            // labA
            // 
            this.labA.AutoSize = true;
            this.labA.Location = new System.Drawing.Point(234, 190);
            this.labA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(80, 25);
            this.labA.TabIndex = 3;
            this.labA.Text = "Nhập A";
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.Location = new System.Drawing.Point(234, 258);
            this.labB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(79, 25);
            this.labB.TabIndex = 4;
            this.labB.Text = "Nhập B";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(136, 314);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(196, 25);
            this.lab.TabIndex = 5;
            this.lab.Text = "Nghiệm phương trình";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(392, 190);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(398, 33);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(392, 255);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(398, 33);
            this.txtB.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(480, 423);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(678, 423);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.labB);
            this.Controls.Add(this.labA);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Label labA;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

