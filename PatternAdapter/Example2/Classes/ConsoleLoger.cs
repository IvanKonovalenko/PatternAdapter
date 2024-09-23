public class ConsoleLoger : ILog
{
    public void Log(object data)
    {
        System.Console.WriteLine(data);
    }
}