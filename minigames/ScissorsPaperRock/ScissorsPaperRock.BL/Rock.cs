using System;
using System.Collections.Generic;
using System.Text;

namespace ScissorsPaperRock.BL
{
    public class Rock : IMove
    {
        public int NumericalValue { get; private set; } = 3;

        public IMove MoveThatCurrentMoveWillLoseTo { get; set; } 
    }
}
