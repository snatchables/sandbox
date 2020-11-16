using System;
using System.Collections.Generic;
using System.Text;

namespace ScissorsPaperRock.BL
{
    public static class Game
    {
        public static IPlayer GetRoundWinner(User user, Computer computer)
        {
            if(user.CurrentPlayerMove == computer.CurrentPlayerMove.MoveThatCurrentMoveWillLoseTo)
            {
                return user;
            }

            if(computer.CurrentPlayerMove == user.CurrentPlayerMove.MoveThatCurrentMoveWillLoseTo)
            {
                return computer;
            }
            return null;
        }

        public static IPlayer GetGameWinner(User user, Computer computer)
        {
            if(user.PlayerScore > computer.PlayerScore)
            {
                return user;
            }

            if(computer.PlayerScore > user.PlayerScore)
            {
                return computer;
            }
            return null;
        }
    }
}
