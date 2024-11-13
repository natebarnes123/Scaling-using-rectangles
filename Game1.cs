using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Scaling_using_rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectangle2;
        Texture2D rectangle1;
        Texture2D rectangle;
        Texture2D circle;
        Texture2D circle1;
        Texture2D circle2;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 600; 
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circle = Content.Load<Texture2D>("circle");
            circle1 = Content.Load<Texture2D>("circle");
            circle2 = Content.Load<Texture2D>("circle");
            rectangle = Content.Load<Texture2D>("rectangle");
            rectangle1 = Content.Load<Texture2D>("rectangle");
            rectangle2 = Content.Load<Texture2D>("rectangle");
            



            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(circle, new Rectangle(150, 150, 300, 300), Color.Black);
            _spriteBatch.Draw(rectangle, new Rectangle(220, 350, 25, 50), Color.Yellow);
            _spriteBatch.Draw(rectangle1, new Rectangle(360, 350, 25, 50), Color.Yellow);
            _spriteBatch.Draw(rectangle2, new Rectangle(220, 370, 140, 30), Color.Yellow);
            _spriteBatch.Draw(circle1, new Rectangle(225, 200, 50, 50), Color.Yellow);
            _spriteBatch.Draw(circle2, new Rectangle(325, 200, 50, 50), Color.Yellow);
            
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
