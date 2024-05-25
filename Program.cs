var money = 30;

while (money >= 5)
{
    Console.WriteLine($"Hey, you're poor you only have ${money} in your small wallet.");
    Console.WriteLine("YOU HAVE NO CHOICE.");
    Console.WriteLine("do you want to buy:");
    Console.WriteLine(" \"Meat\" - 25$,");
    Console.WriteLine(" \"Beans\" -10$, ");
    Console.WriteLine(" \"Juice\" - 7$, ");
    Console.WriteLine(" \"Sugar\" - 5$");
    var input = Console.ReadLine().ToLower();
    if (input == "beans" && money >= 10)
    {
        money -= 10;
        Console.WriteLine("You bought Beans");
    }
    else if (input == "meat" && money >= 25)
    {
        money -= 25;
        Console.WriteLine("You bought Meat");
    }
    else if (input == "juice" && money >= 7)
    {
        money -= 7;
        Console.WriteLine("You bought a juice");
    }
    else if (input == "sugar" && money >= 5)
    {
        money -= 5;
        Console.WriteLine("You bought some sugar");
    }
    else
    {
        Console.WriteLine("You can't buy that, you don't have enough money.");
    }
}

if (money < 5)
{
    Console.WriteLine("You're BROKE, you can't buy Anything.");
}
