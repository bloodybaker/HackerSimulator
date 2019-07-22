using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HACKGAME
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) webBrowser1.Navigate(textBox1.Text);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                webBrowser1.Navigate(textBox1.Text); 
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
