namespace TEF.ConsoleApp
{
    public class TestDbConnection
    {
        public void Run()
        {
            using (var context = new AppDbContext())
            {
                var pulses = context.Pulses.ToList();

                foreach (var pulse in pulses)
                {
                    Console.WriteLine(pulse);
                }
            }
        }
    }
}
