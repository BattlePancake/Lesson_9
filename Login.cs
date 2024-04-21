using System;

public class Password
{
    public static bool LoginCheck(string login, string password, string confirmPassword)
    {
        if (login.Length > 20 || login.Contains(" "))
        {
            throw new WrongLoginException("Login is invalid", login);
        }
        else if (password.Length > 20 || password.Contains(" "))
        {
            for (int a = 0; a < password.Length; a++)
            {
                if (password[a] >= '0' && password[a] <= '9')
                {
                    throw new WrongPasswordException("Password is invalid", password);
                }
            }
        }
        else if (password.Length < 20)
        {
            int count = 0;
            for (int a = 0; a < password.Length; a++)
            {
                if (password[a] >= '0' && password[a] <= '9')
                {
                    count++;
                }
            }
            if (count == 0)
            {
                throw new WrongPasswordException("Password is invalid, should be at least 1 number", password);
            }
        }
        else if (string.Compare(password,confirmPassword) != 0)
        {
            throw new WrongPasswordException("ConfirmPassword != Password", confirmPassword);
        }
        Console.WriteLine("Your credentials are valid");
        return true;
    }
}

public class WrongLoginException : Exception
{
    public string Value { get; }
    public WrongLoginException() : base()
    {
    }
    public WrongLoginException(string message, string val) : base(message)
    {
        Value = val;
    }
}
public class WrongPasswordException : Exception
{
    public string Value { get; }
    public WrongPasswordException() : base()
    {
    }
    public WrongPasswordException(string message, string val) : base(message)
    {
        Value = val;
    }
}
