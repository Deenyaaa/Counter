namespace Counter;

public class Counter
{
    private bool _running;
    public int Count { get; private set; }
    
    public Counter(int initialValue = 0)
    {
        Count = initialValue;
    }

    public void Start(int value = 0)
    {
        _running = true;
        while (_running)
        {
            Count = value;
            Thread.Sleep(5000);
            Count++;
        }
    }

    public void Stop()
    {
        _running = false;
    }
}