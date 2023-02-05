using BankProject;

BankCard bc1 = new("Kapital Bank", "Kapital Bank", "5920829582959292", "1234", "07/27", 1234);
BankCard bc2 = new("Kapital Bank", "Kapital Bank", "1231412412515135", "4321", "01/25", 5757);

List<User> users = new();
User u1 = new("Farid", "Salimov", bc1);
User u2 = new("Rinat", "Qedimov", bc2);
users.Add(u1);
users.Add(u2);

string? pin;
Console.Write("Enter PIN: ");
pin = Console.ReadLine();

foreach (var user in users)
{
    if (pin == user.BankCard.PIN)
    {
        Console.Clear();
        Console.WriteLine($"Welcome {user.Name}!");
    label:
        Console.WriteLine("\n1 - Balance\n2 - Take Money\n3 - Card to Card");
        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.D1)
        {
            Console.Clear();
            Console.WriteLine($"Balance: {user.BankCard.Balance} AZN");
            goto label;
        }
        
        else if (key.Key == ConsoleKey.D2)
        {
            Console.Clear();
        label2:
            Console.WriteLine("1 - 10 AZN\n2 - 20 AZN\n3 - 50 AZN\n4 - 100 AZN\n5 - Custom");
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1)
            {
                try
                {
                    user.BankCard.DecreaseBalance(10);
                    Console.Clear();
                    Console.WriteLine("10 AZN has been successfully withdrawn from your card.");
                    goto label;
                }

                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    goto label;
                    throw;
                }
            }

            else if (key.Key == ConsoleKey.D2)
            {
                try
                {
                    user.BankCard.DecreaseBalance(20);
                    Console.Clear();
                    Console.WriteLine("20 AZN has been successfully withdrawn from your card.");
                    goto label;
                }

                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    goto label;
                    throw;
                }
            }

            else if (key.Key == ConsoleKey.D3)
            {
                try
                {
                    user.BankCard.DecreaseBalance(50);
                    Console.Clear();
                    Console.WriteLine("50 AZN has been successfully withdrawn from your card.");
                    goto label;
                }

                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    goto label;
                    throw;
                }
            }

            else if (key.Key == ConsoleKey.D4)
            {
                try
                {
                    user.BankCard.DecreaseBalance(100);
                    Console.Clear();
                    Console.WriteLine("100 AZN has been successfully withdrawn from your card.");
                    goto label;
                }

                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    goto label;
                    throw;
                }
            }

            else if (key.Key == ConsoleKey.D5)
            {
                Console.Clear();
                decimal amount;
                Console.Write("Enter amount: ");
                amount = Convert.ToInt32(Console.ReadLine());

                try
                {
                    user.BankCard.DecreaseBalance(amount);
                    Console.Clear();
                    Console.WriteLine($"{amount} AZN has been successfully withdrawn from your card.");
                    goto label;
                }

                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    goto label;
                    throw;
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invilad select!");
                goto label2;
            }
        }

        else if (key.Key == ConsoleKey.D3)
        {
            Console.Clear();
            string? pan;
            Console.Write("Enter PAN: ");
            pan = Console.ReadLine();
            
            foreach (User use in users)
            {
                if (pan == use.BankCard.PAN)
                {
                    decimal amount;
                    Console.Write("Enter amount: ");
                    amount = Convert.ToDecimal(Console.ReadLine());

                    try
                    {
                        use.BankCard.DecreaseBalance(amount);
                        goto label;
                    }

                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                    }

                    use.BankCard.IncreaseBalance(amount);
                    goto label;
                }
            }
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Invilad select!");
            goto label;
        }
    }
}
