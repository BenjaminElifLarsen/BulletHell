using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BulletHell
{
    abstract class Unit
    {
        protected Texture2D visualDesign;
        public float X { get; set; }
        public float Y { get; set; }

        public int TravelSpeed { get; set; }

        public int CurrentHealth { get; set; }

        protected int maxHealth;

        protected byte[] hitBox;

        protected WeaponSlots[] weaponSlots;

        protected List<List<Weapon>> weapons;

        public Unit(GraphicsDevice graphicsDevice)
        {
            if (visualDesign == null)
                using (Stream stream = TitleContainer.OpenStream(""))
                    visualDesign = Texture2D.FromStream(graphicsDevice, stream);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(visualDesign, new Vector2(X, Y), Color.White);
        }


    }
}
