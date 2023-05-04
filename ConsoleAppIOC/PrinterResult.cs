namespace ConsoleAppIOC
{
    public class PrinterResult : IPrinterResult
    {
        private readonly ICalculator _calculator;

        public PrinterResult(ICalculator calculator)
        {
            _calculator = calculator;
        }


        public void Print(double a, double b)
        {
          Console.WriteLine(_calculator.Calculate(a,b));
        }
    }
}
