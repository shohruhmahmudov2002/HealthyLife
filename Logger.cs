public class Logger
{
    public static void LogError(string message, string code)
    {
        DateTime now = DateTime.Now;
        System.Console.WriteLine($"[{now.ToString("HH:mm:ss")} ERR] {code}: {message}");
    }
}