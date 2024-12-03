namespace calculator_task;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        var userInput = Console.ReadKey();
        Console.WriteLine();

        switch (userInput.KeyChar)
        {
            case 'a':
                Console.WriteLine(calc.AddNumbers(1, 7));
                break;
            case 's':
                Console.WriteLine(calc.SubtractNumbers(9, 6));
                break;
            case 'm':
                Console.WriteLine(calc.MultiplyNumbers(3, 2));
                break;
            case 'd':
                Console.WriteLine(calc.DivideNumbers(42, 8));
                break;
            default:
                Console.WriteLine("Invalid Key");
                break;
        }
    }
}
