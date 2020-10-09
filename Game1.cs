using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BulletHell
{
    public class Game1 : Game
    {
        Texture2D ballTexture;
        Vector2 ballPosistion;
        float ballSpeed;


        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            ballPosistion = new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight / 2);
            ballSpeed = 100f;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            ballTexture = Content.Load<Texture2D>("ball");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardState kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Up))
                ballPosistion.Y -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Down))
                ballPosistion.Y += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Left))
                ballPosistion.X -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Right))
                ballPosistion.X += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;


            if (ballPosistion.X > _graphics.PreferredBackBufferWidth - ballTexture.Width / 2)
                ballPosistion.X = _graphics.PreferredBackBufferWidth - ballTexture.Width / 2;
            else if (ballPosistion.X < ballTexture.Width / 2)
                ballPosistion.X = ballTexture.Width / 2;

            if (ballPosistion.Y > _graphics.PreferredBackBufferHeight - ballTexture.Height / 2)
                ballPosistion.Y = _graphics.PreferredBackBufferHeight - ballTexture.Height / 2;
            else if (ballPosistion.Y < ballTexture.Height / 2)
                ballPosistion.Y = ballTexture.Height / 2;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(ballTexture, ballPosistion, null, Color.White,0f, new Vector2(ballTexture.Width / 2, ballTexture.Height / 2),Vector2.One,SpriteEffects.None,0f);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
