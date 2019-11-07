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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        

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
            Start();
            Checks.ForceUpdate();
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

            Thread ChecksThread = new Thread(new ThreadStart(Checks.Start))
            {
                Priority = ThreadPriority.Highest,
                IsBackground = true,
            };
            ChecksThread.Start();
        }


        
        public void UpdateNickBox()
        {
            nickBox.Rows.Clear();
            if (!LocalPlayer.InGame)
                return;
            nickBox.Rows.Add(LocalPlayer.Index, LocalPlayer.Name);
            foreach (Entity x in Entity.List())
            {
                Color cellColor;
                if (!x.isTeam)
                    cellColor = Color.Red;
                else
                    cellColor = Color.Blue;

                nickBox.Rows[nickBox.Rows.Add(x.Index, x.Name)].DefaultCellStyle.ForeColor = cellColor;
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



        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateNickBox();
        }



        private void changeButton_Click(object sender, EventArgs e)
        {
            ConVarManager.ChangeName(this.nickBox.SelectedRows[0].Cells[1].Value.ToString());
            UpdateNickBox();
        }

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DllImport.ReleaseCapture();
                DllImport.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void nickBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nickBox.Rows[e.RowIndex].Selected = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ConVarManager.ChangeName(LocalPlayer.Name);
            UpdateNickBox();
        }

        private void kickButton_Click(object sender, EventArgs e)
        {

        }
    }
}
