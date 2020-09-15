using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GADE6112_Roguelike_Game
{
    public enum TileType
    {
        HERO,
        ENEMY,
        GOLD,
        WEAPON,
        EMPTY_TILE
    }

    public abstract class Tile
    {
        protected float posX;
        protected float posY;
        protected TileType tileType;

        protected Tile(float posX, float posY, TileType tileType)
        {
            this.posX = posX;
            this.posY = posY;
            this.tileType = tileType;
        }

        public float X
        {
            get { return X; }
        }

        public float Y
        {
            get { return Y; }
        }

        public TileType type
        {
            get { return type; }
        }
    }
}
