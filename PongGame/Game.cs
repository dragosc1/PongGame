using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    internal class Game
    {
        private int state = 0;
        private GameWindow window;
        private World world;

        public Game()
        {
            window = new GameWindow();
            world = new World();
        }

        public GameWindow Window
        {
            get { return window; }
            set { Window = value; }
        }

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public bool WindowIsOpen()
        {
            return window.Window.IsOpen;
        }

        public void HandleInput()
        {
            window.HandleInput();
            if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
            {
                window.Window.Close();
            }
        }

        public void Update()
        {

        }

        public void Draw()
        {
            window.BeginDraw();
            world.Draw(ref window);
            window.EndDraw();
        }
    }
}
