using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaffleApp.Domain;
using RaffleApp.Models;
using RaffleApp.Services;
using System.Collections.Generic;
using System.Diagnostics;

namespace RaffleApp.Controllers
{
    public class RaffleController : Controller
    {
        private readonly ILogger<RaffleController> _logger;

        public RaffleController(ILogger<RaffleController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("/raffle/PickRaffleWinners/{amountOfWinners}"), HttpPut("{amountOfWinners}")]
        public List<Person> PickRaffleWinners([FromRoute] int amountOfWinners)
        {
            RaffleService raffleService = new RaffleService();
            return raffleService.PickRaffleWinners(amountOfWinners);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
