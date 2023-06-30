using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    internal class Objects
    {
        private List<Tuple<int, int>>[] bar = new List<Tuple<int, int>>[2]
        {
            new List<Tuple<int, int>>(),
            new List<Tuple<int, int>>()
        };

        public Objects()
        {
            bar[0].Add(new Tuple<int, int>(1, 16));
            bar[0].Add(new Tuple<int, int>(1, 17));
            bar[0].Add(new Tuple<int, int>(1, 18));
            bar[0].Add(new Tuple<int, int>(1, 19));
            bar[0].Add(new Tuple<int, int>(1, 20));
            bar[1].Add(new Tuple<int, int>(48, 16));
            bar[1].Add(new Tuple<int, int>(48, 17));
            bar[1].Add(new Tuple<int, int>(48, 18));
            bar[1].Add(new Tuple<int, int>(48, 19));
            bar[1].Add(new Tuple<int, int>(48, 20));
        }

        public void Draw(ref GameWindow window)
        {
            for (int i = 0; i < 2; i++)
            {   
                foreach (Tuple<int, int> x in bar[i])
                {
                    RectangleShape shape = new RectangleShape();
                    shape.Position = new Vector2f(x.Item1 * World.cellSize, x.Item2 * World.cellSize);
                    shape.FillColor= Color.White;
                    shape.Size = new Vector2f(World.cellSize, World.cellSize);
                    window.Window.Draw(shape);
                }
            }
        }
    }
}
