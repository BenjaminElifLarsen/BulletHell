using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulletHell
{
    abstract class Weapon
    {
        private Texture2D visualDesign;
        public int[] BulletSpawn { get; set; }
        public int Type { get; set; }
        public int BulletAmount { get; set; }
        
        public Projectile projectile { get; set; }

        public int[] AncherPoint { get; set; }

        public float Weight { get; set; }

        private float cooldown;

    }
}
