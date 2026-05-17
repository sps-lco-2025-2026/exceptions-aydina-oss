class TemperatureException : Exception
{
    public double AttemptedValue { get; }
    public TemperatureException() { }

    public TemperatureException(string message)
        : base(message) { }
    public TemperatureException(
        string message,
        double attemptedValue)
        : base(message)
    {
        AttemptedValue = attemptedValue;
    }

    public TemperatureException(string message, Exception inner)
        : base(message, inner) { }
}
class Program
{
static void Main(){
try
{   
    Console.Write("Enter Celsius temperature: ");
    double celsius = double.Parse(Console.ReadLine()!);

    if (celsius < -273.15)
    {
        throw new TemperatureException(
            "Temperature below absolute zero.");
    }

    double fahrenheit = celsius * 9 / 5 + 32;

    Console.WriteLine(
        $"Fahrenheit: {fahrenheit:F2}");
}
catch (TemperatureException ex)
    {
        Console.WriteLine($"{ex.AttemptedValue} is below absolute zero (minimum: -273.15)");
    }
catch (FormatException)
{
    Console.WriteLine("Please enter a valid number.");
}
}
}
