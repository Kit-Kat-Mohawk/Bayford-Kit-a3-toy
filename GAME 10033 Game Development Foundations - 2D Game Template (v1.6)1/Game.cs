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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.Title = "Ghosts and Pumpkin";
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Draw.Circle(200, 160, 50, Color.White);
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Circle(110, 300, 50, Color.White);
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Circle(340, 300, 50, Color.White);
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Circle(340, 40, 50, Color.White);
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.Circle(80, 100, 50, Color.White);
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;


        }
    }

}
