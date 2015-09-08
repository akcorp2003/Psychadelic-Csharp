using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Threading;

namespace Psychadelic_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c <= 253 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    Thread.Sleep(10);
                }

                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    Thread.Sleep(10);
                }
            }
            

            //MessageBox.Show("Are you high now?");
        }
    }
}
