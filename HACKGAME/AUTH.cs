using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HACKGAME
{
    public partial class AUTH : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=server222.hosting.reg.ru;port=3306;Initial Catalog=u0613437_hacker;User Id='u0613437_hacker';password='Lock2612'");
        public AUTH()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where login='" + textBox1.Text+"' and pass='"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if(i == 0)
            {
                label5.Text = "WRONG PASSWORD. TRY AGAIN ...";
            }
            else
            {
                this.Visible = false;
                MAIN form1 = new MAIN();
                form1.ShowDialog();
                
            }
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            REGIST reg = new REGIST();
            reg.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
