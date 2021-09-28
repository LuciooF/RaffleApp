using RaffleApp.Domain;
using System.Collections.Generic;

namespace RaffleApp.Core.Contracts
{
    public interface IPersonService
    {
        List<Person> GetAll();
        void PopulateDatabase();
    }
}
