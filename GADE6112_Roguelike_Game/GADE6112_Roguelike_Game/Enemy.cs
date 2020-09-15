using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GADE6112_Roguelike_Game
{
    class Enemy : Character
    {
        Random r = new Random();

        public Enemy(float x, float y, float damage, float hp, float maxhp) : base(x, y, damage, hp, maxhp)
        {
            this.posX = x;
            this.posY = y;
            this.Damage = damage;
            this.HP = hp;
        }

        public override string ToString()
        {
            return "Enemy at [" + posX + "," + posY + "] (" + Damage + ")" ;
        }
    }
}
