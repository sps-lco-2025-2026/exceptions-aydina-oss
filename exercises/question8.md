1. Because it is a specific kind of inventory-related exception and this way it can be grouped with other inventory-related exceptions.
2. Yes they can as both exceptions inherit from InventoryException.
3. When catching unexpected errors that we don't know the type of.
4. It preserves the original exception that caused the current one. It is used when one wants to debug the original exception.
5. Only when one wants to reset the stack trace.