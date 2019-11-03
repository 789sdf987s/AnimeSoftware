using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using hazedumper;

namespace AnimeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Init())
            {
                Thread.Sleep(100);
            }
            Console.WriteLine(String.Format("Succses: pHandle is {0}", Memory.pHandle));

            Thread blockbotThread = new Thread(new ThreadStart(BlockBot.Start))
            {
                Priority = ThreadPriority.Highest,
                IsBackground = true,
            };
            blockbotThread.Start();

            while (true)
            {
                Thread.Sleep(10);
            }
        }

        public static void LogVector(Vector3 src)
        {
            Console.WriteLine(String.Format("X: {0}. Y: {1}. Z: {2}.", src.x, src.y, src.z));
        }
        public static bool Init()
        {
            if (!Memory.OpenProcess("csgo"))
                return false;
            Thread.Sleep(500);
            if (!Memory.ProcessHandle())
                return false;
            Thread.Sleep(500);
            if (!Memory.GetModules())
                return false;
            return true;
        }
    }
}
