using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            txtKQ.Clear();
            if(rad1.Checked == true)
                txtKQ.Text += hoTen.ToLower();
            if(rad2.Checked == true)
                txtKQ.Text += hoTen.ToUpper();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtHoTen.Focus();
        }
    }
}
