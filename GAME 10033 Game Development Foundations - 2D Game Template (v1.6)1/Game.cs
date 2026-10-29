// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Color[] colors = {
            Color.Cyan,
            Color.Yellow,
            Color.Red,
            Color.Green,
            Color.Blue,
        };

        int ghostpositionX = 0; 


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.Title = "Ghosts";
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(0);

            Draw.FillColor = Color.White;
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            DrawGhost(200, 160, colors[0]);
            DrawGhost(110, 300, colors[1]);
            DrawGhost(340, 300, colors[2]);
            DrawGhost(340, 40, colors[3]);
            DrawGhost(80, 100, colors[4]);


        }

        public void DrawGhost(int x, int y, Color color)
        {
            Draw.FillColor = color;
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Circle(x, y, 50);
            Draw.Circle(x, y + 50, 50);
        }

    }

}
