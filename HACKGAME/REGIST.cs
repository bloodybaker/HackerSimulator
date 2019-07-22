using MySql.Data.MySqlClient;
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
    public partial class REGIST : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=server222.hosting.reg.ru;port=3306;Initial Catalog=u0613437_hacker;User Id='u0613437_hacker';password='Lock2612'");
        public REGIST()
        {
            InitializeComponent();
        }


        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(textBox3.Text))
            {
                int i = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO `u0613437_hacker`.`users` (`login`, `pass`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                AUTH auth = new AUTH();
                auth.Visible = false;
                auth.Close();
                this.Visible = false;
                    MAIN form1 = new MAIN();
                    form1.ShowDialog();

            }
            else
            {
                con.Close();
                label6.Text = "PASSWORD DON'T MATCH";
                label6.ForeColor = System.Drawing.Color.Red;
            }    
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
