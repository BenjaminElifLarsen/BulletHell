using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulletHell
{
    abstract class Projectile
    {
        private Texture2D visualDesign;
        public int Damage { get; set; }
        
        public int TravelSpeed { get; set; }

        public int TravelDirection_X { get; set; }

        public int TravelDirection_Y { get; set; }

        public int[,] Pattern { get; set; }

        public int Type { get; set; } //maybe not be used 




    }
}
