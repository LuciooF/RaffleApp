using RaffleApp.Services;
using System;
using System.Linq;
using Xunit;

namespace RaffleTests
{
    public class RaffleTests
    {
        private readonly RaffleService _raffleService;
        private readonly PersonService _personService;
        public RaffleTests()
        {
            _raffleService = new RaffleService();
            _personService = new PersonService();
        }
        [Fact]
        public void Picks_correct_amount_winners()
        {
            var winnerCount = 3;
            var winners = _raffleService.PickRaffleWinners(winnerCount);
            Assert.Equal(winnerCount, winners.Count);
        }
        [Fact]
        public void More_winners_than_people_not_allowed()
        {
            var currentPeopleInDbCount = _personService.GetAll().Count() + 2;
            Assert.Throws<ArgumentOutOfRangeException>(() => _raffleService.PickRaffleWinners(currentPeopleInDbCount));
        }
        [Fact]
        public void Negative_numbers_not_allowed()
        {
            var winnerCount = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => _raffleService.PickRaffleWinners(winnerCount));
        }
    }
}
