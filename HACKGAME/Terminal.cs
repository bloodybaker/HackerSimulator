using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HACKGAME
{
    public partial class Terminal : Form
    {
        //MAIN parentform;
        string root = "@root:$ ";
        
        //public Terminal(MAIN parent)
        public Terminal()    
    {
            InitializeComponent();
            //parentform = parent;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text + textBox1.Text);
            Thread.Sleep(1000);
            if (textBox1.Text.Equals("sudo ethernet localhost switch --on") || textBox1.Text.Equals("sudo ethernet 192.168.0.1 switch --on"))
            {
                listBox1.Items.Add(label1.Text + "Trying to connect...");
                Thread.Sleep(2000);
                listBox1.Items.Add(label1.Text + "Trying to connect...  Done.");
                Thread.Sleep(1000);
                //parentform.pictureBox4.Visible = false;
                
            }
            textBox1.Clear();
        }



    }
}
