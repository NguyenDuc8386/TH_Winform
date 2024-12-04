using System;
using System.Windows.Forms;

namespace BT_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kiểm tra và xử lý khi thay đổi giá trị txt1
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt1.Text, out _)) // Nếu không phải số
            {
                MessageBox.Show("Nhập sai! Vui lòng nhập số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt1.Clear();
                txt1.Focus();
            }
            else
            {
                TinhToan(); // Cập nhật kết quả khi giá trị hợp lệ
            }
        }

        // Kiểm tra và xử lý khi thay đổi giá trị txt2
        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt2.Text, out _)) // Nếu không phải số
            {
                MessageBox.Show("Nhập sai! Vui lòng nhập số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt2.Clear();
                txt2.Focus();
            }
            else
            {
                TinhToan(); // Cập nhật kết quả khi giá trị hợp lệ
            }
        }

        // Gọi khi bất kỳ RadioButton nào được chọn
        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            TinhToan();
        }

        // Hàm tính toán kết quả dựa trên RadioButton được chọn
        private void TinhToan()
        {
            // Kiểm tra đầu vào hợp lệ
            if (!int.TryParse(txt1.Text, out int s1) || !int.TryParse(txt2.Text, out int s2))
            {
                txtKQ.Clear(); // Xóa kết quả nếu đầu vào không hợp lệ
                return;
            }

            int ketQua = 0;

            // Tính toán dựa trên RadioButton được chọn
            if (radCong.Checked)
            {
                ketQua = s1 + s2;
            }
            else if (radTru.Checked)
            {
                ketQua = s1 - s2;
            }
            else if (radNhan.Checked)
            {
                ketQua = s1 * s2;
            }
            else if (radChia.Checked)
            {
                if (s2 == 0) // Kiểm tra chia cho 0
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKQ.Clear();
                    return;
                }
                ketQua = s1 / s2; // Chia lấy phần nguyên
            }

            // Hiển thị kết quả
            txtKQ.Text = ketQua.ToString();
        }

    
    }
}
