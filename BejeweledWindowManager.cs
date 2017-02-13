using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace BejeweledBot
{
    /// <summary>
    /// This class is responsible for the management of the screen. It performs actions such as initial calibration, population of the board data structure and the drawing of the board.  
    /// </summary>
    public class BejeweledWindowManager
    {
        private Bitmap _screenshot; /// Holds a screenshot of the whole screen

        private Bitmap _bejeweledBoard; // A bit map of just the bejeweled playing area
        public Bitmap BejewledBoard
        {
            get { return _bejeweledBoard; }
            set { _bejeweledBoard = value; }
        }

        private Bitmap _colourGrid;
        public Bitmap ColourGrid => _colourGrid;

        private Color[,] _gemColours = new Color[8, 8]; // Data structure representing the game board
        public Color[,] GemColours => _gemColours;

        private Point _boardLocation;
        public Point BoardLocation => _boardLocation;

        public BejeweledWindowManager()
        {
            // Colour grid bitmap initialised to the same size as the picturebox control
            _colourGrid = new Bitmap(447, 348);
        }

        /// <summary>
        /// Captures a screenshot, searches for the playing area and fills the board with the colours of the gem in each cell
        /// </summary>
        public void Calibrate()
        {
            // If the board is found, fill the board data structure
            if (GetBoardFromScreenshot(ScreenCapture.GetScreen()))
                PopulateBoard();
        }

        /// <summary>
        /// Iterates through board and gets the colour at the centre of each cell
        /// </summary>
        public void PopulateBoard()
        {
            // Iterate through bejeweled board and get the colour of the centre of each cell (each gem)
            for (int y = 0; y < 8; y++)
                for (int x = 0; x < 8; x++)
                    _gemColours[x, y] = _bejeweledBoard.GetPixel(x * 40 + 20, y * 40 + 20); // x = column e.g, x = 1,( 1 * 40)  = (40) + 20 = 60. 60 is centre of the 2nd column

            CreateColourGrid();
        }

        /// <summary>
        /// Gets the playing area from a screenshot of the board
        /// </summary>
        /// <param name="bmapScreenshot">A screenshot of the whole screen</param>
        /// <returns>Returns true if the board was found</returns>
        private bool GetBoardFromScreenshot(Bitmap bmapScreenshot)
        {
            // Holds the x and y co-ords of the start of the board
            int x, y;
            for (y = 0; y < bmapScreenshot.Height; y++)
            {
                for (x = 0; x < bmapScreenshot.Width; x++)
                {
                    // Get the colour of the pixel at the x & y coords
                    Color pixelColour = bmapScreenshot.GetPixel(x, y); //73,29,16

                    // If the pixel's colour is != to the colour of the top left corner of the board go to next iteration
                    if (pixelColour.R != 142 || pixelColour.G != 97 || pixelColour.B != 55)
                        continue;

                    // The coords of top left of board
                    _boardLocation = new Point(x, y);

                    // Create a rectangle the size of the board at the boards left corner
                    Rectangle sourceRectangle = new Rectangle(_boardLocation, new Size(320, 320));

                    // Copy board to bitmap
                    _bejeweledBoard = bmapScreenshot.Clone(sourceRectangle, PixelFormat.DontCare);

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Draws the board to a bitmap to facilitate the display of the game board within the application
        /// </summary>
        private void CreateColourGrid()
        {
	    using (Graphics g = Graphics.FromImage(_colourGrid))
            {
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                    
                        g.FillRectangle(new SolidBrush(_gemColours[x, y]), (float)x * 55, (float)y * 44, 55, 44);
                    }
                }
            }
        }
    }
}