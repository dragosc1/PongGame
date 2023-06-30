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
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "Pong", Styles.Default);
            window.Closed += Window_Closed;
            while (window.IsOpen)
            {
                window.DispatchEvents();
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                    window.Close();
                
                window.Clear(Color.Black);
                window.Display();
            }
        }
        static void Window_Closed(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow) sender;
            window.Close();
        }

    }
}
