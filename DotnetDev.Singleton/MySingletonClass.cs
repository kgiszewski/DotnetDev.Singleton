namespace DotnetDev.Singleton;

public class MySingletonClass
{
    private static readonly object Lock = new ();
    private static MySingletonClass _instance;
    private MySingletonClass()
    {}

    public void DoSomething()
    {
        Console.WriteLine("Doing stuff...");
    }
    
    public static MySingletonClass Instance()
    {
        if (_instance != null) return _instance;
        
        lock (Lock)
        {
            _instance ??= new MySingletonClass();
        }

        return _instance;
    }
}