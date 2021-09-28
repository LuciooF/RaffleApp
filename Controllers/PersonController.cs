using Microsoft.AspNetCore.Mvc;
using RaffleApp.Domain;
using RaffleApp.Services;
using System.Collections.Generic;
using System.Linq;

namespace RaffleApp.Controllers
{
    public class PersonController : Controller
    {
        public List<Person> GetAll()
        {
            var personRepository = new SqlRepository<Person>(new RaffleContext());
            return personRepository.GetAll().ToList();
        }

        public List<Person> PopulateDatabase()
        {
            PersonService personService = new PersonService();
            personService.PopulateDatabase();
            return GetAll();
        }
    }
}
