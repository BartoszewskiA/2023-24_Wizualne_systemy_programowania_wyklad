using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            String s = label1.Text;
            s = "BYŁO \"" + s + "\" JEST Iinaczej";
            label1.Text = s;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Kliknięto przycisk";
        }
    }
}
