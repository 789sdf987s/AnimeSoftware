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
                DialogResult result = MessageBox.Show("The game is not open.\nAlso make sure that you open the application as administrator.", "Can't attach to process", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Cancel:
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
                Thread.Sleep(100);
            }
            ScannedOffsets.Init();
            Start();
            
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
            foreach (Entity x in Entity.List().Where(x => x.isTeam))
            {
                Color teamColor = Color.Blue;
                Color statusColor;
                if (x.IsDead)
                    statusColor = Color.Yellow;
                else
                    statusColor = Color.Green;

                int ind = nickBox.Rows.Add(x.Index, x.Name, !x.IsDead);
                nickBox.Rows[ind].Cells[1].Style.ForeColor = teamColor;
                nickBox.Rows[ind].Cells[2].Style.ForeColor = statusColor;
            }
            foreach(Entity x in Entity.List().Where(x => !x.isTeam))
            {
                Color teamColor = Color.Red;
                Color statusColor;
                if (x.IsDead)
                    statusColor = Color.Yellow;
                else
                    statusColor = Color.Green;

                int ind = nickBox.Rows.Add(x.Index, x.Name, !x.IsDead);
                nickBox.Rows[ind].Cells[1].Style.ForeColor = teamColor;
                nickBox.Rows[ind].Cells[2].Style.ForeColor = statusColor;
            }
        }
        public static bool Init()
        {
            if (!Memory.OpenProcess("csgo"))
                return false;
            Thread.Sleep(100);
            if (!Memory.ProcessHandle())
                return false;
            Thread.Sleep(100);
            if (!Memory.GetModules())
                return false;
            return true;
        }



        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateNickBox();
        }



        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConVarManager.ChangeName(this.nickBox.SelectedRows[0].Cells[1].Value.ToString());
            }
            catch
            {
                ConVarManager.ChangeName(this.nickBox.SelectedCells[0].Value.ToString());
            }
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
            // idk how get UserID lol
        }

        private void AnimeForm_Shown(object sender, EventArgs e)
        {
            
            UpdateNickBox();

            InitCheckBox();
            InitHotkey();
        }

        public void InitCheckBox()
        {
            bhopCheckBox.Checked = Properties.Settings.Default.bhop;
            doorspammerCheckBox.Checked = Properties.Settings.Default.doorspammer;
            blockbotCheckBox.Checked = Properties.Settings.Default.blockbot;
        }
        public void InitHotkey()
        {
            blockbotButton.Text = ((Keys)Properties.Hotkey.Default.blockbotKey).ToString();
            doorspammerButton.Text = ((Keys)Properties.Hotkey.Default.doorspammerKey).ToString();
        }

        private void bhopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.bhop = bhopCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void doorspammerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.doorspammer = doorspammerCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void blockbotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.blockbot = blockbotCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void doorspammerButton_Click(object sender, EventArgs e)
        {
            doorspammerButton.Text = "Press key";
        }

        private void blockbotButton_Click(object sender, EventArgs e)
        {
            blockbotButton.Text = "Press key";
        }

        private void doorspammerButton_KeyUp(object sender, KeyEventArgs e)
        {
            Properties.Hotkey.Default.doorspammerKey = e.KeyValue;
            Properties.Hotkey.Default.Save();
            InitHotkey();
            label1.Focus();
        }

        private void blockbotButton_KeyUp(object sender, KeyEventArgs e)
        {
            Properties.Hotkey.Default.blockbotKey = e.KeyValue;
            Properties.Hotkey.Default.Save();
            InitHotkey();
            label1.Focus();
        }

        private void fullrefreshButton_Click(object sender, EventArgs e)
        {
            Checks.PreLoad();
            UpdateNickBox();
        }
    }
}
