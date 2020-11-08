using ScissorsPaperRock.BL;
using System;
using Xunit;

namespace ScissorsPaperRock.BLTests
{
    public class PlayerTests
    {
        [Fact]
        public void GetPlayerMoveValid()
        {
            User user = new User();
            user.AddMove(new Scissors());
            user.AddMove(new Paper());
            user.AddMove(new Rock());

            user.GetPlayerMove(1);
            var expected = typeof(Scissors);
           Assert.IsType(expected, user.PlayerMove);
        }

        [Fact]
        public void AddMoveValid()
        {
            User user = new User();
            user.AddMove(new Scissors());

            var expected = typeof(Scissors);
            var actual = user.MovesPlayerCanMake[0];

            Assert.IsType(expected, actual);
        }
    }
}
