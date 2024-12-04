using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_1
{
    public partial class FrmBai1_1 : System.Windows.Forms.Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongBao;

            thongBao = "Tên đăng nhập là:  ";

            thongBao += label1.Text;

            thongBao = "Mật khẩu là: ";

            thongBao += label2.Text;

            if (chkNho.Checked == true )
            {
                thongBao += "\n\rBạn có ghi nhớ";
            }
            MessageBox.Show(thongBao, "Thông báo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
