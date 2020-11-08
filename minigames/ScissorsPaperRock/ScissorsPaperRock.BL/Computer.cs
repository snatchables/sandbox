using System;
using System.Collections.Generic;
using System.Text;

namespace ScissorsPaperRock.BL
{
    public class Computer : IPlayer
    {
        public List<IMove> MovesPlayerCanMake { get; private set; } = new List<IMove>();

        public IMove CurrentPlayerMove { get; private set; }

        public int PlayerScore { get; private set; }

        public void AddMove(IMove move)
        {
            MovesPlayerCanMake.Add(move);
        }

        public void GetPlayerMove(int numericalValue)
        {
            if(MovesPlayerCanMake.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }  
            
            foreach(IMove move in MovesPlayerCanMake)
            {
                if(numericalValue == move.NumericalValue)
                {
                    this.CurrentPlayerMove = move;
                }
            }

            if (CurrentPlayerMove == null)
            {
                Console.WriteLine("a move with that numerical value could not be found");
            }
        }
    }
}
