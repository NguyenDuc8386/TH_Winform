using System;
using System.Windows.Forms;

namespace BT_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi form load, vô hiệu hóa nút Giải và Xóa
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false; // Vô hiệu hóa nút Giải
            btnXoa.Enabled = false;  // Vô hiệu hóa nút Xóa
        }

        // Kiểm tra trạng thái của nút khi có sự thay đổi trong ô nhập liệu
        private void ToggleButtonsState()
        {
            // Nếu cả hai ô txtA và txtB đều có dữ liệu thì mới bật nút Giải và Xóa
            if (!string.IsNullOrEmpty(txtA.Text) && !string.IsNullOrEmpty(txtB.Text))
            {
                btnGiai.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnGiai.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        // Sự kiện khi người dùng nhập vào ô txtA
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            ToggleButtonsState();
        }

        // Sự kiện khi người dùng nhập vào ô txtB
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            ToggleButtonsState();
        }

        // Sự kiện khi nhấn nút Giải
        private void btnGiai_Click(object sender, EventArgs e)
        {
            // Lấy giá trị nhập vào từ txtA và txtB
            try
            {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);

                // Kiểm tra trường hợp A = 0
                if (A == 0)
                {
                    MessageBox.Show("Phương trình vô nghiệm hoặc có vô số nghiệm.", "Thông báo");
                }
                else
                {
                    // Giải phương trình bậc nhất: AX + B = 0 => X = -B / A
                    double X = -B / A;
                    txtNghiem.Text = "Nghiệm: " + X.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho A và B.", "Lỗi");
            }
        }

        // Sự kiện khi nhấn nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa các ô nhập liệu và kết quả
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();

            // Vô hiệu hóa lại các nút Giải và Xóa
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        // Sự kiện khi nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
