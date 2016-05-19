using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BejeweledBot
{
    /// <summary>
    /// Wrapper class for the Windows APAI to allow mouse movement and clicks
    /// </summary>
    public class WindowsAPI
    {
        /// <summary>
        /// Sets the location of the mouse
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private enum MOUSEEVENTF
        {
            LEFTDOWN = 0x02,
            LEFTUP = 0x04

        }

        /// <summary>
        /// Clicks at the mouse's current location
        /// </summary>
        public static void Click()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event((uint)MOUSEEVENTF.LEFTDOWN | (uint)MOUSEEVENTF.LEFTUP, X, Y, 0, 0);
        }
    }
}
