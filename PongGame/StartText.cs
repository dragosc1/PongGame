using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    internal class StartText
    {
        private string start = "Press F to start...!";

        public StartText()
        {
            
        }
        public void Draw(ref GameWindow window)
        {
            Font font = new Font("arial.ttf");

            Text text = new Text();
            text.DisplayedString = start;
            text.CharacterSize = 24;
            text.FillColor = Color.White;
            text.Font = font;
            text.Position = new SFML.System.Vector2f(19 * World.cellSize, 25 * World.cellSize);

            window.Window.Draw(text);
        }
    }
}
