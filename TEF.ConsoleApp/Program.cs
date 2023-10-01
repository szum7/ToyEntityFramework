using TEF.ConsoleApp.Repositories;
using TEF.ConsoleApp.Triggers;
using TEF.DAL.Models;

namespace TEF.ConsoleApp
{
    public class Program
    {
        static void TestNoPropertyChangeEvent()
        {
            // Add the triggers
            var manager = new TriggersManager();
            manager.Setup();
            manager.AddEventToInsert();
            manager.AddEventToUpdate();

            // Repository
            var repo = new PersonRepository();

            // Make sure we have entities
            repo.AddPerson();
            repo.AddPerson();
            repo.AddPerson();

            // Use this when you want to create property changes
            var differentPropertyPerson = new Person()
            {
                Id = 1,
                FirstName = $"FirstName{DateTime.Now.Ticks}",
                LastName = $"LastName{DateTime.Now.Ticks}"
            };

            // Use this when you don't want to create property changes
            var samePerson = repo.SelectPerson(1);

            repo.UpdatePerson(samePerson); // differentPropertyPerson | samePerson

            // => update event fires on property changes.
            // => update event does not fire when properties remain the same - regardless if there are same-value property settings or SaveChanges.
        }

        static void Main(string[] args)
        {
            Console.WriteLine("END OF PROGRAM.");
        }
    }
}