using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_project
{
    enum PlayerState { INJURED, SAFE}
    enum PlayerPosition
    {
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
    class Player
    {        
        //properties
        public int Id { get; set; }
        // Id=10;//setter
        //    System.Windows.Forms.MessageBox.Show(Id.toString());//getter
        public string Name { get; set; }
        //Name="abc";Name="123anf";......
        public DateTime BirthDate { get; set; }
        public PlayerState State { get; set; }
        //State=PlayerState.SAFE;

        public PlayerPosition Position { get; set; }
        //ctor + 2 time tab
        public Player()
        {
            State = PlayerState.SAFE;
            Position = PlayerPosition.GoalKeepper;
        }

        public Player(int id, string name, DateTime birthDate, PlayerState state, PlayerPosition position)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            State = state;
            Position = position;
        }




        //Methods

    }
}
