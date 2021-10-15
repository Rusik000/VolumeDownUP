using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.BridgePattern
{
    class Radio : IDevice
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
            Console.WriteLine($"\n The radio is Disabled");
        }
        public void Enable()
        {
            Console.WriteLine($"\n The radio is Enabled");
        }

        public void GetVolume()
        {
            double percent = 10;

            Console.WriteLine($"\n The Volume of radio is {percent}");
        }


        public void SetVolume(double percent)
        {
            Console.WriteLine($"\n The Volume of radio is {percent}");
        }
        public void OpenCalculator()
        {
            throw new NotImplementedException();
        }
        public void OpenBrowser()
        {
            throw new NotImplementedException();
        }
        public void Mute()
        {
            throw new NotImplementedException();
        }
    }
}
