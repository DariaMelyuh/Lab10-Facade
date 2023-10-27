using Lab_10_Facade;
class Program
{
    static void Main(string[] args)
    {
        Facade facade = new Facade();
        facade.On();
        facade.Off();
        Console.ReadLine();
    }
}
