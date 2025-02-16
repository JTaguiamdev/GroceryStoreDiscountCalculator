using System;
using System.Collections.Generic;
using System.IO;

namespace Grocery_Store_Discount_Calculator
{
    public class Inventory
    {
        private const string filePath = "C:\\Users\\owner\\source\\repos\\GroceryStoreDiscountCalculator\\GroceryStoreDiscountCalculator\\inventory.txt";
        private List<Item> items = new List<Item>();
        private int nextId = 1;

        public Inventory()
        {
            LoadInventory();
        }

        public void AddItem(string name, int quantity, decimal price)
        {
            SaveInventory();
        }

        {
            if (item != null)
            {
                if (quantity == 0)
                {
                    items.Remove(item);
                }
                else
                {
                item.Quantity = quantity;
                item.Price = price;
                }
                SaveInventory();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        {
            if (item != null)
            {
                items.Remove(item);
                SaveInventory();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void DisplayAllItems()
        {
            Console.Clear();
            foreach (var item in items)
            {
            }
            Console.WriteLine("Press any key to return to the Admin Interface...");
            Console.ReadKey();
        }

        {
        }

        public void SaveInventory()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in items)
                {
                }
            }
        }

        private void LoadInventory()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    {
                        items.Add(new Item
                        {
                        });
                    }
                }
                if (items.Count > 0)
                {
                    nextId = items.Max(i => int.Parse(i.ID)) + 1;
            }
        }
    }
    }

    public class Item
    {
        public required string ID { get; set; }
        public required string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }



    namespace Grocery_Store_Discount_Calculator
    {
        internal class Program
        {
            private static Inventory inventory = new Inventory();

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n1. Admin");
                    Console.WriteLine("2. Cashier");
                    Console.WriteLine("3. Exit Program");
                    Console.Write("Please select an option: ");
                    string option = Console.ReadLine() ?? string.Empty;

                    if (option == "1")
                    {
                        AdminInterface();
                    }
                    else if (option == "2")
                    {
                        CashierInterface();
                    }
                    else if (option == "3")
                    {
                        Console.WriteLine("Exiting the system...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                    }
                }
            }

            static void AdminInterface()
            {
                string choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("2. Display All Items");
                    Console.WriteLine("3. Update Item");
                    Console.WriteLine("4. Delete Item");
                    Console.WriteLine("5. To Main Menu");
                    Console.Write("Please select an option: ");
                    choice = Console.ReadLine() ?? string.Empty;

                    if (choice == "1")
                    {
                        AddItem();
                    }
                    else if (choice == "2")
                    {
                        inventory.DisplayAllItems();
                    }
                    else if (choice == "3")
                    {
                        UpdateItem();
                    }
                    else if (choice == "4")
                    {
                        DeleteItem();
                    }
                    else if (choice == "5")
                    {
                        Console.WriteLine("Exiting Admin Interface...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                    }
                } while (choice != "5");
            }

            static void AddItem()
            {
                Console.Clear();
                Console.Write("\nEnter an item name: ");

                // Check if the item already exists in the inventory
                if (existingItem != null)
                {
                    Console.WriteLine("Exception: Item already exists in the inventory.");
                    return;
                }

                int quantity;
                do
                {
                    Console.Write("Enter quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid positive integer for quantity.");
                    }
                } while (quantity <= 0);

                decimal price;
                do
                {
                    Console.Write("Enter price: ");
                    if (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid positive decimal for price.");
                    }
                } while (price <= 0);

                inventory.AddItem(itemName, quantity, price);
            }

            static void UpdateItem()
            {
                Console.Clear();

                Console.Write("Enter new quantity: ");
                int quantity;
                {
                    Console.Write("Enter new quantity: ");
                }

                Console.Write("Enter new price: ");
                decimal price;
                {
                    Console.Write("Enter new price: ");
                }

            }

            static void DeleteItem()
            {
                Console.Clear();

                try
                {
                }
                catch (Exception)
                {
                    Console.WriteLine("Item doesn't exist.");
                }
            }

            static void CashierInterface()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Cashier Interface");
                string choice;
                decimal totalCost = 0.00m, discount = 0.00m, finalCost = 0.000m;

                // Temporary storage for the current session
                var sessionItems = new System.Collections.Generic.List<Item>();

                do
                {
                    Console.Clear();

                    if (existingItem != null)
                    {
                        int quantity;
                        do
                        {
                            Console.Write("Enter quantity: ");
                            if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0 || quantity > existingItem.Quantity)
                            {
                                if (quantity > existingItem.Quantity)
                                {
                                    Console.WriteLine("Entered quantity exceeds available stock. Please enter a valid quantity.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid positive integer for quantity.");
                                }
                            }
                        } while (quantity <= 0 || quantity > existingItem.Quantity);

                        totalCost += existingItem.Price * quantity;

                        // Check if the item already exists in the session list
                        if (sessionItem != null)
                        {
                            sessionItem.Quantity += quantity;
                        }
                        else
                        {
                            // Store the item details in the session list
                        }

                        // Update the inventory
                        existingItem.Quantity -= quantity;

                        // Remove the item if its quantity is zero
                        if (existingItem.Quantity == 0)
                        {
                            inventory.DeleteItem(existingItem.ID);
                        }
                        else
                        {
                        // Save the updated inventory to the file
                        inventory.SaveInventory();
                        }

                        do
                        {
                            try
                            {
                                Console.Write("Do you want to enter another item? (YES/NO): ");
                                if (choice != "YES" && choice != "NO")
                                {
                                    throw new ArgumentException("Invalid input. Please enter 'YES' or 'NO'.");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"An error occurred: {ex.Message}");
                                choice = "INVALID";
                            }
                        } while (choice == "INVALID");
                    }
                    else
                    {
                        choice = "YES";
                    }
                } while (choice != "NO");

                if (totalCost > 500) discount = totalCost * .20m;
                else if (totalCost > 200) discount = totalCost * .15m;
                else if (totalCost > 100) discount = totalCost * .10m;
                else discount = 0.00m;

                finalCost = totalCost - discount;

                Console.Clear();
                Console.WriteLine("\n\t\t\t\t\tRECEIPT");
                foreach (var sessionItem in sessionItems)
                {
                }
                Console.WriteLine($"Total Cost:\t\t\t\t\t\t\t\t${totalCost:F2}");
                Console.WriteLine($"Discount:\t\t\t\t\t\t\t\t-${discount:F2}");
                Console.WriteLine($"Final Cost:\t\t\t\t\t\t\t\t${finalCost:F2}");

                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }
}



