using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            /*       x = double.Parse(textBox1.Text);
                   y = double.Parse(textBox2.Text);*/

            if (double.TryParse(textBox1.Text, out x)) ;
            else
            {
                x = 0;
                textBox1.Text = x.ToString();
            }
            if (double.TryParse(textBox2.Text, out y)) ;
            else
            {
                y = 0;
                textBox2.Text = y.ToString();
            }

            textBox3.Text = (x+y).ToString();
        }
    }
}
