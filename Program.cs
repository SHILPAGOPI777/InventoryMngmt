using System.Diagnostics;
namespace InventoryMngmnt
{
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
            // Initialized the properties with the values passed to the constructor.
            ItemName = itemName;
            ItemId = itemId;
            Price = price;
            QuantityInStock = quantityInStock;

        }

        // Methods

        // Update the price of the item
        public void UpdatePrice(double newPrice)
        {
            //  Updated the item's price with the new price.
            Price = newPrice;
        }

        // Restock the item
        public void RestockItem(int additionalQuantity)
        {
            // Increasing the item's stock quantity by the additional quantity.
            QuantityInStock += additionalQuantity;
        }

        // Sell an item
        public void SellItem(int quantitySold)
        {
            // Decreasing the item's stock quantity by the quantity sold.

            if (QuantityInStock >= quantitySold)
            {
                QuantityInStock -= quantitySold;  // Make sure the stock doesn't go negative.
            }
            else
            {
                Console.WriteLine("**** NO ITEMS IN STOCK!!!! ****");
            }
        }
        // Check if an item is in stock
        public bool IsInStock()
        {
            return QuantityInStock > 0;// Returning true if the item is in stock (quantity > 0), otherwise false.
        }


        // Print item details
        public void PrintDetails()
        {
            // TODO: Print the details of the item (name, id, price, and stock quantity)

            Console.WriteLine($"Item Name: {ItemName} Item ID: {ItemId} Price: {Price} Quantity in Stock: {QuantityInStock}");
            
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of InventoryItem
            InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
            InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

            // TODO: Implement logic to interact with these objects.
            // Example tasks:
            // 1. Print details of all items.
            Console.WriteLine("---- All Items ----");
            item1.PrintDetails();
            item2.PrintDetails();
            Console.WriteLine("-------------------");
            // 2. Sell some items and then print the updated details.

            item1.SellItem(3);
            Console.WriteLine("\nSold 3 "+item1.ItemName);
            item2.SellItem(2);
            Console.WriteLine("Sold 2 "+item2.ItemName);

            Console.WriteLine("\n---- Item Details  After Selling---- ");
            item1.PrintDetails();
            item2.PrintDetails();

            Console.WriteLine("-------------------");
            // 3. Restock an item and print the updated details.

            item1.RestockItem(5);
            Console.WriteLine("\n5 Restock added in " + item1.ItemName);
            Console.WriteLine("\n---- Item Details  After Restock---- ");
            item1.PrintDetails();

            Console.WriteLine("-------------------");
            // 4. Check if an item is in stock and print a message accordingly.

            Console.WriteLine("\n---- "+item2.ItemName+" Stock Checking ---- ");
            if (item2.IsInStock())
            {
                Console.WriteLine("**** "+ item2.ItemName+" IS IN STOCK ****");
            }
            else
            {
                Console.WriteLine("**** "+ item2.ItemName+" PHONE IS OUT OF STOCK ****");
            }

        }


    }
}
