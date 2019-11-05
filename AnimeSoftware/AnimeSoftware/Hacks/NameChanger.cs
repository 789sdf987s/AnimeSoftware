using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class NameChanger
    {
        public static void Change(string name)
        {
            ConVar nick = new ConVar("name");
            nick.ClearCallbacks();
            ClientCMD.Exec("name \"" + name + " \"");

        }
    }
}
