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
                Console.Write("Can't attach process.");
                Thread.Sleep(100);
            }
            Console.WriteLine(String.Format("Succses: pHandle is {0}", Memory.pHandle));

            ScannedOffsets.Init();
            Start();

            while (true)
            {
                Thread.Sleep(10);
            }
        }

        public static void Start()
        {
            Thread blockbotThread = new Thread(new ThreadStart(BlockBot.Start))
            {
                Priority = ThreadPriority.Highest,
                IsBackground = true,
            };
            blockbotThread.Start();

            Thread bhopThread = new Thread(new ThreadStart(BHop.Start))
            {
                Priority = ThreadPriority.Highest,
                IsBackground = true,
            };
            bhopThread.Start();

            Thread doorspamThread = new Thread(new ThreadStart(DoorSpam.Start))
            {
                Priority = ThreadPriority.Highest,
                IsBackground = true,
            };
            doorspamThread.Start();
        }
        public static bool Init()
        {
            if (!Memory.OpenProcess("csgo"))
                return false;
            Console.WriteLine("Process opened");
            Thread.Sleep(500);
            if (!Memory.ProcessHandle())
                return false;
            Console.WriteLine("Process handled");
            Thread.Sleep(500);
            if (!Memory.GetModules())
                return false;
            Console.WriteLine("Succses");
            return true;
        }
    }
}
