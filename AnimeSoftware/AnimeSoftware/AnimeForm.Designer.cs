namespace AnimeSoftware
{
    partial class AnimeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.refreshButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.nickBox = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glowColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetButton = new System.Windows.Forms.Button();
            this.bhopCheckBox = new System.Windows.Forms.CheckBox();
            this.doorspammerCheckBox = new System.Windows.Forms.CheckBox();
            this.blockbotCheckBox = new System.Windows.Forms.CheckBox();
            this.doorspammerButton = new System.Windows.Forms.Button();
            this.blockbotButton = new System.Windows.Forms.Button();
            this.fullrefreshButton = new System.Windows.Forms.Button();
            this.namestealerCheckBox = new System.Windows.Forms.CheckBox();
            this.customnameTextBox = new System.Windows.Forms.TextBox();
            this.setupButton = new System.Windows.Forms.Button();
            this.runboostbotCheckBox = new System.Windows.Forms.CheckBox();
            this.runboostbotButton = new System.Windows.Forms.Button();
            this.autostrafeCheckBox = new System.Windows.Forms.CheckBox();
            this.nickBoxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stealNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voteKickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightspamButton = new System.Windows.Forms.CheckBox();
            this.trashControl = new System.Windows.Forms.TabControl();
            this.aimTab = new System.Windows.Forms.TabPage();
            this.fovLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fovTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.hitboxComboBox = new System.Windows.Forms.ComboBox();
            this.ffCheckBox = new System.Windows.Forms.CheckBox();
            this.aimbotCheckBox = new System.Windows.Forms.CheckBox();
            this.rscCheckBox = new System.Windows.Forms.CheckBox();
            this.smoothTrackBar = new System.Windows.Forms.TrackBar();
            this.smoothLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unlockButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nickBox)).BeginInit();
            this.nickBoxContextMenuStrip.SuspendLayout();
            this.trashControl.SuspendLayout();
            this.aimTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fovTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(173, 375);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 25);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(12, 375);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 25);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Steal Name";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(78, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "ハック\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "P2C";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.controlPanel.Controls.Add(this.closeButton);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(632, 45);
            this.controlPanel.TabIndex = 9;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(443, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nickBox
            // 
            this.nickBox.AllowUserToAddRows = false;
            this.nickBox.AllowUserToDeleteRows = false;
            this.nickBox.AllowUserToResizeRows = false;
            this.nickBox.BackgroundColor = System.Drawing.Color.White;
            this.nickBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nickBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.aliveColumn,
            this.glowColumn});
            this.nickBox.GridColor = System.Drawing.Color.Silver;
            this.nickBox.Location = new System.Drawing.Point(12, 51);
            this.nickBox.Name = "nickBox";
            this.nickBox.ReadOnly = true;
            this.nickBox.RowHeadersVisible = false;
            this.nickBox.Size = new System.Drawing.Size(317, 317);
            this.nickBox.TabIndex = 10;
            this.nickBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nickBox_CellClick);
            this.nickBox.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.nickBox_CellMouseUp);
            this.nickBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nickBox_MouseClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 30;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 185;
            // 
            // aliveColumn
            // 
            this.aliveColumn.HeaderText = "Alive";
            this.aliveColumn.Name = "aliveColumn";
            this.aliveColumn.ReadOnly = true;
            this.aliveColumn.Width = 60;
            // 
            // glowColumn
            // 
            this.glowColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.glowColumn.HeaderText = "Glow";
            this.glowColumn.Name = "glowColumn";
            this.glowColumn.ReadOnly = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(93, 374);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 25);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset name";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // bhopCheckBox
            // 
            this.bhopCheckBox.AutoSize = true;
            this.bhopCheckBox.Location = new System.Drawing.Point(335, 74);
            this.bhopCheckBox.Name = "bhopCheckBox";
            this.bhopCheckBox.Size = new System.Drawing.Size(53, 17);
            this.bhopCheckBox.TabIndex = 13;
            this.bhopCheckBox.Text = "BHop";
            this.bhopCheckBox.UseVisualStyleBackColor = true;
            this.bhopCheckBox.CheckedChanged += new System.EventHandler(this.bhopCheckBox_CheckedChanged);
            // 
            // doorspammerCheckBox
            // 
            this.doorspammerCheckBox.AutoSize = true;
            this.doorspammerCheckBox.Location = new System.Drawing.Point(335, 289);
            this.doorspammerCheckBox.Name = "doorspammerCheckBox";
            this.doorspammerCheckBox.Size = new System.Drawing.Size(93, 17);
            this.doorspammerCheckBox.TabIndex = 14;
            this.doorspammerCheckBox.Text = "DoorSpammer";
            this.doorspammerCheckBox.UseVisualStyleBackColor = true;
            this.doorspammerCheckBox.CheckedChanged += new System.EventHandler(this.doorspammerCheckBox_CheckedChanged);
            // 
            // blockbotCheckBox
            // 
            this.blockbotCheckBox.AutoSize = true;
            this.blockbotCheckBox.Location = new System.Drawing.Point(335, 333);
            this.blockbotCheckBox.Name = "blockbotCheckBox";
            this.blockbotCheckBox.Size = new System.Drawing.Size(69, 17);
            this.blockbotCheckBox.TabIndex = 15;
            this.blockbotCheckBox.Text = "BlockBot";
            this.blockbotCheckBox.UseVisualStyleBackColor = true;
            this.blockbotCheckBox.CheckedChanged += new System.EventHandler(this.blockbotCheckBox_CheckedChanged);
            // 
            // doorspammerButton
            // 
            this.doorspammerButton.Location = new System.Drawing.Point(335, 305);
            this.doorspammerButton.Name = "doorspammerButton";
            this.doorspammerButton.Size = new System.Drawing.Size(84, 23);
            this.doorspammerButton.TabIndex = 17;
            this.doorspammerButton.Text = "button2";
            this.doorspammerButton.UseVisualStyleBackColor = true;
            this.doorspammerButton.Click += new System.EventHandler(this.doorspammerButton_Click);
            this.doorspammerButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.doorspammerButton_KeyUp);
            // 
            // blockbotButton
            // 
            this.blockbotButton.Location = new System.Drawing.Point(335, 349);
            this.blockbotButton.Name = "blockbotButton";
            this.blockbotButton.Size = new System.Drawing.Size(84, 23);
            this.blockbotButton.TabIndex = 18;
            this.blockbotButton.Text = "button3";
            this.blockbotButton.UseVisualStyleBackColor = true;
            this.blockbotButton.Click += new System.EventHandler(this.blockbotButton_Click);
            this.blockbotButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.blockbotButton_KeyUp);
            // 
            // fullrefreshButton
            // 
            this.fullrefreshButton.Location = new System.Drawing.Point(254, 375);
            this.fullrefreshButton.Name = "fullrefreshButton";
            this.fullrefreshButton.Size = new System.Drawing.Size(75, 25);
            this.fullrefreshButton.TabIndex = 19;
            this.fullrefreshButton.Text = "Full refresh";
            this.fullrefreshButton.UseVisualStyleBackColor = true;
            this.fullrefreshButton.Click += new System.EventHandler(this.fullrefreshButton_Click);
            // 
            // namestealerCheckBox
            // 
            this.namestealerCheckBox.AutoSize = true;
            this.namestealerCheckBox.Location = new System.Drawing.Point(335, 51);
            this.namestealerCheckBox.Name = "namestealerCheckBox";
            this.namestealerCheckBox.Size = new System.Drawing.Size(87, 17);
            this.namestealerCheckBox.TabIndex = 20;
            this.namestealerCheckBox.Text = "NameStealer";
            this.namestealerCheckBox.UseVisualStyleBackColor = true;
            this.namestealerCheckBox.CheckedChanged += new System.EventHandler(this.namestealerCheckBox_CheckedChanged);
            // 
            // customnameTextBox
            // 
            this.customnameTextBox.Location = new System.Drawing.Point(12, 406);
            this.customnameTextBox.Name = "customnameTextBox";
            this.customnameTextBox.Size = new System.Drawing.Size(259, 20);
            this.customnameTextBox.TabIndex = 21;
            this.customnameTextBox.Text = "Custom name";
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(277, 406);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(52, 20);
            this.setupButton.TabIndex = 22;
            this.setupButton.Text = "Set";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // runboostbotCheckBox
            // 
            this.runboostbotCheckBox.AutoSize = true;
            this.runboostbotCheckBox.Location = new System.Drawing.Point(335, 378);
            this.runboostbotCheckBox.Name = "runboostbotCheckBox";
            this.runboostbotCheckBox.Size = new System.Drawing.Size(88, 17);
            this.runboostbotCheckBox.TabIndex = 23;
            this.runboostbotCheckBox.Text = "RunboostBot";
            this.runboostbotCheckBox.UseVisualStyleBackColor = true;
            this.runboostbotCheckBox.CheckedChanged += new System.EventHandler(this.runboostbotCheckBox_CheckedChanged);
            // 
            // runboostbotButton
            // 
            this.runboostbotButton.Location = new System.Drawing.Point(335, 395);
            this.runboostbotButton.Name = "runboostbotButton";
            this.runboostbotButton.Size = new System.Drawing.Size(84, 23);
            this.runboostbotButton.TabIndex = 24;
            this.runboostbotButton.Text = "button1";
            this.runboostbotButton.UseVisualStyleBackColor = true;
            this.runboostbotButton.Click += new System.EventHandler(this.runboostbotButton_Click);
            this.runboostbotButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.runboostbotButton_KeyUp);
            // 
            // autostrafeCheckBox
            // 
            this.autostrafeCheckBox.AutoSize = true;
            this.autostrafeCheckBox.Location = new System.Drawing.Point(335, 97);
            this.autostrafeCheckBox.Name = "autostrafeCheckBox";
            this.autostrafeCheckBox.Size = new System.Drawing.Size(76, 17);
            this.autostrafeCheckBox.TabIndex = 26;
            this.autostrafeCheckBox.Text = "AutoStrafe";
            this.autostrafeCheckBox.UseVisualStyleBackColor = true;
            this.autostrafeCheckBox.CheckedChanged += new System.EventHandler(this.autostrafeCheckBox_CheckedChanged);
            // 
            // nickBoxContextMenuStrip
            // 
            this.nickBoxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stealNameToolStripMenuItem,
            this.setGlowToolStripMenuItem,
            this.removeGlowToolStripMenuItem,
            this.voteKickToolStripMenuItem});
            this.nickBoxContextMenuStrip.Name = "nickBoxContextMenuStrip";
            this.nickBoxContextMenuStrip.Size = new System.Drawing.Size(148, 92);
            this.nickBoxContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.nickBoxContextMenuStrip_ItemClicked);
            // 
            // stealNameToolStripMenuItem
            // 
            this.stealNameToolStripMenuItem.Name = "stealNameToolStripMenuItem";
            this.stealNameToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.stealNameToolStripMenuItem.Text = "Steal Name";
            // 
            // setGlowToolStripMenuItem
            // 
            this.setGlowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.customToolStripMenuItem});
            this.setGlowToolStripMenuItem.Name = "setGlowToolStripMenuItem";
            this.setGlowToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.setGlowToolStripMenuItem.Text = "Set Glow";
            this.setGlowToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.setGlowToolStripMenuItem_DropDownItemClicked_1);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // removeGlowToolStripMenuItem
            // 
            this.removeGlowToolStripMenuItem.Name = "removeGlowToolStripMenuItem";
            this.removeGlowToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.removeGlowToolStripMenuItem.Text = "Remove Glow";
            // 
            // voteKickToolStripMenuItem
            // 
            this.voteKickToolStripMenuItem.Enabled = false;
            this.voteKickToolStripMenuItem.Name = "voteKickToolStripMenuItem";
            this.voteKickToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.voteKickToolStripMenuItem.Text = "Vote Kick";
            // 
            // rightspamButton
            // 
            this.rightspamButton.AutoSize = true;
            this.rightspamButton.Location = new System.Drawing.Point(335, 120);
            this.rightspamButton.Name = "rightspamButton";
            this.rightspamButton.Size = new System.Drawing.Size(135, 30);
            this.rightspamButton.TabIndex = 28;
            this.rightspamButton.Text = "Spam Glock-18/Famas\r\nScope/R8";
            this.rightspamButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightspamButton.UseVisualStyleBackColor = true;
            this.rightspamButton.CheckedChanged += new System.EventHandler(this.rightspamButton_CheckedChanged);
            // 
            // trashControl
            // 
            this.trashControl.Controls.Add(this.aimTab);
            this.trashControl.Location = new System.Drawing.Point(476, 55);
            this.trashControl.Name = "trashControl";
            this.trashControl.SelectedIndex = 0;
            this.trashControl.Size = new System.Drawing.Size(145, 371);
            this.trashControl.TabIndex = 29;
            // 
            // aimTab
            // 
            this.aimTab.Controls.Add(this.label5);
            this.aimTab.Controls.Add(this.smoothLabel);
            this.aimTab.Controls.Add(this.smoothTrackBar);
            this.aimTab.Controls.Add(this.rscCheckBox);
            this.aimTab.Controls.Add(this.fovLabel);
            this.aimTab.Controls.Add(this.label4);
            this.aimTab.Controls.Add(this.fovTrackBar);
            this.aimTab.Controls.Add(this.label3);
            this.aimTab.Controls.Add(this.hitboxComboBox);
            this.aimTab.Controls.Add(this.ffCheckBox);
            this.aimTab.Controls.Add(this.aimbotCheckBox);
            this.aimTab.Location = new System.Drawing.Point(4, 22);
            this.aimTab.Name = "aimTab";
            this.aimTab.Padding = new System.Windows.Forms.Padding(3);
            this.aimTab.Size = new System.Drawing.Size(137, 345);
            this.aimTab.TabIndex = 1;
            this.aimTab.Text = "Aimbot";
            this.aimTab.UseVisualStyleBackColor = true;
            // 
            // fovLabel
            // 
            this.fovLabel.Location = new System.Drawing.Point(20, 158);
            this.fovLabel.Name = "fovLabel";
            this.fovLabel.Size = new System.Drawing.Size(100, 13);
            this.fovLabel.TabIndex = 6;
            this.fovLabel.Text = "0";
            this.fovLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "FOV";
            // 
            // fovTrackBar
            // 
            this.fovTrackBar.AutoSize = false;
            this.fovTrackBar.BackColor = System.Drawing.Color.White;
            this.fovTrackBar.Location = new System.Drawing.Point(20, 130);
            this.fovTrackBar.Maximum = 5000;
            this.fovTrackBar.Name = "fovTrackBar";
            this.fovTrackBar.Size = new System.Drawing.Size(100, 27);
            this.fovTrackBar.TabIndex = 4;
            this.fovTrackBar.Scroll += new System.EventHandler(this.fovTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bone";
            // 
            // hitboxComboBox
            // 
            this.hitboxComboBox.FormattingEnabled = true;
            this.hitboxComboBox.Location = new System.Drawing.Point(20, 83);
            this.hitboxComboBox.Name = "hitboxComboBox";
            this.hitboxComboBox.Size = new System.Drawing.Size(82, 21);
            this.hitboxComboBox.TabIndex = 2;
            this.hitboxComboBox.SelectedIndexChanged += new System.EventHandler(this.hitboxComboBox_SelectedIndexChanged);
            // 
            // ffCheckBox
            // 
            this.ffCheckBox.AutoSize = true;
            this.ffCheckBox.Location = new System.Drawing.Point(20, 29);
            this.ffCheckBox.Name = "ffCheckBox";
            this.ffCheckBox.Size = new System.Drawing.Size(82, 17);
            this.ffCheckBox.TabIndex = 1;
            this.ffCheckBox.Text = "Friendly Fire";
            this.ffCheckBox.UseVisualStyleBackColor = true;
            this.ffCheckBox.CheckedChanged += new System.EventHandler(this.ffCheckBox_CheckedChanged);
            // 
            // aimbotCheckBox
            // 
            this.aimbotCheckBox.AutoSize = true;
            this.aimbotCheckBox.Location = new System.Drawing.Point(6, 6);
            this.aimbotCheckBox.Name = "aimbotCheckBox";
            this.aimbotCheckBox.Size = new System.Drawing.Size(59, 17);
            this.aimbotCheckBox.TabIndex = 0;
            this.aimbotCheckBox.Text = "Enable";
            this.aimbotCheckBox.UseVisualStyleBackColor = true;
            this.aimbotCheckBox.CheckedChanged += new System.EventHandler(this.aimbotCheckBox_CheckedChanged);
            // 
            // rscCheckBox
            // 
            this.rscCheckBox.AutoSize = true;
            this.rscCheckBox.Location = new System.Drawing.Point(20, 47);
            this.rscCheckBox.Name = "rscCheckBox";
            this.rscCheckBox.Size = new System.Drawing.Size(48, 17);
            this.rscCheckBox.TabIndex = 7;
            this.rscCheckBox.Text = "RSC";
            this.rscCheckBox.UseVisualStyleBackColor = true;
            this.rscCheckBox.CheckedChanged += new System.EventHandler(this.rscCheckBox_CheckedChanged);
            // 
            // smoothTrackBar
            // 
            this.smoothTrackBar.AutoSize = false;
            this.smoothTrackBar.BackColor = System.Drawing.Color.White;
            this.smoothTrackBar.Location = new System.Drawing.Point(20, 196);
            this.smoothTrackBar.Maximum = 10000;
            this.smoothTrackBar.Minimum = 1;
            this.smoothTrackBar.Name = "smoothTrackBar";
            this.smoothTrackBar.Size = new System.Drawing.Size(100, 27);
            this.smoothTrackBar.TabIndex = 8;
            this.smoothTrackBar.Value = 1;
            this.smoothTrackBar.Scroll += new System.EventHandler(this.smoothTrackBar_Scroll);
            // 
            // smoothLabel
            // 
            this.smoothLabel.Location = new System.Drawing.Point(20, 222);
            this.smoothLabel.Name = "smoothLabel";
            this.smoothLabel.Size = new System.Drawing.Size(100, 17);
            this.smoothLabel.TabIndex = 9;
            this.smoothLabel.Text = "0";
            this.smoothLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Speed";
            // 
            // unlockButton
            // 
            this.unlockButton.Location = new System.Drawing.Point(464, 419);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(10, 10);
            this.unlockButton.TabIndex = 31;
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // AnimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 434);
            this.ControlBox = false;
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.trashControl);
            this.Controls.Add(this.rightspamButton);
            this.Controls.Add(this.autostrafeCheckBox);
            this.Controls.Add(this.runboostbotButton);
            this.Controls.Add(this.runboostbotCheckBox);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.customnameTextBox);
            this.Controls.Add(this.namestealerCheckBox);
            this.Controls.Add(this.fullrefreshButton);
            this.Controls.Add(this.blockbotButton);
            this.Controls.Add(this.doorspammerButton);
            this.Controls.Add(this.blockbotCheckBox);
            this.Controls.Add(this.doorspammerCheckBox);
            this.Controls.Add(this.bhopCheckBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.nickBox);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.refreshButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AnimeForm";
            this.Text = "AnimeSoftware";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.AnimeForm_Shown);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nickBox)).EndInit();
            this.nickBoxContextMenuStrip.ResumeLayout(false);
            this.trashControl.ResumeLayout(false);
            this.aimTab.ResumeLayout(false);
            this.aimTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fovTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView nickBox;
        private System.Windows.Forms.Button resetButton;
        public System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.CheckBox bhopCheckBox;
        private System.Windows.Forms.CheckBox doorspammerCheckBox;
        private System.Windows.Forms.CheckBox blockbotCheckBox;
        private System.Windows.Forms.Button doorspammerButton;
        private System.Windows.Forms.Button blockbotButton;
        private System.Windows.Forms.Button fullrefreshButton;
        private System.Windows.Forms.CheckBox namestealerCheckBox;
        private System.Windows.Forms.TextBox customnameTextBox;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.CheckBox runboostbotCheckBox;
        private System.Windows.Forms.Button runboostbotButton;
        private System.Windows.Forms.CheckBox autostrafeCheckBox;
        private System.Windows.Forms.ContextMenuStrip nickBoxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem stealNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voteKickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGlowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glowColumn;
        private System.Windows.Forms.CheckBox rightspamButton;
        private System.Windows.Forms.TabControl trashControl;
        private System.Windows.Forms.TabPage aimTab;
        private System.Windows.Forms.CheckBox aimbotCheckBox;
        private System.Windows.Forms.TrackBar fovTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hitboxComboBox;
        private System.Windows.Forms.CheckBox ffCheckBox;
        private System.Windows.Forms.Label fovLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label smoothLabel;
        private System.Windows.Forms.TrackBar smoothTrackBar;
        private System.Windows.Forms.CheckBox rscCheckBox;
        private System.Windows.Forms.Button unlockButton;
    }
}

