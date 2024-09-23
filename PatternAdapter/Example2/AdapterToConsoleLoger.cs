
public class AdapterToConsoleLoger:ILogToCollections
{
    ConsoleLoger consoleLoger;
    public AdapterToConsoleLoger(ConsoleLoger consoleLoger)
    {
        this.consoleLoger=consoleLoger;        
    }
    public void Log<T>(ICollection<T> enumerable, T data)
    {
        consoleLoger.Log(data);
    }
}