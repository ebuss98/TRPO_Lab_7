using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMIfYouCan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats!");
        }

        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            if (Cursor.Position.X < (button1.Left + button1.Width / 2))
                button1.Left += Cursor.Position.X;
            else
                button1.Left -= Cursor.Position.X;
            if (button1.Left > (this.ClientSize.Width - button1.Width))
                button1.Left = this.ClientSize.Width - button1.Width;
            if (button1.Left < 0)
                button1.Left = 0;
            if (Cursor.Position.Y < button1.Bottom + button1.Height / 2)
                button1.Top += Cursor.Position.Y;
            else
                button1.Top -= Cursor.Position.Y;
            if (button1.Top > (this.ClientSize.Height - button1.Height))
                button1.Top = this.ClientSize.Height - button1.Height;
            if (button1.Top < 0)
                button1.Top = 0;
        }


    }
}
