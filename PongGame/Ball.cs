using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    internal class Ball
    {
        Tuple<int, int> BallID;
        public Ball() {
            BallID = new Tuple<int, int>(25, 17);
        }
        public void Draw(ref GameWindow window)
        {
            RectangleShape shape = new RectangleShape();
            shape.Position = new Vector2f(BallID.Item1 * World.cellSize, BallID.Item2 * World.cellSize);
            shape.FillColor = Color.Red;
            shape.Size = new Vector2f(World.cellSize, World.cellSize);  
            window.Window.Draw(shape);
        }
    }
}
