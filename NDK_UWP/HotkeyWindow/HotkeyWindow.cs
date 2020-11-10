using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Foundation;
using Windows.Storage;

namespace HotkeyWindow
{
    public enum Modifiers
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8,
        NoRepeast = 16384
    }
    class HotkeyAppContext : ApplicationContext
    {
        private HotkeyWindow hotkeyWindow = null;
        private Process process = null;
        private bool hotkeyInProcess = false;
        public HotkeyAppContext()
        {
            int processID = (int)ApplicationData.Current.LocalSettings.Values["processId"];
        }
    }
    class HotkeyWindow
    {
    }
}
