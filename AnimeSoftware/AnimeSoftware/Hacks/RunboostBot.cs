using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using hazedumper;

namespace AnimeSoftware
{
    class RunboostBot
    {
        public static bool boosting = false;
        public static void Start()
        {
            while (true)
            {
                Thread.Sleep(1);

                if (!Properties.Settings.Default.runboostbot)
                    continue;

                if (!LocalPlayer.InGame)
                    continue;

                if (LocalPlayer.Health <= 0)
                    continue;

                Entity target = null;

                while ((DllImport.GetAsyncKeyState(Properties.Hotkey.Default.runboostbotKey) & 0x8000) != 0)
                {
                    if (target == null)
                    {
                        target = Aimbot.BestDistance();
                    }

                    boosting = true;

                    Vector3 position = target.Position;

                    if (target.Speed <= 0)
                    {
                        ClientCMD.Exec("-forward");
                    }
                    else
                    {
                        LocalPlayer.ViewAngleY = Aimbot.CalcAngle(LocalPlayer.ViewPosition, position).y;
                        ClientCMD.Exec("+forward");
                    }
                    Thread.Sleep(1);
                }

                if (boosting)
                {
                    ClientCMD.Exec("-forward");
                    boosting = false;
                }

                
            }
        }
    }
}
