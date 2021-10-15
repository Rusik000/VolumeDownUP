using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.BridgePattern
{
    interface IRemote
    {
        void TogglePower(bool IsEnable);
        void VolumeDown();
        void VolumeUP();
        void OpenCalculator();
        void OpenBrowser();
        void Mute(bool IsMute);
    }
}
