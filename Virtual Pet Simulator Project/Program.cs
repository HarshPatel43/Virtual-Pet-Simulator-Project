using System;

class VirPet
{
    private string pVal;
    private string pName;
    private int hunger;
    private int happiness;
    private int health;

    public VirPet(string type, string name)
    {
        pVal = type;
        pName = name;
        hunger = 7;
        happiness = 7;
        health = 7;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome !!! Your pet is a {pVal} named {pName}.");
    }

    public void Feed()
    {
        hunger = Math.Max(0, hunger - 2);
        health = Math.Min(10, health + 1);
        Console.WriteLine($"{pName} has been fed. Hunger decreased, health increased.");
    }

    public void Play()
    {
        happiness = Math.Min(10, happiness + 2);
        hunger = Math.Max(0, hunger + 1);
        Console.WriteLine($"{pName} is playing. Happiness increased, hunger increased slightly.");
    }

    public void Rest()
    {
        health = Math.Min(10, health + 2);
        happiness = Math.Max(0, happiness - 1);
        Console.WriteLine($"{pName} is resting. Health increased, happiness decreased slightly.");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Status of {pName}:");
        Console.WriteLine($"Hunger: {hunger}/10");
        Console.WriteLine($"Happiness: {happiness}/10");
        Console.WriteLine($"Health: {health}/10");
    }

    public void CheckStatus()
    {
        if (hunger <= 3 || happiness <= 3 || health <= 3)
        {
            Console.WriteLine("Warning: Your pet is not doing well. Please take care of it.");
        }
    }

    public void SimulateTimePassage()
    {
        hunger += 1;
        happiness -= 1;

        // Simulate additional time-based changes here if needed
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Virtual Pet Care Console App");

        Console.Write("Enter the type of pet (e.g., rabbit, cat, dog): ");
        string pVal = Console.ReadLine();

        Console.Write("Enter a name for your pet: ");
        string pName = Console.ReadLine();

        VirPet myPet = new VirPet(pVal, pName);
        myPet.DisplayWelcomeMessage();

        while (true)
        {
            Console.WriteLine("\nActions:");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Rest");
            Console.WriteLine("4. Status Check");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myPet.Play();
                    break;
                case "2":
                    myPet.Feed();
                    break;
                case "3":
                    myPet.Rest();
                    break;
                case "4":
                    myPet.DisplayStatus();
                    myPet.CheckStatus();
                    break;
                case "5":
                    Console.WriteLine("Exiting Virtual Pet Care. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            myPet.SimulateTimePassage(); // Simulate time passage after each action
        }
    }
}
