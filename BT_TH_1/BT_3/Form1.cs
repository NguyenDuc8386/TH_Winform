using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int a))
            {
                cboSo.Items.Add(txtSo.Text);
            }
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(txtSo.Text);
            for (int i = 1;i <= so;i++)
            {
                if(so %i == 0)
                {
                    lstTinh.Items.Add(i);
                }
            }

        }

        private void lstTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i  < lstTinh.Items.Count; i++)
            {

            }
        }
    }
}
