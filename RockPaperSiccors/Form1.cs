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
using RockPaperScissors;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private Logic _gameLogic;
        public Form1()
        {
            InitializeComponent();
            _gameLogic = new Logic();
        }

        private async void Choose_Click(object sender, EventArgs e)
        {
            ClearTexts();
            await PutTaskDelay(100);
            Button button = (Button)sender;
            _gameLogic.Choose(button.Text);
            _gameLogic.Play();
            PlayerChoiceText.Text = _gameLogic._playerChoice;
            await PutTaskDelay(250);
            ComputerChoiceText.Text = _gameLogic._computerChoice;
            await PutTaskDelay(250);
            WinLoseOrTieText.Text = _gameLogic._outcome;
            UpdateScoreboard();
            UpdateRecentGames();
        }

        private void ClearTexts()
        {
            WinLoseOrTieText.Clear();
            PlayerChoiceText.Clear();
            ComputerChoiceText.Clear();
        }

        private async Task PutTaskDelay(int time)
        {
            await Task.Delay(time);
        }

        private void UpdateScoreboard()
        {
            PlayerScore.Text = _gameLogic.PlayerWins.ToString();
            ComputerScore.Text = _gameLogic.ComputerWins.ToString();
        }

        private void UpdateRecentGames()
        {

            if (RecentGames.Text == "")
            {
                RecentGames.Text = _gameLogic._outcome;
            }
            else
            {
                RecentGames.AppendText(Environment.NewLine + _gameLogic._outcome);
            }
        }
    }
}
