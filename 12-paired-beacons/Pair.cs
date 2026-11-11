public class Pair<T>
{
    private T _First;
    private T _Second;

    public Pair(T first, T second)
    {
        _First = first;
        _Second = second;
    }

    public T First
    {
        get
        {
            return _First;
        }
    }

    public T Second
    {
        get
        {
            return _Second;
        }
    }

}