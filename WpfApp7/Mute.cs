using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp7.BridgePattern;

namespace WpfApp7
{
    public class Mute
    {

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetConsoleWindow();
        


        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000 ;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

      

        public void Muting(IntPtr Handle)
        {
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
            return;
        }
        
        public void Decrease(IntPtr Handle)
        {
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
            return;
        }
        
        public void Increase(IntPtr Handle)
        {
            SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            return;
        }

    }
}
