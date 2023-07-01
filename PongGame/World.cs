using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    internal class World
    {
        public static int cellSize = 16;
        private Objects obj;
        private Ball ball;

        public World() { 
            obj = new Objects();
            ball = new Ball();
        }

        public void Draw(ref GameWindow window)
        {
            obj.Draw(ref window);
            ball.Draw(ref window);
        }

        public int GetWinner()
        {
            return ball.GetWinner();
        }

        public void SetBallDirection(int dir)
        {
            ball.SetDirection(dir);
        }

        public void MoveBall()
        {
            ball.Move(ref obj);
        }

        public void Reset()
        {
            ball.Reset();
            obj.Reset();
        }

        public void HandleBarInput()
        {
            // for bar 1
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
                obj.MoveBar(0, "Up");
            else if (Keyboard.IsKeyPressed(Keyboard.Key.S))
                obj.MoveBar(0, "Down");

            // for bar 2
            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
                obj.MoveBar(1, "Up");
            else if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
                obj.MoveBar(1, "Down");
        }
    }
}
