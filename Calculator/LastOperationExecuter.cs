namespace Calculator
{
    public class LastOperationExecuter
    {
        private Calculator _calculator;
        private Form1 _main;

        public LastOperationExecuter(Calculator calc, Form1 main)
        {
            _calculator = calc;
            _main = main;
        }

        public void ExecuteLastOperation(string operationNumber, double currentValue)
        {
            var number = operationNumber;

            switch (number)
            {
                case "+":
                    {
                        var newNumber = _calculator.Sum(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "");
                        _calculator.CurrentValue = newNumber;
                        break;
                    }
                case "-":
                    {
                        var newNumber = _calculator.Subtraction(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "");
                        _calculator.CurrentValue = newNumber;
                        break;
                    }
                case "/":
                    {
                        var newNumber = _calculator.Division(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "");
                        _calculator.CurrentValue = newNumber;
                        break;
                    }
                case "*":
                    {
                        var newNumber = _calculator.Multiplication(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "");
                        _calculator.CurrentValue = newNumber;
                        break;
                    }
            }
        }
    }

}
