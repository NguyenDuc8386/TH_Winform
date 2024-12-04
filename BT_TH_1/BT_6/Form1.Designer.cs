namespace BT_6
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
            this.labFont = new System.Windows.Forms.Label();
            this.radTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radCourierNew = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labFont
            // 
            this.labFont.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labFont.Location = new System.Drawing.Point(104, 101);
            this.labFont.Name = "labFont";
            this.labFont.Size = new System.Drawing.Size(217, 190);
            this.labFont.TabIndex = 0;
            this.labFont.Text = "What Font Is This?";
            // 
            // radTimesNewRoman
            // 
            this.radTimesNewRoman.AutoSize = true;
            this.radTimesNewRoman.Location = new System.Drawing.Point(359, 99);
            this.radTimesNewRoman.Name = "radTimesNewRoman";
            this.radTimesNewRoman.Size = new System.Drawing.Size(250, 33);
            this.radTimesNewRoman.TabIndex = 1;
            this.radTimesNewRoman.TabStop = true;
            this.radTimesNewRoman.Text = "Times New Roman";
            this.radTimesNewRoman.UseVisualStyleBackColor = true;
            this.radTimesNewRoman.CheckedChanged += new System.EventHandler(this.radTimesNewRoman_CheckedChanged);
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Location = new System.Drawing.Point(359, 154);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(85, 33);
            this.radArial.TabIndex = 2;
            this.radArial.TabStop = true;
            this.radArial.Text = "Arial";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radArial_CheckedChanged);
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Location = new System.Drawing.Point(359, 212);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(127, 33);
            this.radTahoma.TabIndex = 3;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radTahoma_CheckedChanged);
            // 
            // radCourierNew
            // 
            this.radCourierNew.AutoSize = true;
            this.radCourierNew.Location = new System.Drawing.Point(359, 256);
            this.radCourierNew.Name = "radCourierNew";
            this.radCourierNew.Size = new System.Drawing.Size(173, 33);
            this.radCourierNew.TabIndex = 4;
            this.radCourierNew.TabStop = true;
            this.radCourierNew.Text = "Courier New";
            this.radCourierNew.UseVisualStyleBackColor = true;
            this.radCourierNew.CheckedChanged += new System.EventHandler(this.radCourierNew_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập Văn Bản";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(686, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radCourierNew);
            this.Controls.Add(this.radTahoma);
            this.Controls.Add(this.radArial);
            this.Controls.Add(this.radTimesNewRoman);
            this.Controls.Add(this.labFont);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTNR;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radT;
        private System.Windows.Forms.RadioButton radCN;
        private System.Windows.Forms.Label labVB;
        private System.Windows.Forms.Label labFont;
        private System.Windows.Forms.RadioButton radTimesNewRoman;
        private System.Windows.Forms.RadioButton radArial;
        private System.Windows.Forms.RadioButton radTahoma;
        private System.Windows.Forms.RadioButton radCourierNew;
        private System.Windows.Forms.Label label3;
    }
}

