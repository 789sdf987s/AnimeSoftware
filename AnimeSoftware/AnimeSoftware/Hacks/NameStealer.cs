using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class NameStealer
    {
        public static void Start()
        {
            while (true)
            {
                Thread.Sleep(25);

                if (!LocalPlayer.InGame)
                    continue;

                while (Properties.Settings.Default.namestealer)
                {
                    foreach(Entity x in Entity.List())
                    {
                        ConVarManager.ChangeName(x.Name);
                        Thread.Sleep(250);
                    }
                }

                
            }
        }

    }
}
