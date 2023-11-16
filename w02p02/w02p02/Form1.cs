using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p02
{
    public partial class Form1 : Form
    {

        int ile = 0; //pole klasy - odpowiednik zmiennej globalnej
        public Form1()
        {
            InitializeComponent();
            label1.Text = ile.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            ile++;
            label1.Text = ile.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ile = 0;
            label1.Text = ile.ToString();
        }
    }
}
