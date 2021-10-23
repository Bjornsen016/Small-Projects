using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Logic
    {
        private readonly string[] _choices = {"Rock", "Paper", "Scissors"};
        public string _playerChoice { get; private set; }
        public string _computerChoice { get; private set; }
        public string _outcome { get; private set; }
        public int PlayerWins{ get; private set; }
        public int ComputerWins{ get; private set; }

        private readonly Dictionary<int, string> _winLoseTieDirectory = new Dictionary<int, string>();

        public Logic()
        {
            _winLoseTieDirectory.Add(0,"Tie");
            _winLoseTieDirectory.Add(1,"Win");
            _winLoseTieDirectory.Add(2,"Lose");
            PlayerWins = 0;
            ComputerWins = 0;
        }

        public void Choose(string choice)
        {
            if (CheckChoiceCorrect(choice)) _playerChoice = choice;
        }

        private void ComputerChoose()
        {
            Random rand = new Random();
            _computerChoice = _choices[rand.Next(0, 2)];
        }

        public void Play()
        {
            ComputerChoose();

            int winOrLoose = CheckWinOrLoose();

            _outcome = _winLoseTieDirectory[winOrLoose];

            switch (_outcome)
            {
                case "Win":
                    PlayerWins++;
                    break;
                case "Lose":
                    ComputerWins++;
                    break;
            }
        }

        private bool CheckChoiceCorrect(string choice)
        {
            return _choices.Contains(choice);
        }

        private int CheckWinOrLoose()
        {
            int winLoseOrTie = _playerChoice == _computerChoice
                ? 0
                : _playerChoice switch
                {
                    "Rock" when _computerChoice == "Scissors" => 1,
                    "Scissors" when _computerChoice == "Paper" => 1,
                    "Paper" when _computerChoice == "Rock" => 1,
                    _ => 2
                };

            return winLoseOrTie;
        }
    }
}
