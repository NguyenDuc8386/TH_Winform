using System;
using System.Drawing; // Để xử lý màu sắc và font
using System.Windows.Forms;

namespace BT_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           txtTen.Focus();
        }

        // Cập nhật nội dung lblLapTrinh song song với nội dung txtTen
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtTen.Text; // Gán nội dung từ txtTen vào lblLapTrinh
        }

        // Xử lý sự kiện khi nhấn các Radiobutton (đổi màu)
       


        // Xử lý sự kiện khi nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng chương trình
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;

        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;

        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;

        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;

        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style | FontStyle.Underline);
        }
    }
}
