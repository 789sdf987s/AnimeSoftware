using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class ConVarManager
    {
        public static void ChangeName(string name)
        {
            ConVar nick = new ConVar("name");
            nick.ClearCallbacks();
            ClientCMD.Exec("name \"" + name + " \"");

        }

        public static void VoteKick(string id)
        {
            //ConVar vote = new ConVar("vote");
            //vote.ClearCallbacks();
            ClientCMD.Exec("vote kick \"" + id + " \"");

        }
    }
}
