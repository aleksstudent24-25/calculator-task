public interface ICalculator
{
    /// <summary>
    /// Adds two numbers together and returns the value.
    /// </summary>
    /// <param name="a"> the value of the number a </param>
    /// <param name="b"> the value of the number b </param>
    /// <returns>a + b</returns>
    public double AddNumbers(double a, double b);

    /// <summary>
    /// Subtracts two numbers and returns the value.
    /// </summary>
    /// <param name="a"> the value of the number a </param>
    /// <param name="b"> the value of the number b </param>
    /// <returns>a - b</returns>
    public double SubtractNumbers(double a, double b);

    /// <summary>
    /// Multiplies two numbers and returns the value.
    /// </summary>
    /// <param name="a"> the value of the number a </param>
    /// <param name="b"> the value of the number b </param>
    /// <returns>a * b</returns>
    public double MultiplyNumbers(double a, double b);

    /// <summary>
    /// Divides two numbers and returns the value.
    /// </summary>
    /// <param name="a"> the value of the number a </param>
    /// <param name="b"> the value of the number b </param>
    /// <returns>a / b</returns>
    public double DivideNumbers(double a, double b);
}