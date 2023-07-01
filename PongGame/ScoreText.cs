using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    internal class ScoreText
    {
        private readonly string Player1;
        private readonly string Player2;

        private int[] score = new int[2]
        {
            new int(),
            new int()
        };

        public ScoreText()
        {
            Player1 = "Player1:   ";
            Player2 = "Player2:   ";
        }

        public void Draw(ref GameWindow window, ref Font font)
        {
            Text text = new Text();
            text.DisplayedString = Player1 + score[0];
            text.CharacterSize = 24;
            text.FillColor = Color.White;
            text.Font = font;
            text.Position = new SFML.System.Vector2f(World.cellSize, 1);
            window.Window.Draw(text);

            text.DisplayedString = Player2 + score[1];
            text.CharacterSize = 24;
            text.FillColor = Color.White;
            text.Font = font;
            text.Position = new SFML.System.Vector2f(World.cellSize * 41, 1);
            window.Window.Draw(text);
        }

        public void Increase(int id)
        {
            score[id] = score[id] + 1;
        }
    }
}
