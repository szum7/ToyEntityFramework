using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEF.DAL.Models;

namespace TEF.ConsoleApp.Triggers
{
    public class TriggersManager
    {
        public void Setup()
        {
            //var mycontext = new AppDbContext() { TriggersEnabled = true };
        }

        public void AddEventToInsert()
        {
            Triggers<Person>.Inserting += entry =>
            {
                Console.WriteLine($"Person was inserted: {entry.Entity}");
            };
        }

        public void AddEventToUpdate()
        {
            Triggers<Person>.Updating += entry =>
            {
                Console.WriteLine($"Person was updated: {entry.Entity}");
            };
        }
    }
}
