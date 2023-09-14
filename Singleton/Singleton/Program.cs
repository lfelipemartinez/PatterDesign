using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var single = Singleton.Singleton.Instance;
        var log = Singleton.Log.Instance;
        log.save("prueba");
        log.save("hola");
    }
}