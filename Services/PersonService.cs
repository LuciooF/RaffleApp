using RaffleApp.Core.Contracts;
using RaffleApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace RaffleApp.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetAll()
        {
            var personRepository = new SqlRepository<Person>(new RaffleContext());
            return personRepository.GetAll().ToList();
        }

        public void PopulateDatabase()
        {
            var amountOfPeople = 20;
            var personRepository = new SqlRepository<Person>(new RaffleContext());
            personRepository.EmptyDatabase();
            for (int i = 0; i < amountOfPeople; i++)
            {
                personRepository.Add(new Person()
                {
                    FirstName = $"Luciano",
                    LastName = $"Fraschini-{i}"
                });
            }
        }
    }
}
