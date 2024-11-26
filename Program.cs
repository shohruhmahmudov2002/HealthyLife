using System;
using System.Linq.Expressions;
namespace ExceptionHandling;
class Program
{
    static void Main(string[] args)
    {
        UserProfile userProfile= new UserProfile();
        System.Console.Write("Username: ");
        userProfile.username = Console.ReadLine();
        System.Console.Write("Password: ");
        userProfile.password = Console.ReadLine();
        try
        {
            ValidateUser(userProfile);
            System.Console.WriteLine("Welcome to System");
        }
        catch (InvalidUserCredentialsException ex)
        {
            Console.Clear();
            Logger.LogError(ex.Message, InvalidUserCredentialsException.Code);
        }
        finally
        {
            System.Console.WriteLine("Session finished");
        }
    }
    static void ValidateUser(UserProfile user)
    {
        if(!user.username.Equals("shohruh") && !user.password.Equals("12345"))
        {
            throw new InvalidUserCredentialsException();
        }
    }
}
class UserProfile
{
    public string username { get; set; }
    public string password { get; set; }
}