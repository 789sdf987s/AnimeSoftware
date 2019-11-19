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

            if (!LocalPlayer.InGame)
                return;

            while (Properties.Settings.Default.namestealer)
            {
                foreach (Entity x in Entity.List())
                {
                    if (!Properties.Settings.Default.namestealer)
                        break;
                    ConVarManager.ChangeName(x.Name);
                    Thread.Sleep(250);
                }
            }


        }
    }


}
