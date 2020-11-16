using System;
using System.Collections.Generic;
using System.Text;

namespace ScissorsPaperRock.BL
{
    public interface IPlayer
    {
        List<IMove> MovesPlayerCanMake { get; }
        void AddMove(IMove move);
        IMove CurrentPlayerMove { get; }
        public int PlayerScore { get; }
        void GetPlayerMove(int numericalValue);
    }
}
