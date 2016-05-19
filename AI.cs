using System.Drawing;
using System.Threading;

namespace BejeweledBot
{
    /// <summary>
    /// This class is responsible for making a move decision
    /// </summary>
    public class AI
    {
        /// <summary>
        /// Calculates the next move to make
        /// </summary>
        /// <param name="b">A BejeweledWindowManager object that contains the board data structure</param>
        public static void CalculateMove(BejeweledWindowManager b)
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (ValidColours.ValidColour.Contains(b.GemColours[x, y]))
                    {

                        if (((x <= 4) && (b.GemColours[x, y] == b.GemColours[x + 2, y]) &&
                             (b.GemColours[x, y] == b.GemColours[x + 3, y])) ||
                            ((x <= 6) && (y >= 1) && (y <= 6) && (b.GemColours[x + 1, y - 1] == b.GemColours[x, y]) &&
                             (b.GemColours[x + 1, y + 1] == b.GemColours[x, y])) ||
                            ((y <= 5) && (x <= 6) && (b.GemColours[x + 1, y + 1] == b.GemColours[x, y]) &&
                             (b.GemColours[x + 1, y + 2] == b.GemColours[x, y])) ||
                            ((y >= 2) && (x <= 6) && (b.GemColours[x + 1, y - 1] == b.GemColours[x, y]) &&
                             (b.GemColours[x + 1, y - 2] == b.GemColours[x, y])))
                        {
                            // Move Gem Right
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) + 20, b.BoardLocation.Y + (y*40) + 20);
                            WindowsAPI.Click();
                            Thread.Sleep(5);
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) + 60, b.BoardLocation.Y + (y*40) + 20);
                            WindowsAPI.Click();
                        }
                        else if (((x >= 3) && (b.GemColours[x, y] == b.GemColours[x - 2, y]) &&
                                  (b.GemColours[x, y] == b.GemColours[x - 3, y])) ||
                                 ((x >= 1) && (y >= 1) && (b.GemColours[x - 1, y - 1] == b.GemColours[x, y]) &&
                                  (y <= 6) && (b.GemColours[x - 1, y + 1] == b.GemColours[x, y])) ||
                                 ((x >= 1) && (y <= 5) && (b.GemColours[x - 1, y + 1] == b.GemColours[x, y]) &&
                                  (b.GemColours[x - 1, y + 2] == b.GemColours[x, y])) ||
                                 ((x >= 1) && (y >= 2) && (b.GemColours[x - 1, y - 1] == b.GemColours[x, y]) &&
                                  (b.GemColours[x - 1, y - 2] == b.GemColours[x, y])))
                        {
                            // Move gem left
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) + 20, b.BoardLocation.Y + (y*40) + 20);
                            WindowsAPI.Click();
                            Thread.Sleep(5);
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) - 20, b.BoardLocation.Y + (y*40) + 20);
                            WindowsAPI.Click();
                        }
                        else if (((y >= 3) && (b.GemColours[x, y] == b.GemColours[x, y - 2]) &&
                                  (b.GemColours[x, y] == b.GemColours[x, y - 3])) ||

                                 ((y >= 1) && (((x >= 1) && (b.GemColours[x - 1, y - 1] == b.GemColours[x, y]) &&
                                                (x <= 6) && (b.GemColours[x + 1, y - 1] == b.GemColours[x, y])) ||

                                               ((y >= 1) && (x >= 2) &&
                                                (b.GemColours[x - 1, y - 1] == b.GemColours[x, y]) &&
                                                (b.GemColours[x - 2, y - 1] == b.GemColours[x, y])) ||

                                               ((y >= 1) && (x <= 5) &&
                                                (b.GemColours[x + 1, y - 1] == b.GemColours[x, y]) &&
                                                (b.GemColours[x + 2, y - 1] == b.GemColours[x, y])))))
                        {
                            // Move gem up
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) + 20, b.BoardLocation.Y + (y*40) + 20);
                            WindowsAPI.Click();
                            Thread.Sleep(5);
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) + 20, b.BoardLocation.Y + (y*40) - 20);
                            WindowsAPI.Click();
                        }
                        else if (((y <= 6) && (x <= 5) && (b.GemColours[x, y] == b.GemColours[x + 1, y + 1] &&
                                                           (b.GemColours[x, y] == b.GemColours[x + 2, y + 1]))) ||
                                 ((x >= 2) && (y <= 6) && (b.GemColours[x, y] == b.GemColours[x - 1, y + 1] &&
                                                           (b.GemColours[x, y] == b.GemColours[x - 2, y + 1]))) ||
                                 ((y <= 4) && (b.GemColours[x, y + 2] == b.GemColours[x, y]) &&
                                  (b.GemColours[x, y + 3] == b.GemColours[x, y])) ||
                                 ((x >= 1) && (x <= 6) && (y <= 6) &&
                                  (b.GemColours[x, y] == b.GemColours[x + 1, y + 1]) &&
                                  (b.GemColours[x, y] == b.GemColours[x - 1, y + 1])))
                        {
                            // Move gem down
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) + 20, b.BoardLocation.Y + (y*40) + 20);
                            WindowsAPI.Click();
                            Thread.Sleep(5);
                            WindowsAPI.SetCursorPos(b.BoardLocation.X + (x*40) + 20, b.BoardLocation.Y + (y*40) + 60);
                            WindowsAPI.Click();

                        }
                    }
                }
            }
        }
    }
}