using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public delegate double Operation(double firstParameter, double secondParameter);

    public struct OperationResult
    {
        public double result;
    }

    public partial class Form1 : Form
    {
        Func<double, double, OperationResult> Testing;

        private Calculator _calculator;
        private View _view;

        private bool _operationIsChoosed;
        private string _currentNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _calculator = new Calculator();
            _view = new View(ref label1, ref textBox1);
        }

        private void button12_Click(object sender, EventArgs e) //1
        {
            _currentNumber += 1.ToString();
            _view.AddNewTextToMainCalcLabel("1");
        }

        private void button11_Click(object sender, EventArgs e) //2
        {
            _currentNumber += 2.ToString();
            _view.AddNewTextToMainCalcLabel("2");
        }

        private void button10_Click(object sender, EventArgs e) //3
        {
            _currentNumber += 3.ToString();
            _view.AddNewTextToMainCalcLabel("3");
        }

        private void button9_Click(object sender, EventArgs e) //4
        {
            _currentNumber += 4.ToString();
            _view.AddNewTextToMainCalcLabel("4");
        }

        private void button8_Click(object sender, EventArgs e) //5
        {
            _currentNumber += 5.ToString();
            _view.AddNewTextToMainCalcLabel("5");
        }

        private void button7_Click(object sender, EventArgs e) //6
        {
            _currentNumber += 6.ToString();
            _view.AddNewTextToMainCalcLabel("6");
        }

        private void button4_Click(object sender, EventArgs e) //7
        {
            _currentNumber += 7.ToString();
            _view.AddNewTextToMainCalcLabel("7");
        }

        private void button5_Click(object sender, EventArgs e) //8
        {
            _currentNumber += 8.ToString();
            _view.AddNewTextToMainCalcLabel("8");
        }

        private void button6_Click(object sender, EventArgs e) //9
        {
            _currentNumber += 9.ToString();
            _view.AddNewTextToMainCalcLabel("9");
        }

        private void button20_Click(object sender, EventArgs e) //+
        {
            var insertedNumber = _calculator.CheckIfIsNumber(_currentNumber);

            if (_operationIsChoosed && _currentNumber.Length == 0)
                return;

            _operationIsChoosed = true;

            if (_calculator.CurrentValue != 0 && _currentNumber.Length != 0)
            {
                if (insertedNumber == 0d)
                    return;

                var newNumber = _calculator.Sum(_calculator.CurrentValue, insertedNumber);
                _calculator.CurrentValue = newNumber;

                _view.UpdateResult(newNumber);
                _view.ClearMainCalcLabel();
                _view.AddNewTextToMainCalcLabel(_calculator.CurrentValue.ToString() + "+");
                _currentNumber = "";
                return;

            }

            _calculator.CurrentValue = insertedNumber;
            _currentNumber = "";

            _view.AddNewTextToMainCalcLabel("+");
        }

        private void button19_Click(object sender, EventArgs e) //-
        {
            var insertedNumber = _calculator.CheckIfIsNumber(_currentNumber);

            if (_operationIsChoosed && _currentNumber.Length == 0)
                return;
            
            _operationIsChoosed = true;
            if (_calculator.CurrentValue != 0 && _currentNumber.Length != 0)
            {
                if (insertedNumber == 0d)
                    return;

                var newNumber = _calculator.Subtraction(_calculator.CurrentValue, insertedNumber);
                _calculator.CurrentValue = newNumber;

                _view.UpdateResult(newNumber);
                _view.ClearMainCalcLabel();
                _view.AddNewTextToMainCalcLabel(_calculator.CurrentValue.ToString() + "-");
                _currentNumber = "";
                return;
            }

            _calculator.CurrentValue = insertedNumber;
            _currentNumber = "";

            _view.AddNewTextToMainCalcLabel("-");
        }

        private void button2_Click(object sender, EventArgs e) //C
        {
            _view.ClearMainCalcLabel();
            _calculator.CurrentValue = 0d;
            _currentNumber = "";
            _view.ClearLabel();
        }

        private void DOOperation(Func<double, double, OperationResult> operation, double insertedNumber)
        {
            var operationResult = operation(_calculator.CurrentValue, insertedNumber);
            var newNumber = operationResult.result;

            _calculator.CurrentValue = newNumber;
            _view.UpdateResult(newNumber);
            _view.ClearMainCalcLabel();
            _view.AddNewTextToMainCalcLabel(_calculator.CurrentValue.ToString() + "-");
            _currentNumber = "";

        }
    }
}
