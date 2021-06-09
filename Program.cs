using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace trzymaknakubki
{
    class Program
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand,
                                                   StringBuilder lpstrReturnString,
                                                   int uReturnLength,
                                                   IntPtr hwndCallback);
        private static void open()
        {
            int ret = mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }
        static void Main(string[] args)
        {
            open();
        }
    }
}
