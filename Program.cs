try
{
    Console.WriteLine("Enter login: ");
    string a = Console.ReadLine();
    Console.WriteLine("Enter password: ");
    string b = Console.ReadLine();
    Console.WriteLine("Enter confirm password: ");
    string c = Console.ReadLine();

    bool result1 = Password.LoginCheck(a, b, c);
    Console.WriteLine(result1);
}
catch (WrongLoginException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Incorrect value: ({ex.Value})");
    Console.WriteLine($"StackTrace:{ex.StackTrace}");
}
catch (WrongPasswordException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Incorrect value: ({ex.Value})");
    Console.WriteLine($"StackTrace:{ex.StackTrace}");
}
finally
{
    Console.WriteLine("Final");
    Console.ReadLine();
}