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

        public void ExecuteLastOperation(int operationNumber, double currentValue)
        {
            var number = operationNumber;

            switch (number)
            {
                case 1:
                    {
                        var newNumber = _calculator.Sum(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "+");
                        break;
                    }
                case 2:
                    {
                        var newNumber = _calculator.Subtraction(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "-");
                        break;
                    }
                case 3:
                    {
                        var newNumber = _calculator.Division(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "/");
                        break;
                    }
                case 4:
                    {
                        var newNumber = _calculator.Multiplication(_calculator.CurrentValue, currentValue);
                        _main.FinishOperation(newNumber, "*");
                        break;
                    }
            }
        }
    }

}
