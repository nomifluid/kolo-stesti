int[] amounts = { 100, 200, 300, 0, 400, 500, 600, 0 };



static bool userWants(string question)
{
    Console.WriteLine("> " + question);
    Console.Write("< ");
    string response = Console.ReadLine();
    if (response == "y") { return true; }
    return false;
}

while (userWants("Chcete hrát? (y/n)"))
{
    int totalAmount = 0;
    while (userWants("Chcete točit? (y/n)"))
    {
        int randomAmount = amounts[new Random().Next(0, amounts.Length)];
        if (randomAmount == 0)
        {
            Console.WriteLine("0 - Prohráváte!");
            return;
        }
        totalAmount += randomAmount;
        Console.WriteLine(randomAmount + " (celkově: " + totalAmount + ")");
    }
}