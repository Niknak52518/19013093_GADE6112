using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GADE6112_Roguelike_Game
{
    public enum Movement
    {
        NO_MOVEMENT,
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    public abstract class Character : Tile
    {
        protected float HP;
        protected float MaxHP;
        protected float Damage;
        protected Tile[] tile;
        public bool isDead;

        public abstract int PosX { get; set; }
        public abstract int PosY { get; set; }
        public abstract string Symbol { get; }

        public Character(float x, float y, float damage, float hp, float maxhp) : base(x, y, TileType.EMPTY_TILE)
        {
            this.posX = x;
            this.posY = y;
        }

        public virtual void Attack()
        {

        }

        public virtual bool CheckRange()
        {
            return false;
        } 

        private int DistanceTo()
        {
            return 0;
        }

        public void Move()
        {

        }

        public abstract override string ToString();
    }
}
