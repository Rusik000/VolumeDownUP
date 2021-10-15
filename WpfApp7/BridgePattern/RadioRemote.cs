using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.BridgePattern
{
    class RadioRemote : IRemote
    {
        public IDevice Device { get; set; }
        double percent = 100;
        double channel = 10;
        public RadioRemote(IDevice _device)
        {
            Device = _device;
        }
        public void TogglePower(bool IsEnable)
        {
            Device.IsEnabled(IsEnable);
        }
        public void VolumeDown()
        {
            percent--;
            Device.SetVolume(percent);
        }
        public void VolumeUP()
        {
            percent++;
            Device.SetVolume(percent);
        }
        public void Mute(bool IsMute)
        {
            Console.WriteLine($"\n The  Mute of Radio is {IsMute}");
        }
        public void OpenCalculator()
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        public void OpenBrowser()
        {
            System.Diagnostics.Process.Start("http://www.webpage.com");
        }
    }
}
