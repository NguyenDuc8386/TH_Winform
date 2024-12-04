using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 20;
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblDongHo.Text = i.ToString();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            lblDongHo.Text = i.ToString();
            if (i <= 0)
            {
                lblDongHo.Text = "Hết giờ!";
            }
        }
    }
}
