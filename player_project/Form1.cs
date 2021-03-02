using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_AddPlayer_Click(object sender, EventArgs e)
        {
            

            //Add Player

            Form2 f2 = new Form2();
            //f2.Hide();//cacher la fenetre
            f2.Show(); //visualize  la fenetre
            //f2.Close();//ferme la fenetre
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Id.Text = "1";
        }

        private void txt_Id_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txt_Id.Text) < 0)
            {
                MessageBox.Show("Id erroné");
                bt_AddPlayer.Enabled = false;
            }
            else
                bt_AddPlayer.Enabled = true;

        }
    }
}
