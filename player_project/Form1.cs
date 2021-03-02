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
    enum PlayerPosition {
       // [Description("Goal Keepper")]
        GoalKeepper,
        Centreback,
        Sweeper,
        Fullback,
        Wingback,
        Centremidfield,
        Defensivemidfield,
        Attackingmidfield,
        Widemidfield,
        Striker,
        CenterForword,
        LeftWinger,
        RightWinger
    }
    public partial class Form1 : Form
    {
        internal static Players players = new Players();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void bt_AddPlayer_Click(object sender, EventArgs e)
        {

            //Add Player
            Player player = new Player();
            player.Id = int.Parse(txt_Id.Text);
            player.Name = txt_Name.Text;
            player.Position = cmb_position.Text;
            player.State = PlayerState.SAFE;
            if(rdb_injured.Checked)
                player.State = PlayerState.INJURED;

            Form1.players.LstPlyers.Add(player);

            //open the next Form
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

        
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_position.DataSource = Enum.GetValues(typeof(PlayerPosition));
            rdb_safe.Checked = true;
        }

        private void txt_Id_Leave(object sender, EventArgs e)
        {
            //if (int.Parse(txt_Id.Text) < 0)
            //{
            //    MessageBox.Show("Id erroné");
            //    bt_AddPlayer.Enabled = false;
            //}
            //else
            //    bt_AddPlayer.Enabled = true;

        }

        
    }
}
