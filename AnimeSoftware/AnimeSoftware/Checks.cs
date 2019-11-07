using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class Checks
    {
        public static bool Update = false;
        public static void Start()
        {
            while (true)
            {
                if (!LocalPlayer.InGame)
                    Update = false;

                if (LocalPlayer.InGame && !Update)
                {

                    ForceUpdate();
                   
                }
                Thread.Sleep(1000);
            }
        }
        public static void ForceUpdate()
        {

            LocalPlayer.GetIndex();
            LocalPlayer.GetName();
            Update = true;
        }
    }
}
