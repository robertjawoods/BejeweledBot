using System;
using System.Drawing;
using System.Windows.Forms;


namespace BejeweledBot
{
    /// <summary>
    /// This class allows the simple capturing of the whole screen and a board-sized location of the screen 
    /// </summary>
    public class ScreenCapture
    {
        /// <summary>
        /// Gets a screenshot of the entire screen
        /// </summary>
        /// <returns>A bitmap of the entire screen</returns>
        public static Bitmap GetScreen()
        {
            Bitmap _screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
           
            using (Graphics g = Graphics.FromImage(_screenshot))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, _screenshot.Size, CopyPixelOperation.SourceCopy);
                return _screenshot;
            }
        }

        /// <summary>
        /// Gets the board from a given point
        /// </summary>
        /// <param name="boardLocation">Top left of the board</param>
        /// <returns>A bit map of just the board</returns>
        public static Bitmap GetScreen(Point boardLocation)
        {
            Bitmap _board = new Bitmap(320, 320);

            using (Graphics g = Graphics.FromImage(_board))
            {
                g.CopyFromScreen(boardLocation.X, boardLocation.Y, 0, 0, _board.Size, CopyPixelOperation.SourceCopy);
                return _board;
            }
        }
    }
}
