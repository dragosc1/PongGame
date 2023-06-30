using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    internal class GameWindow
    {
        private RenderWindow window;
        public RenderWindow Window { get { return window; } } 

        public GameWindow()
        {
            window = new RenderWindow(new VideoMode(800, 600), "Pong", Styles.Default);
            window.Closed += Window_Closed;
        }

        void Window_Closed(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
        
        public void HandleInput()
        {
            window.DispatchEvents(); 
        }

        public void BeginDraw()
        {
            window.Clear(Color.Black);
        }

        public void EndDraw()
        {
            window.Display();
        }

    }
}
