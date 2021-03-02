using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_project
{
    enum PlayerState { SAFE, INJURED}
    class Player
    {
        
        //properties
        public int Id { get; set; }
        // Id=10;//setter
        //    System.Windows.Forms.MessageBox.Show(Id.toString());//getter
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public PlayerState State { get; set; }

        public Player()
        {

        }
        public Player(int id, string name, DateTime birthDate, string position, PlayerState state)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Position = position;
            State = state;
        }
    }
}
