try{
int[] arr = new int[3];
arr[10] = 5;
}
catch (IndexoutofRangeException)
{
    Console.WriteLine("Index is outside the array.");
}

try{
string s = null!;
Console.WriteLine(s.Length);
}
catch (NullReferenceException)
{
    Console.WriteLine("You can't call a method on a null object");
}

try{
int x = int.MaxValue;
checked { x = x + 1; }   // checked enforces overflow detection
}
catch (OverflowException)
{
    Console.WriteLine("Overfllwo has occured, int can't take a value that large");
}
