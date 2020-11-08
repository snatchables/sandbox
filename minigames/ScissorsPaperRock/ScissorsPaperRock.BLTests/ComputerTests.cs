using System;
using ScissorsPaperRock.BL;
using Xunit;

namespace ScissorsPaperRock.BLTests
{
    public class ComputerTests
    {
        [Fact]
        public void GetPlayerMoveValid()
        {
            Computer computer = new Computer();
            computer.AddMove(new Scissors());
            computer.AddMove(new Paper());
            computer.AddMove(new Rock());

            computer.GetPlayerMove(1);
            var expected = typeof(Scissors);

            Assert.IsType(expected, computer.PlayerMove);
        }

        [Fact]
        public void AddMoveValid()
        {
            Computer computer = new Computer();
            computer.AddMove(new Scissors());

            var expected = typeof(Scissors);
            var actual = computer.MovesPlayerCanMake[0];

            Assert.IsType(expected, actual);
        }
    }
}
