using System;
using System.Collections.Generic;  // Needed for List<T>
using System.IO;

public class Program
{
    public static void LoadData(List<string> items, List<string> prices, List<string> counts)
    {
        // Load saved data from storage or initialize with default values
    }
    public static void SaveData(List<string> items, List<string> prices, List<string> counts)
    {
        try
        {
            using StreamWriter writer = new StreamWriter("Inventory.txt");
            for (int i = 0; i < items.Count; i++)
            {
                string price = i < prices.Count ? prices[i] : "0";
                string count = i < counts.Count ? counts[i] : "0";
                writer.WriteLine($"{items[i]} | {price} | {count}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }
    public static void Main(string[] args)
    {
        List<string> items = new List<string>();
        List<string> prices = new List<string>();
        List<string> counts = new List<string>();
        if (File.Exists("Inventory.txt"))
        {
            string[] lines = File.ReadAllLines("Inventory.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(" | ");
                if (parts.Length == 3)
                {
                    items.Add(parts[0]);
                    prices.Add(parts[1]);
                    counts.Add(parts[2]);
                }
            }
            Console.WriteLine("Inventory loaded successfully.");
        }

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. View items");
            Console.WriteLine("2. Add item");
            Console.WriteLine("3. Add price");
            Console.WriteLine("4. Add count");
            Console.WriteLine("5. Exit");

            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Items in stock:");
                        if (items.Count == 0)
                        {
                            Console.WriteLine("No item available.");
                            // Display the total number of items
                            Console.WriteLine($"Total items: {items.Count}");
                        }
                        else
                        {
                            for (int i = 0; i < items.Count; i++)
                            {
                                string itemPrice = i < prices.Count ? $"${prices[i]:F2}" : "N/A";
                                string itemCount = i < counts.Count ? counts[i].ToString() : "N/A";
                                Console.WriteLine($"{i + 1}. {items[i]} - Price: {itemPrice}, Count: {itemCount}");
                            }
                        }
                        break;

                    case 2:
                        Console.Write("Enter the item: ");
                        string? item = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(item))
                        {
                            items.Add(item);
                            Console.WriteLine("item added.");
                            SaveData(items, prices, counts);
                        }
                        else
                        {
                            Console.WriteLine("item cannot be empty.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the unit price: ");
                        string? price = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(price) && decimal.TryParse(price, out decimal priceValue))
                        {
                            prices.Add(price);
                            Console.WriteLine($"Price: {priceValue:C2}");
                            SaveData(items, prices, counts);
                        }
                        else
                        {
                            Console.WriteLine("Invalid price entered.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter the index of the item to update (1 to {0}): ", items.Count);
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= items.Count)
                        {
                            Console.Write("Enter the new item name (leave blank to keep current): ");
                            string? newItem = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newItem))
                            {
                                items[index - 1] = newItem;
                                Console.WriteLine("Item updated.");
                            }

                            Console.Write("Enter the new price (leave blank to keep current): ");
                            string? newPrice = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newPrice) && decimal.TryParse(newPrice, out decimal newPriceValue))
                            {
                                while (prices.Count < index)
                                {
                                    prices.Add("0");
                                }
                                prices[index - 1] = newPrice;
                                Console.WriteLine($"Price updated to: {newPriceValue:C2}");
                            }

                            Console.Write("Enter the new count (leave blank to keep current): ");
                            string? newCount = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newCount))
                            {
                                while (counts.Count < index)
                                {
                                    counts.Add("0");
                                }
                                counts[index - 1] = newCount;
                                Console.WriteLine("Count updated.");
                            }
                            SaveData(items, prices, counts);
                        }
                        else
                        {
                            Console.WriteLine("Invalid item index.");
                        }
                        break;

                    case 5:
                        SaveData(items, prices, counts);
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Please enter valid number");
            }
        }
    }
}
