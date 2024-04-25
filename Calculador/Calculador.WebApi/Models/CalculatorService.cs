using Calculator.Models;

namespace Calculator.Services
{
    public class CalculatorService
    {
        public double Add(Operation operation)
        {
            return operation.Number1 + operation.Number2;
        }

        public double Subtract(Operation operation)
        {
            return operation.Number1 - operation.Number2;
        }

        public double Multiply(Operation operation)
        {
            return operation.Number1 * operation.Number2;
        }

        public double Divide(Operation operation)
        {
            if (operation.Number2 == 0)
                throw new System.DivideByZeroException("Cannot divide by zero.");
            return operation.Number1 / operation.Number2;
        }
    }
}
