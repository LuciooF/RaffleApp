using RaffleApp.Domain;
using System.Collections.Generic;

namespace RaffleApp.Core.Contracts
{
    public interface IRaffleService
    {
        public List<Person> PickRaffleWinners(int amountOfWinners);
    }
}
