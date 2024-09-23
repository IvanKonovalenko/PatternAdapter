
public class ArrayLoger : ILogToCollections
{
    public void Log<T>(ICollection<T> enumerable, T data)
    {
        enumerable.Add(data);
    }

    
}