using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04p01
{
    public partial class Form1 : Form
    {
        int licznik = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            licznik++;
            label1.Text = licznik.ToString();
            if (timer1.Interval > 10)
                timer1.Interval-=10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*            if(timer1.Enabled)
                            timer1.Stop();
                        else timer1.Start();*/
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
