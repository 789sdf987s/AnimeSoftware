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
            this.resetButton = new System.Windows.Forms.Button();
            this.kickButton = new System.Windows.Forms.Button();
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
            this.chckVersion = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nickBox)).BeginInit();
            this.nickBoxContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(414, 63);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 25);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(324, 63);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(463, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 120);
            this.label1.TabIndex = 6;
            this.label1.Text = "ハ\r\nッ\r\nク\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(467, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 120);
            this.label2.TabIndex = 7;
            this.label2.Text = "P\r\n2\r\nC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.controlPanel.Controls.Add(this.chckVersion);
            this.controlPanel.Controls.Add(this.closeButton);
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(509, 45);
            this.controlPanel.TabIndex = 9;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(474, 12);
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
            this.aliveColumn});
            this.nickBox.GridColor = System.Drawing.Color.Silver;
            this.nickBox.Location = new System.Drawing.Point(12, 51);
            this.nickBox.Name = "nickBox";
            this.nickBox.ReadOnly = true;
            this.nickBox.RowHeadersVisible = false;
            this.nickBox.Size = new System.Drawing.Size(294, 317);
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
            this.nameColumn.Width = 160;
            // 
            // aliveColumn
            // 
            this.aliveColumn.HeaderText = "Alive";
            this.aliveColumn.Name = "aliveColumn";
            this.aliveColumn.ReadOnly = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(324, 124);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 25);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset name";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // kickButton
            // 
            this.kickButton.Enabled = false;
            this.kickButton.Location = new System.Drawing.Point(324, 94);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(75, 25);
            this.kickButton.TabIndex = 12;
            this.kickButton.Text = "Vote kick";
            this.kickButton.UseVisualStyleBackColor = true;
            this.kickButton.Click += new System.EventHandler(this.kickButton_Click);
            // 
            // bhopCheckBox
            // 
            this.bhopCheckBox.AutoSize = true;
            this.bhopCheckBox.Location = new System.Drawing.Point(324, 212);
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
            this.doorspammerCheckBox.Location = new System.Drawing.Point(324, 258);
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
            this.blockbotCheckBox.Location = new System.Drawing.Point(324, 302);
            this.blockbotCheckBox.Name = "blockbotCheckBox";
            this.blockbotCheckBox.Size = new System.Drawing.Size(69, 17);
            this.blockbotCheckBox.TabIndex = 15;
            this.blockbotCheckBox.Text = "BlockBot";
            this.blockbotCheckBox.UseVisualStyleBackColor = true;
            this.blockbotCheckBox.CheckedChanged += new System.EventHandler(this.blockbotCheckBox_CheckedChanged);
            // 
            // doorspammerButton
            // 
            this.doorspammerButton.Location = new System.Drawing.Point(324, 274);
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
            this.blockbotButton.Location = new System.Drawing.Point(324, 318);
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
            this.fullrefreshButton.Location = new System.Drawing.Point(414, 94);
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
            this.namestealerCheckBox.Location = new System.Drawing.Point(324, 189);
            this.namestealerCheckBox.Name = "namestealerCheckBox";
            this.namestealerCheckBox.Size = new System.Drawing.Size(87, 17);
            this.namestealerCheckBox.TabIndex = 20;
            this.namestealerCheckBox.Text = "NameStealer";
            this.namestealerCheckBox.UseVisualStyleBackColor = true;
            this.namestealerCheckBox.CheckedChanged += new System.EventHandler(this.namestealerCheckBox_CheckedChanged);
            // 
            // customnameTextBox
            // 
            this.customnameTextBox.Location = new System.Drawing.Point(12, 374);
            this.customnameTextBox.Name = "customnameTextBox";
            this.customnameTextBox.Size = new System.Drawing.Size(236, 20);
            this.customnameTextBox.TabIndex = 21;
            this.customnameTextBox.Text = "Custom name";
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(254, 373);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(52, 23);
            this.setupButton.TabIndex = 22;
            this.setupButton.Text = "Set";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // runboostbotCheckBox
            // 
            this.runboostbotCheckBox.AutoSize = true;
            this.runboostbotCheckBox.Location = new System.Drawing.Point(324, 347);
            this.runboostbotCheckBox.Name = "runboostbotCheckBox";
            this.runboostbotCheckBox.Size = new System.Drawing.Size(88, 17);
            this.runboostbotCheckBox.TabIndex = 23;
            this.runboostbotCheckBox.Text = "RunboostBot";
            this.runboostbotCheckBox.UseVisualStyleBackColor = true;
            this.runboostbotCheckBox.CheckedChanged += new System.EventHandler(this.runboostbotCheckBox_CheckedChanged);
            // 
            // runboostbotButton
            // 
            this.runboostbotButton.Location = new System.Drawing.Point(324, 364);
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
            this.autostrafeCheckBox.Location = new System.Drawing.Point(324, 235);
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
            // chckVersion
            // 
            this.chckVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chckVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckVersion.Location = new System.Drawing.Point(381, 12);
            this.chckVersion.Name = "chckVersion";
            this.chckVersion.Size = new System.Drawing.Size(87, 23);
            this.chckVersion.TabIndex = 27;
            this.chckVersion.Text = "Check update";
            this.chckVersion.UseVisualStyleBackColor = false;
            this.chckVersion.Click += new System.EventHandler(this.chckVersion_Click);
            // 
            // AnimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 399);
            this.ControlBox = false;
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
            this.Controls.Add(this.kickButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.nickBox);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.refreshButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AnimeForm";
            this.Text = "AnimeSoftware";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.AnimeForm_Shown);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nickBox)).EndInit();
            this.nickBoxContextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Button kickButton;
        public System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.CheckBox bhopCheckBox;
        private System.Windows.Forms.CheckBox doorspammerCheckBox;
        private System.Windows.Forms.CheckBox blockbotCheckBox;
        private System.Windows.Forms.Button doorspammerButton;
        private System.Windows.Forms.Button blockbotButton;
        private System.Windows.Forms.Button fullrefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliveColumn;
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
        private System.Windows.Forms.Button chckVersion;
    }
}

