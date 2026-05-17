class InventoryException : Exception
{
    public InventoryException(string message)
        : base(message) { }
}

class ItemNotFoundException : InventoryException
{
    public ItemNotFoundException(string itemName)
        : base($"Item '{itemName}' was not found.")
    {
    }
}

class InsufficientQuantityException : InventoryException
{
    public InsufficientQuantityException(string itemName)
        : base($"Not enough '{itemName}' in inventory.")
    {
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, int> inventory =
            new Dictionary<string, int>()
        {
            { "sword", 1 },
            { "potion", 2 },
            { "shield", 1 }
        };

        while (true)
        {
            Console.Write("Command: ");

            string input = Console.ReadLine();

            if (input == null)
                continue;

            if (input.ToLower() == "quit")
                break;

            string[] parts = input.Split(' ');
            
            string item = parts[1].ToLower();

            try
            {
                if (!inventory.ContainsKey(item))
                {
                    throw new ItemNotFoundException(item);
                }

                if (inventory[item] <= 0)
                {
                    throw new InsufficientQuantityException(item);
                }

                inventory[item]--;

                Console.WriteLine(
                    $"You took one {item}.");
            }
            catch (ItemNotFoundException ex)
            {
                Console.WriteLine(
                    $"Missing item: {ex.Message}");
            }
            catch (InsufficientQuantityException ex)
            {
                Console.WriteLine(
                    $"Inventory problem: {ex.Message}");
            }
        }
    }
}