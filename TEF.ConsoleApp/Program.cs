namespace TEF.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            new TestDbConnection().Run();

            Console.WriteLine("END OF PROGRAM.");
        }
    }
}