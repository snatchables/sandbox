using System;
using System.Collections.Generic;
using System.Text;

namespace ScissorsPaperRock.BL
{
    public class Scissors : IMove
    {
        public int NumericalValue { get; private set; } = 1;

        public IMove MoveThatCurrentMoveWillLoseTo { get; set; }
    }
}
