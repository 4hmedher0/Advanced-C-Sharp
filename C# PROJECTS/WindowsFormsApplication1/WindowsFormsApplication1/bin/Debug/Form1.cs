using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello", "window by medo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            MessageBox.Show("we are here ");

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("good job ", "window made by medo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
          MessageBox.Show("goood bye");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("you are hero", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("really hero");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Show("https://www.google.com.eg");
        }

        private void Show(string p)
        {
            throw new NotImplementedException("be smart ");
        }
    }
}
