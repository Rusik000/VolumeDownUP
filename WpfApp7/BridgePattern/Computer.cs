using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static WpfApp7.Mute;

namespace WpfApp7.BridgePattern
{
    class Computer : IDevice
    {
       
        public void IsEnabled(bool IsEnable)
        {
            if (IsEnable == true)
            {
                Enable();
            }
            else
            {
                Disable();
            }
        }
        public void Disable()
        {
            Console.WriteLine($"\n The television is Disabled");
        }

        public void Enable()
        {
            Console.WriteLine($"\n The television is Enabled");
        }
        public void GetVolume()
        {
            double percent = 10;

            Console.WriteLine($"\n The Volume of television is {percent}");
        }
        public void SetVolume(double percent)
        {
            Console.WriteLine($"\n The Volume of television is {percent}");
        }
        public void OpenCalculator()
        {
            throw new NotImplementedException();
        }
        public void OpenBrowser()
        {
            throw new NotImplementedException();
        }
        public  void Mute()
        {
            Mute mute = new Mute();
           // mute.Muting();
        }
    }
}
