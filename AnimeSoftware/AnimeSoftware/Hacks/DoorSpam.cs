using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class DoorSpam
    {
        public static void Start()
        {
            while (true)
            {
                if (!LocalPlayer.InGame)
                    continue;
                if (LocalPlayer.Health <= 0)
                    continue;

                while ((DllImport.GetAsyncKeyState(Properties.Hotkey.Default.doorKey) & 0x8000) != 0)
                {
                    ClientCMD.Exec("+use");
                    Thread.Sleep(15);
                    ClientCMD.Exec("-use");
                    Thread.Sleep(15);
                }
                
                Thread.Sleep(50);
            }
        }
    }
}
