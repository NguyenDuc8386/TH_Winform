﻿namespace BT_7
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearOfBirth = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(409, 176);
            this.txtYourName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(296, 29);
            this.txtYourName.TabIndex = 1;
            this.txtYourName.TextChanged += new System.EventHandler(this.txtYourName_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(266, 324);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 32);
            this.btnShow.TabIndex = 4;
            this.btnShow.Tag = "";
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year of birth";
            // 
            // txtYearOfBirth
            // 
            this.txtYearOfBirth.Location = new System.Drawing.Point(409, 223);
            this.txtYearOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYearOfBirth.Name = "txtYearOfBirth";
            this.txtYearOfBirth.Size = new System.Drawing.Size(296, 29);
            this.txtYearOfBirth.TabIndex = 3;
            this.txtYearOfBirth.TextChanged += new System.EventHandler(this.txtYearOfBirth_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(432, 324);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(599, 324);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtYearOfBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYearOfBirth;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

