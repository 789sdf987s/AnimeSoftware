using System;
using hazedumper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AnimeSoftware
{
    class BlockBot
    {
        public static bool blocking = false;
        public static void Start()
        {
            while (true)
            {
                Thread.Sleep(1);

                if (!Properties.Settings.Default.blockbot)
                    continue;

                if (!LocalPlayer.InGame)
                    continue;

                if (LocalPlayer.Health <= 0)
                    continue;

                Entity target = null;

                while ((DllImport.GetAsyncKeyState(Properties.Hotkey.Default.blockbotKey) & 0x8000) != 0)
                {
                    if (target == null)
                    {
                        target = Aimbot.BestDistance();
                    }

                    blocking = true;
                    float speed = target.Speed;

                    

                    Vector3 angle = Aimbot.CalcAngle(LocalPlayer.ViewPosition, target.Position);
                    angle.y -= LocalPlayer.ViewAngle.y;
                    angle = Aimbot.NormalizedAngle(angle);

                    if (speed > 10 || Math.Abs(angle.y) > 10)
                    {
                        if (angle.y < 0.0f)
                        {
                            ClientCMD.Exec("-moveleft");
                            Thread.Sleep(1);
                            ClientCMD.Exec("+moveright");
                        }

                        else if (angle.y > 0.0f)
                        {
                            ClientCMD.Exec("-moveright");
                            Thread.Sleep(1);
                            ClientCMD.Exec("+moveleft");
                        }
                }
                    else
                {
                    ClientCMD.Exec("-moveright");
                    Thread.Sleep(1);
                    ClientCMD.Exec("-moveleft");
                }


                Thread.Sleep(1);
                }
                if (blocking == true)
                {
                    ClientCMD.Exec("-moveright");
                    Thread.Sleep(1);
                    ClientCMD.Exec("-moveleft");
                    blocking = false;
                }

                
            }
        }
    }
}
