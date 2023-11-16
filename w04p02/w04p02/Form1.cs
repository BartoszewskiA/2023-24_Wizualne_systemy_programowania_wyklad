using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace w04p02
{
    public partial class Form1 : Form
    {

        int speed;
        public Form1()
        {
            InitializeComponent();
            speed = timer1.Interval;
            timer1.Interval = speed - trackBar1.Value * 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            else timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value >= progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            timer1.Interval = speed - trackBar1.Value * 50 + 1;
        }
    }
}
