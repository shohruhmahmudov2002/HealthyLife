public class InvalidUserCredentialsException: Exception
{
    public const string Code = "invalid_user_credentials";
    public InvalidUserCredentialsException():base("Invalid username or password")
    {

    }
}