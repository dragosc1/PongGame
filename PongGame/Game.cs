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
        private StartText text;
        private float timeSpent = 0;
        private float timeStep = 1000;

        public Game()
        {
            window = new GameWindow();
            world = new World();
            text = new StartText();
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
            else if (Keyboard.IsKeyPressed(Keyboard.Key.F))
            {
                if (state != -1)
                {
                    Random random = new Random();
                    int randomNumber = random.Next() % 4;

                    world.SetBallDirection(randomNumber);
                }
                state = -1;
            }
        }

        public void Update()
        {
            if (timeSpent >= timeStep)
            {
                // game is curently running
                if (state == -1)
                {
                    world.MoveBall();
                    int hasWon = world.GetWinner();
                    if (hasWon > 0)
                    {
                        // showcase the winner;
                        state = hasWon;
                    }
                }
                timeSpent = 0;
            }
            else timeSpent += 10.0f;
        }

        public void Draw()
        {
            window.BeginDraw();
            world.Draw(ref window);
            if (state != -1)
                text.Draw(ref window);
            window.EndDraw();
        }
    }
}
