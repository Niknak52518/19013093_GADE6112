using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GADE6112_Roguelike_Game
{
    class Hero : Character
    {
        public Hero(float x, float y, float damage, float hp, float maxhp) : base(x, y, damage, hp, maxhp)
        {
            this.posX = x;
            this.posY = y;
            this.Damage = 2;
            this.HP = hp;
            this.MaxHP = maxhp;
        }

        public override string ToString()
        {
            return "Player Stats:\n" + "HP: " + HP + "/" + MaxHP + "\n" + "Damage: " + Damage + "\n" + "[" + posX + "," + posY + "]";
        }
    }
}
