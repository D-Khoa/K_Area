using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace MyAutoClick
{
    class MouseEventManager
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);
        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);
        public static void ClickOnPoint(IntPtr wndHandle, Point clientPoint, int freq)
        {
            /// get screen coordinates
            if (ClientToScreen(wndHandle, ref clientPoint))
            {
                SetCursorPos(clientPoint.X, clientPoint.Y);
                for (int i = 0; i < freq; i++)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, clientPoint.X, clientPoint.Y, 0, 0);
                }
            }
        }
    }
}
