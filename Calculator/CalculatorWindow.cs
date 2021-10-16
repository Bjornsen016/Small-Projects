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
        private int _whatToDo;
        private void Number1_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("1");
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("2");
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("3");
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("4");
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("5");
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("6");
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("7");
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("8");
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("9");
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            InputAndAnswerTextBox.AppendText("0");
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            _number1 = double.Parse(InputAndAnswerTextBox.Text);
            _whatToDo = 0;
            InputAndAnswerTextBox.Clear();
        }
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            _number1 = double.Parse(InputAndAnswerTextBox.Text);
            _whatToDo = 1;
            InputAndAnswerTextBox.Clear();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _number1 = double.Parse(InputAndAnswerTextBox.Text);
            _whatToDo = 2;
            InputAndAnswerTextBox.Clear();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            _number1 = double.Parse(InputAndAnswerTextBox.Text);
            _whatToDo = 3;
            InputAndAnswerTextBox.Clear();
        }
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (InputAndAnswerTextBox.Text != "")
            {
                _number2 = double.Parse(InputAndAnswerTextBox.Text);
            }

            _result = _whatToDo switch
            {
                0 => Add(_number1, _number2),
                1 => Subtract(_number1, _number2),
                2 => Multiply(_number1, _number2),
                3 => Divide(_number1, _number2),
                _ => _result
            };

            InputAndAnswerTextBox.Text = _result.ToString();
        }

        private void ChangePositiveNegativeButton_Click(object sender, EventArgs e)
        {
            var tempNum = double.Parse(InputAndAnswerTextBox.Text);
            tempNum *= -1;
            InputAndAnswerTextBox.Text = tempNum.ToString();
        }
    }
}
