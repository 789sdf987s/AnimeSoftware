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
            this.nickBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.lpNickTextBox = new System.Windows.Forms.TextBox();
            this.rlnButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nickBox
            // 
            this.nickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickBox.FormattingEnabled = true;
            this.nickBox.ItemHeight = 20;
            this.nickBox.Location = new System.Drawing.Point(12, 12);
            this.nickBox.Name = "nickBox";
            this.nickBox.Size = new System.Drawing.Size(199, 164);
            this.nickBox.TabIndex = 1;
            this.nickBox.DoubleClick += new System.EventHandler(this.nickBox_DoubleClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(223, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // lpNickTextBox
            // 
            this.lpNickTextBox.Location = new System.Drawing.Point(304, 121);
            this.lpNickTextBox.Name = "lpNickTextBox";
            this.lpNickTextBox.Size = new System.Drawing.Size(100, 20);
            this.lpNickTextBox.TabIndex = 3;
            // 
            // rlnButton
            // 
            this.rlnButton.Location = new System.Drawing.Point(304, 147);
            this.rlnButton.Name = "rlnButton";
            this.rlnButton.Size = new System.Drawing.Size(100, 25);
            this.rlnButton.TabIndex = 4;
            this.rlnButton.Text = "Read local name";
            this.rlnButton.UseVisualStyleBackColor = true;
            this.rlnButton.Click += new System.EventHandler(this.rlnButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(223, 119);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 25);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Change to";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // AnimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 186);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.rlnButton);
            this.Controls.Add(this.lpNickTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.nickBox);
            this.Name = "AnimeForm";
            this.Text = "AnimeSoftware";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nickBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox lpNickTextBox;
        private System.Windows.Forms.Button rlnButton;
        private System.Windows.Forms.Button changeButton;
    }
}

