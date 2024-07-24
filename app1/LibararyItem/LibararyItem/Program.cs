using LibraryItemNamespace;
using System;
using System.Collections.Generic;

class Catalog
{
    private List<LibraryItem> items = new List<LibraryItem>();

    public void AddItems(LibraryItem item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        while (true)
        {
            Console.WriteLine("Please choose an Item:");
            Console.WriteLine("1: Book");
            Console.WriteLine("2: DVD");
            Console.WriteLine("3: find an item by title or author");
            Console.WriteLine("0: Exit");
            int feature = Convert.ToInt32(Console.ReadLine());

            if (feature == 0)
            {
                break;
            }

            if (feature == 1)
            {
                Console.WriteLine("Please enter book title:");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter book author:");
                string author = Console.ReadLine();
                Console.WriteLine("Please enter book genre:");
                string genre = Console.ReadLine();

                Console.WriteLine("Please enter book publication date (YYYY/MM/DD):");
                string publicationDateInput = Console.ReadLine();

                if (DateOnly.TryParse(publicationDateInput, out DateOnly publicationDate))
                {
                    Console.WriteLine("Please enter book availability (1: Available, 0: Unavailable):");
                    string availableInput = Console.ReadLine();
                    bool available = availableInput == "1";

                    Book book = new Book(title, author, publicationDate, available, genre);
                    catalog.AddItems(book);
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                }
            }
            else if (feature == 2)
            {
                Console.WriteLine("Please enter DVD title:");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter DVD director:");
                string director = Console.ReadLine();
                Console.WriteLine("Please enter DVD runtime (in minutes):");
                int runtime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter DVD publication date (YYYY/MM/DD):");
                string publicationDateInput = Console.ReadLine();

                if (DateOnly.TryParse(publicationDateInput, out DateOnly publicationDate))
                {
                    Console.WriteLine("Please enter DVD availability (1: Available, 0: Unavailable):");
                    string availableInput = Console.ReadLine();
                    bool available = availableInput == "1";

                    DVD dvd = new DVD(title, director, publicationDate, available, runtime);
                    catalog.AddItems(dvd);
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                }
            }
            else if (feature == 3)
            {
                Console.WriteLine("Please enter search text:");
                string searchText = Console.ReadLine();

                // Find items matching the search text
                List<LibraryItem> foundItems = catalog.FindItems(searchText);

                if (foundItems.Count > 0)
                {
                    Console.WriteLine("Found items:");
                    foreach (var item in foundItems)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("No items found.");
                }
            }
            Console.WriteLine("Current catalog items:");
            catalog.DisplayItems();
            Console.WriteLine();
        }
    }
}
