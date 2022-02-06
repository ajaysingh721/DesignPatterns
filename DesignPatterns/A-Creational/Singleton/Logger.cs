namespace DesignPatterns.Creational.Singleton;

public sealed class Logger
{
    // private static Logger? Instance;
    private static readonly Lazy<Logger> Instance2 = new Lazy<Logger>(() => new Logger());
    private static readonly object obj = new object();
    private static int Count = 0;

    public int LogError(string message)
    {
        System.Console.WriteLine($"{message} : {Count}");
        return Count;
    }
    private Logger()
    {
        Count++;
    }

    // Methid 1: 
    public static Logger GetInstance
    {
        // Methid 1:
        // get
        // {
        //     if (Instance == null)
        //     {
        //         lock (obj)
        //         {
        //             if (Instance == null)
        //             {
        //                 Instance = new Logger();
        //             }
        //         }
        //     }
        //     return Instance;
        // }

        // Methid 2:
        get
        {
            return Instance2.Value;
        }

    }
}