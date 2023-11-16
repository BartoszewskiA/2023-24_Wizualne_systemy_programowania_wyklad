using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        /*    label1.Text = "x:" + e.Location.X.ToString();
            label2.Text = "y:" + e.Location.Y.ToString();*/
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Right)
            {
                label1.Text = "x:" + e.Location.X.ToString();
                label2.Text = "y:" + e.Location.Y.ToString();
                richTextBox1.Text += "Kliknięcie prawym przyciskiem myszy\n";
            }
            else
            {
                label1.Text = "klik";
                label2.Text = "klik";
                richTextBox1.Text += "Kliknięcie lewym przyciskiem myszy\n";
            }
            
            
        }

        private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.Text = "x:" + e.Location.X.ToString();
            label2.Text = "y:" + e.Location.Y.ToString();
            richTextBox1.Text += "Dwukrotne kliknięcie przyciskiem myszy\n";
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.Text = "x:" + e.Location.X.ToString();
            label2.Text = "y:" + e.Location.Y.ToString();
            richTextBox1.Text += "Dwukrotne kliknięcie przyciskiem myszy\n";
        }
    }
}
