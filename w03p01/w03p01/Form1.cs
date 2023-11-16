using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += "Zdarzenie Load\n";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.Text += "Zdarzenie Activate\n";

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.Text += "Zdarzenie Deactivate\n";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy zamknąc program?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) { e.Cancel = true; }
        }
    }
}
