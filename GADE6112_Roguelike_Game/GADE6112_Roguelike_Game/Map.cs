using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GADE6112_Roguelike_Game
{
    class Map
    {
        string[,] map = new string[20, 20];
        Random random = new Random();
        Character[] characters;
        int counter;

        public Map(int numOfCharacters)
        {
            characters = new Character[numOfCharacters];
            SetCharacters();
        }

        private void SetCharacters()
        {
            for (int i = 0; i < characters.Length; i++)
            {
                counter = random.Next(0, 2);
                if (counter == 0)
                {
                    Goblin goblin = new Goblin(1f, 1f, 1f, 1f, 1f);
                    goblin.PosX = random.Next(0, 20);
                    goblin.PosY = random.Next(0, 20);
                    characters[i] = goblin;
                }
            }

        }

        public void SetMap()
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    map[x, y] = "  .  ";
                }
            }

            for (int i = 0; i < characters.Length; i++)
            {
                map[characters[i].PosX, characters[i].PosY] = characters[i].Symbol;
            }
        }

        public void Display(Label lblMap)
        {
            lblMap.Text = "";
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    lblMap.Text += map[x, y];
                }
                lblMap.Text += "\n";
            }
        }

        public void DisplayInformation(RichTextBox txtInfoBox)
        {
            txtInfoBox.Text = "";
            for (int i = 0; i < 5; i++)
            {
                txtInfoBox.Text += characters[i].ToString();

            }
        }
    }
}
