using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Insufficient stock to complete the sale.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items.
        Console.WriteLine("Initial Inventory:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell some items and then print the updated details.
        item1.SellItem(10);
        item2.SellItem(9);
        Console.WriteLine("Inventory after selling some items:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Restock an item and print the updated details.
        item1.RestockItem(12);
        item2.RestockItem(13);
        Console.WriteLine("Inventory after restocking an item:");
        item1.PrintDetails();
        item2.PrintDetails();
        // Check if an item is in stock and print a message accordingly.
        Console.WriteLine("Checking stock status:");
        Console.WriteLine($"{item1.ItemName} is in stock: {item1.IsInStock()}");
        Console.WriteLine($"{item2.ItemName} is in stock: {item2.IsInStock()}");

        
    }
}
