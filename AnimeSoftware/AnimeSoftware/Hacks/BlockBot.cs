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

                    if (speed > 20 || Math.Abs(angle.y) > 15)
                    {
                        if (angle.y < 0.0f)
                        {
                            Memory.Write<int>(Memory.Client + signatures.dwForceLeft, 4);
                            Memory.Write<int>(Memory.Client + signatures.dwForceRight, 5);
                        }

                        else if (angle.y > 0.0f)
                        {
                            Memory.Write<int>(Memory.Client + signatures.dwForceRight, 4);
                            Memory.Write<int>(Memory.Client + signatures.dwForceLeft, 5);
                        }
                    }
                    else
                    {
                        Memory.Write<int>(Memory.Client + signatures.dwForceLeft, 4);
                        Memory.Write<int>(Memory.Client + signatures.dwForceRight, 4);
                    }


                    Thread.Sleep(25);
                }
                if (blocking == true)
                {
                    Memory.Write<int>(Memory.Client + signatures.dwForceLeft, 4);
                    Memory.Write<int>(Memory.Client + signatures.dwForceRight, 4);
                    blocking = false;
                }

                Thread.Sleep(1);
            }
        }
    }
}
