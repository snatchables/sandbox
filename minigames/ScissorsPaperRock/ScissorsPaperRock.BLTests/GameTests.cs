using ScissorsPaperRock.BL;
using System;
using System.Net.Http.Headers;
using Xunit;

namespace ScissorsPaperRock.BLTests
{
    public class GameTests
    {
        [Fact]
        public void GetGameWinnerValid()
        {
            User user = new User();
            Computer computer = new Computer();

            IPlayer winner = Game.GetGameWinner(user, computer);

            Assert.Null(winner);
        }

        [Fact]
        public void GetRoundWinnerValid()
        {
            User user = new User();
            Computer computer = new Computer();

            user.AddMove(new Scissors());
            user.AddMove(new Paper());
            user.AddMove(new Rock());
            computer.AddMove(new Scissors());
            computer.AddMove(new Paper());
            computer.AddMove(new Rock());

            user.GetPlayerMove(1);
            computer.GetPlayerMove(2);

            IPlayer winner = Game.GetRoundWinner(user, computer);

            Assert.Equal(user, winner);
        }
    }
}
