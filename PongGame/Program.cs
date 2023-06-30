using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;

namespace PongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); 
            while (game.WindowIsOpen())
            {
                game.HandleInput();
                game.Update();
                game.Draw();
            }
        }

    }
}
