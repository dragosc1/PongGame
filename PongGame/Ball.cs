using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Direction
{
    UpLeft,
    UpRight,
    DownRight,
    DownLeft
};

namespace PongGame
{
    internal class Ball
    {
        private Tuple<int, int> BallID;
        private Direction dir;

        public void Reset()
        {
            BallID = new Tuple<int, int>(25, 17);
        }

        public Ball() {
            Reset();
        }
        public void Draw(ref GameWindow window)
        {
            RectangleShape shape = new RectangleShape();
            shape.Position = new Vector2f(BallID.Item1 * World.cellSize, BallID.Item2 * World.cellSize);
            shape.FillColor = Color.Red;
            shape.Size = new Vector2f(World.cellSize, World.cellSize);  
            window.Window.Draw(shape);
        }

        public int GetWinner()
        {
            if (BallID.Item1 < 0)
                return 2;
            else if (BallID.Item1 > 49)
                return 1;
            return 0;
        }

        public void SetDirection(int nr)
        {
            dir = (Direction) nr;
        }

        public void Move(ref Objects obj)
        {
            Console.WriteLine(dir);

            // maybe move to switch verification
            if (dir == Direction.UpLeft)
            {
                if (BallID.Item2 == 0) { 
                    dir = Direction.DownLeft;
                    Move(ref obj);
                }
                else if (obj.CheckCollision(0, BallID.Item1, BallID.Item2))
                {
                    dir = Direction.UpRight;
                    Move(ref obj);
                }
                else BallID = new Tuple<int, int>(BallID.Item1 - 1, BallID.Item2 - 1);
            }
            else if (dir == Direction.UpRight)
            {
                if (BallID.Item2 == 0)
                {
                    dir = Direction.DownRight;
                    Move(ref obj);
                }
                else if (obj.CheckCollision(1, BallID.Item1, BallID.Item2))
                {
                    dir = Direction.UpLeft;
                    Move(ref obj);
                }
                else BallID = new Tuple<int, int>(BallID.Item1 + 1, BallID.Item2 - 1);
            }
            else if (dir == Direction.DownLeft)
            {
                if (BallID.Item2 == 36)
                {
                    dir = Direction.UpLeft;
                    Move(ref obj);
                }
                else if (obj.CheckCollision(0, BallID.Item1, BallID.Item2))
                {
                    dir = Direction.DownRight;
                    Move(ref obj);
                }
                else BallID = new Tuple<int, int>(BallID.Item1 - 1, BallID.Item2 + 1);
            }
            else
            {
                if (BallID.Item2 == 36)
                {
                    dir = Direction.UpRight;
                    Move(ref obj);
                }
                else if (obj.CheckCollision(1, BallID.Item1, BallID.Item2))
                {
                    dir = Direction.DownLeft;
                    Move(ref obj);
                }
                else BallID = new Tuple<int, int>(BallID.Item1 + 1, BallID.Item2 + 1);
            }
        }
    }
}
