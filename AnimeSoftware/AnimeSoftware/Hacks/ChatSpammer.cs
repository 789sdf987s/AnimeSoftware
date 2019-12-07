using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class ChatSpammer
    {
        public static void ChatCleaner()
        {
            while (Properties.Settings.Default.chatcleaner)
            {
                Thread.Sleep(100);

                ClientCMD.Exec("say \"﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽﷽ ﷽﷽\"");
            }
        }
    }
}
