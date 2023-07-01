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
            ball.Move();
        }
    }
}
