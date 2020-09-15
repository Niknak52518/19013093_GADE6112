using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GADE6112_Roguelike_Game
{
    class GameEngine
    {
        public Map field;
        Random random = new Random();

        public void GameLogic()
        {
            field = new Map(20);
        }

        public bool MovePlayer()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
