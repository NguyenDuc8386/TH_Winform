using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimesNewRoman.Checked == true)
            {
                labFont.Font = new Font("Times New Roman", labFont.Font.Size,labFont.Font.Style );
            }
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if(radArial.Checked == true)
            {
                labFont.Font = new Font("Arial", labFont.Font.Size, labFont.Font.Style);
            }
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if(radTahoma.Checked == true)
            {
                labFont.Font = new Font("Tahoma", labFont.Font.Size, labFont.Font.Style);
            }
        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if(radCourierNew.Checked)
            {
                labFont.Font = new Font("Courier New", labFont.Font.Size, labFont.Font.Style);
            }
        }
    }
}
