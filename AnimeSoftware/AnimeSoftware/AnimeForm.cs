using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using hazedumper;

namespace AnimeSoftware
{
    public partial class AnimeForm : Form
    {
        public AnimeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (!Init())
            {
                Console.Write("Can't attach process.");
                Thread.Sleep(100);
            }
            Console.WriteLine(String.Format("Succses: pHandle is {0}", Memory.pHandle));
            Console.WriteLine("vstdlib: " + Memory.vstdlib);
            ScannedOffsets.Init();
            Entity.List();
            Start();
            
            Thread.Sleep(100);
            UpdateNickBox();
            
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
            //bhopThread.Start();

            Thread doorspamThread = new Thread(new ThreadStart(DoorSpam.Start))
            {
                Priority = ThreadPriority.Highest,
                IsBackground = true,
            };
            doorspamThread.Start();

            Thread hotkeyThread = new Thread(new ThreadStart(AnimeForm.Hotkey))
            {
                Priority = ThreadPriority.Highest,
                IsBackground = true,
            };
            hotkeyThread.Start();
        }

        public static void Hotkey()
        {
            while (true)
            {
                if ((DllImport.GetAsyncKeyState(Properties.Hotkey.Default.defaultNick) & 0x8000) != 0)
                {
                    AnimeForm af = new AnimeForm();
                    NameChanger.Change(af.lpNickTextBox.Text);
                    Console.WriteLine("Change to " + af.lpNickTextBox.Text);
                    af.UpdateNickBox();
                    Thread.Sleep(250);
                }
                Thread.Sleep(50);
            }
        }
        public void UpdateNickBox()
        {
            nickBox.Items.Clear();
            if (!LocalPlayer.InGame)
                return;

            nickBox.Items.Add(LocalPlayer.Name);
            foreach(Entity x in Entity.List())
            {
                if (!x.isTeam)
                    continue;

                nickBox.Items.Add(x.Name);
            }
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

        private void nickBox_DoubleClick(object sender, EventArgs e)
        {
            NameChanger.Change(nickBox.SelectedItem.ToString());
            UpdateNickBox();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateNickBox();
        }

        private void rlnButton_Click(object sender, EventArgs e)
        {
            lpNickTextBox.Text = LocalPlayer.Name;
            Thread.Sleep(1);
            UpdateNickBox();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            NameChanger.Change(lpNickTextBox.Text);
            Thread.Sleep(1);
            UpdateNickBox();
        }
    }
}
