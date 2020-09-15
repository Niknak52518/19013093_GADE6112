using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GADE6112_Roguelike_Game
{
    class Goblin : Enemy
    {
        public Goblin(float x, float y, float damage, float hp, float maxhp) : base(x, y, damage, hp, maxhp)
        {
            this.posX = x;
            this.posY = y;
            this.Damage = 1;
            this.HP = 10;
        }
    }
}
