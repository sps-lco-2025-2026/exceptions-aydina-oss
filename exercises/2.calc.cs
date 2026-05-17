try
{
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(100 / n);
}
catch (FormatException)
{
    Console.WriteLine("Invalid number.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
finally
{
    Console.WriteLine("Calculation complete");
}
