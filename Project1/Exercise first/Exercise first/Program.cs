
List<string> customers = new();
ShowMenu();



void ShowMenu()
{
    do
    {
        Console.Clear();
        Console.WriteLine("1.Add Customer's Name");
        Console.WriteLine("2.Show List");
        Console.WriteLine("3.Delete List");
        Console.WriteLine("4.Exit");
        Console.Write("Choose one of the options above: ");

        var choice = Console.ReadLine();


        switch (choice)
        {
            case "1":
                AddToList();
                break;

            case "2":
                DisplayList();
                break;

            case "3":
                RemoveFromList();
                break;

            case "4":
                Environment.Exit(0);
                break;
        }

    } while (true);

}



void AddToList()
{
    Console.Clear();
    Console.WriteLine("New Customer");
    Console.WriteLine("------------");

    Console.Write("Add name: ");
    var name = Console.ReadLine();

    Console.Write("Add address: ");
    var address = Console.ReadLine();

    Console.Write("Add Email: ");
    var email = Console.ReadLine();

    var customer = $"{name}, {address} ({email})";
    customers.Add(customer);
}

void DisplayList()
{
    Console.Clear();
    Console.WriteLine("Show customer List");
    Console.WriteLine("------------");

    foreach (var customer in customers)
    {
        Console.WriteLine(customer);
    }

    Console.ReadKey();
}

void RemoveFromList()
{
    Console.Clear();
    Console.WriteLine("Delete Customer");
    Console.WriteLine("------------");

    Console.Write("Enter the index of customer you want to delete: ");
    var index = int.Parse(Console.ReadLine());

    customers.RemoveAt(index);
}