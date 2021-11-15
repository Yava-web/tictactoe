using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe.model
{
    class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int point;

        public int Point
        {
            get { return point; }
            set { point = value; }
        }

        private static bool state;

        public static bool State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
