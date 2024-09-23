public interface ILogToCollections
{
    void Log<T>(ICollection<T> enumerable, T data);
}