using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CalculatorLogic.Calculator;

namespace Calculator
{
    public partial class CalculatorWindow : Form
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }

        private double _number1 = 0;
        private double _number2;
        private double _result;
        private string _whatToDo;

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            InputAndAnswerTextBox.AppendText(button.Text);
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (!InputAndAnswerTextBox.Text.Contains(","))
            {
                InputAndAnswerTextBox.AppendText(",");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.Clear();
        }

        private void ChangePositiveNegativeButton_Click(object sender, EventArgs e)
        {
            if (InputAndAnswerTextBox.Text == "") return;

            _result = double.Parse(InputAndAnswerTextBox.Text);
            _result *= -1;

            DisplayResult();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (InputAndAnswerTextBox.Text == "") return;

            _number1 = double.Parse(InputAndAnswerTextBox.Text);
            Button button = (Button)sender;
            _whatToDo = button.AccessibleName;

            InputAndAnswerTextBox.Clear();
        }

        private void DirectCalculateButton_Click(object sender, EventArgs e)
        {
            if (InputAndAnswerTextBox.Text == "") return;

            _number1 = double.Parse(InputAndAnswerTextBox.Text);
            Button button = (Button)sender;

            _result = button.AccessibleName switch
            {
                "Square" => Square(_number1),
                "SquareRoot" => SquareRoot(_number1),
                _ => _result
            };

            DisplayResult();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (InputAndAnswerTextBox.Text != "")
            {
                _number2 = double.Parse(InputAndAnswerTextBox.Text);
            }

            _result = _whatToDo switch
            {
                "Add" => Add(_number1, _number2),
                "Subtract" => Subtract(_number1, _number2),
                "Multiply" => Multiply(_number1, _number2),
                "Divide" => Divide(_number1, _number2),
                _ => _result
            };

            DisplayResult();
        }

        private void DisplayResult()
        {
            InputAndAnswerTextBox.Text = _result.ToString();
        }
    }
}
