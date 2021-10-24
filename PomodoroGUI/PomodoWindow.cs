using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PomodoroLogic;

namespace PomodoroGUI
{
    public partial class PomodoroWindow : Form
    {
        private Pomodoro _pomodoro;
        private TimeSpan _workTimer;
        private TimeSpan _breakTimer;
        private int WORK_TIME; // Justera så det blir minuter där det ska vara
        private int BREAK_TIME; // Justera så det blir minuter där det ska vara
        public PomodoroWindow()
        {
            InitializeComponent();
            _pomodoro = new Pomodoro();
            SetStandardValues();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_workTimer.TotalSeconds > 0)
            {
                _workTimer -= TimeSpan.FromSeconds(1);
                timeLabel.Text = _workTimer.ToString();
                ProgressBarWork();
            }
            else
            {
                workTimer.Stop();
                SystemSounds.Asterisk.Play();
                checkedListBox1.SetItemChecked(_pomodoro.Ticks, true);
                _pomodoro.Ticks++;
                if (_pomodoro.CheckTicksAre4())
                {
                    timeLabel.Text = "Time's up!";
                    progressBar1.Maximum = BREAK_TIME * 60;
                    progressBar1.Value = 0;
                    breakTimer.Start();
                    whatIsHappeningLabel.Text = "BREAK";
                    _workTimer = TimeSpan.FromMinutes(WORK_TIME);
                    MessageBox.Show($"Take a break for {BREAK_TIME} minutes.", "Break!");
                }
                else
                {
                    timeLabel.Text = "You are done!";
                    _pomodoro.ResetTicks();
                    MessageBox.Show("Good job!", "DONE!");
                    SetStandardValues();
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            WhatToDoTextBox.ReadOnly = true;

            SetTimers();

            workTimer.Start();
            whatIsHappeningLabel.Text = "WORK";
            startButton.Visible = false;
            StopButton.Visible = true;
        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {
            if (_breakTimer.TotalSeconds > 0)
            {
                _breakTimer -= TimeSpan.FromSeconds(1);
                timeLabel.Text = _breakTimer.ToString();
                ProgressBarWork();
            }
            else
            {
                breakTimer.Stop();
                timeLabel.Text = "Time's up!";
                SystemSounds.Hand.Play();
                progressBar1.Maximum = WORK_TIME * 60;
                progressBar1.Value = 0;
                workTimer.Start();
                whatIsHappeningLabel.Text = "WORK";
                _breakTimer = TimeSpan.FromMinutes(BREAK_TIME);
                MessageBox.Show("Time for work again", "Work!");
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            SetStandardValues();
        }

        private void SetStandardValues()
        {
            startButton.Visible = true;
            StopButton.Visible = false;
            WhatToDoTextBox.ReadOnly = false;

            breakTimer.Stop();
            workTimer.Stop();
            progressBar1.Value = 0;

            whatIsHappeningLabel.Text = "Press Start";
            timeLabel.Text = "Timer";
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void ProgressBarWork()
        {
            progressBar1.PerformStep();
        }

        private void SetTimers()
        {
            WORK_TIME = (int)WorkTimeChooser.Value;
            BREAK_TIME = (int)BreakTimeChooser.Value;
            progressBar1.Maximum = WORK_TIME * 60;
            progressBar1.Step = 1;
            _breakTimer = TimeSpan.FromMinutes(BREAK_TIME);
            _workTimer = TimeSpan.FromMinutes(WORK_TIME);
        }

        private void WhatToDoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;
            if (breakTimer.Enabled || workTimer.Enabled) return;
            startButton_Click(sender, e);
        }
    }
}
