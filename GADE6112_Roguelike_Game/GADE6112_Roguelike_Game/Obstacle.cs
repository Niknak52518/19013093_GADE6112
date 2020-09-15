using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GADE6112_Roguelike_Game
{
    class Obstacle : Tile
    {
        public Obstacle(float x, float y) : base(x, y, TileType.EMPTY_TILE)
        {

        }
    }
}
