try
{   string[] names = { "Alice", "Bob", "Charlie" };
    Console.Write("Enter an index: ");
    int i = int.Parse(Console.ReadLine()!);
    Console.WriteLine(names[i]);
}
catch (FormatException e)
{
    Console.WriteLine($"That's not a valid number: {e.Message}");
}
catch (IndexOutofRangeException)
{
    Console.WriteLine("Index is outside the array.");
}


