using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;

namespace AsciiRougelike.Display
{
    internal class AsciiGrid
{
        int Width { get; }
        int Height { get; }

        char[,] BackgroundChars { get; set; }
        char[,] ForegroundChars { get; set; }

        Color[,] BackgroundColors { get; set; }

        Color[,] ForegroundColors { get; set; }


        public AsciiGrid(int width, int height)
        {
            Width = width;
            Height = height;

            // Initialize arrays
            BackgroundChars = new char[Width, Height];
            ForegroundChars = new char[Width, Height];
            BackgroundColors = new Color[Width, Height];
            ForegroundColors = new Color[Width, Height];

        }

        public void Render()
        {

        }
    }
}
