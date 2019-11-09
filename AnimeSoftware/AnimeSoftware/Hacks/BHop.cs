using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class BHop
    {
        public static void Start()
        {
            while (true)
            {
                Thread.Sleep(1);

                if (!Properties.Settings.Default.bhop)
                    continue;
                if (!LocalPlayer.InGame)
                    continue;
                if (LocalPlayer.Health <= 0)
                    continue;
                if (LocalPlayer.Speed <= 0)
                    continue;
                

                if ((DllImport.GetAsyncKeyState(0x20) & 0x8000) != 0) 
                    if (LocalPlayer.Flags == 257 || LocalPlayer.Flags == 263) 
                        LocalPlayer.Jump();

                
            }
        }
    }
}
