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
    public partial class MAIN : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public MAIN()
        {
            InitializeComponent();
            player.SoundLocation = "D:/game/rave.wav";
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MENU form2 = new MENU();
            form2.ShowDialog();
        }
        public void Closable()
        {
            MAIN form1 = new MAIN();
            form1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AUTH auth = new AUTH();
            auth.Close();
            auth.Visible = false;
            player.PlayLooping();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            MAIN formal1 = new MAIN();
            player.Stop();
            formal1.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            string datenow = DateTime.Now.ToShortDateString();
            label1.Text = time;
            label2.Text = datenow;
        }
        public void Shutdown()
        {
            this.Close();
            player.Stop();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Chat form1 = new Chat();
            form1.ShowDialog();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Sound_Click(object sender, EventArgs e)
        {
            sound.Visible = false;
            player.Stop();
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            sound.Visible = true;
            player.PlayLooping();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Terminal terminal = new Terminal();
            terminal.ShowDialog();
        }
    }
}
