namespace BT_3
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstTinh = new System.Windows.Forms.ListBox();
            this.btnSLCUSNT = new System.Windows.Forms.Button();
            this.btnSLCSC = new System.Windows.Forms.Button();
            this.btnTCUS = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.btnCapNhap);
            this.groupbox1.Controls.Add(this.txtSo);
            this.groupbox1.Controls.Add(this.cboSo);
            this.groupbox1.Location = new System.Drawing.Point(165, 80);
            this.groupbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox1.Size = new System.Drawing.Size(291, 172);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Nhập số";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(172, 61);
            this.btnCapNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(93, 29);
            this.btnCapNhap.TabIndex = 3;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.MouseEnter += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(26, 61);
            this.txtSo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(140, 28);
            this.txtSo.TabIndex = 2;
            // 
            // cboSo
            // 
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(7, 123);
            this.cboSo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(277, 28);
            this.cboSo.TabIndex = 0;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTinh);
            this.groupBox2.Location = new System.Drawing.Point(548, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(318, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lstTinh
            // 
            this.lstTinh.FormattingEnabled = true;
            this.lstTinh.ItemHeight = 20;
            this.lstTinh.Location = new System.Drawing.Point(7, 41);
            this.lstTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstTinh.Name = "lstTinh";
            this.lstTinh.Size = new System.Drawing.Size(304, 124);
            this.lstTinh.TabIndex = 0;
            this.lstTinh.SelectedIndexChanged += new System.EventHandler(this.lstTinh_SelectedIndexChanged);
            // 
            // btnSLCUSNT
            // 
            this.btnSLCUSNT.Location = new System.Drawing.Point(548, 386);
            this.btnSLCUSNT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSLCUSNT.Name = "btnSLCUSNT";
            this.btnSLCUSNT.Size = new System.Drawing.Size(318, 34);
            this.btnSLCUSNT.TabIndex = 4;
            this.btnSLCUSNT.Text = "số lượng các ước số nguyên tố";
            this.btnSLCUSNT.UseVisualStyleBackColor = true;
            // 
            // btnSLCSC
            // 
            this.btnSLCSC.Location = new System.Drawing.Point(548, 331);
            this.btnSLCSC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSLCSC.Name = "btnSLCSC";
            this.btnSLCSC.Size = new System.Drawing.Size(318, 34);
            this.btnSLCSC.TabIndex = 5;
            this.btnSLCSC.Text = "số lượng các số chẵn";
            this.btnSLCSC.UseVisualStyleBackColor = true;
            // 
            // btnTCUS
            // 
            this.btnTCUS.Location = new System.Drawing.Point(548, 278);
            this.btnTCUS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTCUS.Name = "btnTCUS";
            this.btnTCUS.Size = new System.Drawing.Size(318, 29);
            this.btnTCUS.TabIndex = 6;
            this.btnTCUS.Text = "Tổng các ước số";
            this.btnTCUS.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(303, 391);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTCUS);
            this.Controls.Add(this.btnSLCSC);
            this.Controls.Add(this.btnSLCUSNT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.btnCapNhap_Click);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.ListBox lstTinh;
        private System.Windows.Forms.Button btnSLCUSNT;
        private System.Windows.Forms.Button btnSLCSC;
        private System.Windows.Forms.Button btnTCUS;
        private System.Windows.Forms.Button btnThoat;
    }
}

