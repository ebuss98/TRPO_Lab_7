using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Lab_7
{
    public partial class Form1 : Form
    {
        int redColor = 125;
        int greenColor = 125;
        int blueColor = 125;
        public Form1()
        {
            InitializeComponent();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor  = Color.FromArgb(redColor, greenColor, blueColor);
            string hexColor = "#" + Convert.ToString(redColor, 16) + Convert.ToString(greenColor, 16) + Convert.ToString(blueColor, 16);
            Clipboard.SetText(hexColor);
            toolTip1.SetToolTip(this.panel1, hexColor);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            redColor = trackBar1.Value;
            panel1.BackColor = Color.FromArgb(redColor, greenColor, blueColor);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            greenColor = trackBar3.Value;
            panel1.BackColor = Color.FromArgb(redColor, greenColor, blueColor);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            blueColor = trackBar2.Value;
            panel1.BackColor = Color.FromArgb(redColor, greenColor, blueColor);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
