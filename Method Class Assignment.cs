
public class MathOperations
{

    public void PerformOperation(int num1, int num2)
    {

        int result = num1 + 10;


        Console.WriteLine($"Result of {num1} + 10 = {result} and second number is {num2}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        MathOperations mathOp = new MathOperations();


        mathOp.PerformOperation(5, 20);  // First number 5, second number 20


        mathOp.PerformOperation(num1: 10, num2: 30);  // First number 10, second number 30


        Console.ReadKey();
    }
}
