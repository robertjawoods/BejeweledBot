using System.Collections.Generic;
using System.Drawing;


namespace BejeweledBot
{
    /// <summary>
    /// This holds a list of the valid colours, this way, the computer will not try to move a black square to a black square
    /// </summary>
    public static class ValidColours
    {
        public static List<Color> ValidColour = new List<Color>(14)
        {
            Colour( 15, 130, 253), Colour( 219, 219, 219), Colour( 254, 245, 35),
            Colour( 15, 161, 32),  Colour( 227, 98, 30),   Colour( 248, 26, 54),
            Colour( 236, 8, 236), Colour( 254, 28,57), Colour(18, 134, 252), Colour(84, 254, 136),
            Colour(254,254,254), Colour(246, 16, 246), Colour(254, 251, 121), Colour(254, 251, 37)
        };

        /// <summary>
        /// A wrapper to make inserting the colours into a list quicker
        /// </summary>
        /// <param name="r">Red value</param>
        /// <param name="g">Green value</param>
        /// <param name="b">Blue value</param>
        /// <returns>Returns a colour from the given RGB values</returns>
        public static Color Colour(int r, int g, int b)
        {
            return Color.FromArgb(255, r, g, b);
        }
    }
}