using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Xóa nội dung và đặt con trỏ vào ô tên
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYearOfBirth.Clear();
            txtYourName.Focus();
        }

        // Hiển thị thông tin
        private void btnShow_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu hợp lệ trước khi hiển thị
            if (ValidateInputs())
            {
                int age = DateTime.Now.Year - Convert.ToInt32(txtYearOfBirth.Text);
                string message = $"My name is: {txtYourName.Text}\nI am {age} years old.";
                MessageBox.Show(message, "Your Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Kiểm tra lỗi nhập liệu cho Name
        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYourName.Text))
            {
                errorProvider1.SetError(txtYourName, "You must enter your name.");
            }
            else
            {
                errorProvider1.SetError(txtYourName, "");
            }
        }

        // Kiểm tra lỗi nhập liệu cho Year of Birth
        private void txtYearOfBirth_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtYearOfBirth.Text, out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                errorProvider1.SetError(txtYearOfBirth, "Invalid year. Enter a valid number between 1900 and the current year.");
            }
            else
            {
                errorProvider1.SetError(txtYearOfBirth, "");
            }
        }

        // Kiểm tra dữ liệu hợp lệ
        private bool ValidateInputs()
        {
            bool isValid = true;

            // Kiểm tra txtYourName
            if (string.IsNullOrWhiteSpace(txtYourName.Text))
            {
                errorProvider1.SetError(txtYourName, "You must enter your name.");
                isValid = false;
            }

            // Kiểm tra txtYearOfBirth
            if (!int.TryParse(txtYearOfBirth.Text, out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                errorProvider1.SetError(txtYearOfBirth, "Invalid year. Enter a valid number between 1900 and the current year.");
                isValid = false;
            }

            return isValid;
        }

        // Xóa lỗi khi nhấn Clear
        private void Form1_Load(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYearOfBirth.Clear();
            errorProvider1.Clear();
            txtYourName.Focus();
        }
    }
}
