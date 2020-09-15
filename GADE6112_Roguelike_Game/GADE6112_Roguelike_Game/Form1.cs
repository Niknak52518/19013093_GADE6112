using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GADE6112_Roguelike_Game
{
    public partial class frmRLG : Form
    {
        public frmRLG()
        {
            InitializeComponent();
            Map map = new Map(20);
            GameEngine ge = new GameEngine();

            public frmRLG()
            {
                InitializeComponent();
                lblMap.Visible = true;
            }
        }
    }
}
