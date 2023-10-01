using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEF.DAL.Models;

namespace TEF.ConsoleApp.Repositories
{
    public class PersonRepository
    {
        public void AddPerson()
        {
            using (var context = new AppDbContext())
            {
                var person = new Person()
                {
                    FirstName = $"FirstName{DateTime.Now.Ticks}",
                    LastName = $"LastName{DateTime.Now.Ticks}",
                };

                context.Add(person);
                context.SaveChanges();
            }
        }

        public Person SelectPerson(int id)
        {
            using (var context = new AppDbContext())
            {
                var person = context.Persons
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                if (person is null)
                {
                    Console.WriteLine("Person not found with {id}.", id);
                }

                return person;
            }
        }

        public void UpdatePerson(Person input)
        {
            using (var context = new AppDbContext())
            {
                var person = context.Persons
                    .Where(x => x.Id == input.Id)
                    .FirstOrDefault();

                if (person is null)
                {
                    Console.WriteLine("Person not found with {id}.", input.Id);

                    return;
                }

                if (person.FirstName == input.FirstName && 
                    person.LastName == input.LastName)
                {
                    Console.WriteLine("Nothing to update, but run savechanges anyways.");
                }

                person.FirstName = input.FirstName;
                person.LastName = input.LastName;

                context.SaveChanges();
            }
        }
    }
}
