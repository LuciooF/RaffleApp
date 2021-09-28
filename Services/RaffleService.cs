using RaffleApp.Core.Contracts;
using RaffleApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RaffleApp.Services
{
    public class RaffleService : IRaffleService
    {

        public List<Person> PickRaffleWinners(int amountOfWinners)
        {
            if (amountOfWinners < 0)
            {
                throw new ArgumentOutOfRangeException("Number of winners has to be a positive number");
            }
            var personService = new PersonService();
            var random = new Random();
            var allPeople = personService.GetAll();
            if (amountOfWinners > allPeople.Count)
            {
                throw new ArgumentOutOfRangeException("Number of winners cannot be more than the actual number of participants");
            }
            var winners = allPeople.OrderBy(x => random.Next()).Take(amountOfWinners);
            return winners.ToList();
        }
    }
}
