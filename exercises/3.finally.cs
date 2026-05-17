try
{
bool even = false;
bool odd = false;
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        even = true;
    }
    else
    {
        odd = false;
    }
}
catch (FormatException e)
{
    Console.WriteLine($"That's not a valid number: {e.Message}");
}
finally
{
    Console.WriteLine("Thank you for using the program.");
}
