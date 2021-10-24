
namespace PomodoroGUI
{
    partial class PomodoroWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.whatIsHappeningLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.WhatToDoTextBox = new System.Windows.Forms.TextBox();
            this.WorkTimeChooser = new System.Windows.Forms.NumericUpDown();
            this.BreakTimeChooser = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(319, 330);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "",
            "",
            "",
            ""});
            this.checkedListBox1.Location = new System.Drawing.Point(130, 209);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox1.Size = new System.Drawing.Size(17, 72);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar1.Location = new System.Drawing.Point(254, 301);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // workTimer
            // 
            this.workTimer.Interval = 1000;
            this.workTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(153, 209);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(410, 89);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Timer";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 1000;
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // whatIsHappeningLabel
            // 
            this.whatIsHappeningLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.whatIsHappeningLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.whatIsHappeningLabel.Location = new System.Drawing.Point(153, 160);
            this.whatIsHappeningLabel.Name = "whatIsHappeningLabel";
            this.whatIsHappeningLabel.Size = new System.Drawing.Size(410, 49);
            this.whatIsHappeningLabel.TabIndex = 4;
            this.whatIsHappeningLabel.Text = "Press Start ";
            this.whatIsHappeningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StopButton.Location = new System.Drawing.Point(319, 330);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // WhatToDoTextBox
            // 
            this.WhatToDoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WhatToDoTextBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WhatToDoTextBox.Location = new System.Drawing.Point(153, 105);
            this.WhatToDoTextBox.Name = "WhatToDoTextBox";
            this.WhatToDoTextBox.PlaceholderText = "Write what to do here";
            this.WhatToDoTextBox.Size = new System.Drawing.Size(410, 52);
            this.WhatToDoTextBox.TabIndex = 6;
            this.WhatToDoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WhatToDoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WhatToDoTextBox_KeyPress);
            // 
            // WorkTimeChooser
            // 
            this.WorkTimeChooser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WorkTimeChooser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkTimeChooser.Location = new System.Drawing.Point(254, 65);
            this.WorkTimeChooser.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.WorkTimeChooser.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WorkTimeChooser.Name = "WorkTimeChooser";
            this.WorkTimeChooser.Size = new System.Drawing.Size(44, 34);
            this.WorkTimeChooser.TabIndex = 7;
            this.WorkTimeChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkTimeChooser.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // BreakTimeChooser
            // 
            this.BreakTimeChooser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BreakTimeChooser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BreakTimeChooser.Location = new System.Drawing.Point(413, 65);
            this.BreakTimeChooser.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BreakTimeChooser.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BreakTimeChooser.Name = "BreakTimeChooser";
            this.BreakTimeChooser.Size = new System.Drawing.Size(44, 34);
            this.BreakTimeChooser.TabIndex = 8;
            this.BreakTimeChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BreakTimeChooser.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PomodoroWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.BreakTimeChooser);
            this.Controls.Add(this.WorkTimeChooser);
            this.Controls.Add(this.WhatToDoTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.whatIsHappeningLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.startButton);
            this.Name = "PomodoroWindow";
            this.Text = "Pomodoro";
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer workTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer breakTimer;
        private System.Windows.Forms.Label whatIsHappeningLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox WhatToDoTextBox;
        private System.Windows.Forms.NumericUpDown WorkTimeChooser;
        private System.Windows.Forms.NumericUpDown BreakTimeChooser;
    }
}

