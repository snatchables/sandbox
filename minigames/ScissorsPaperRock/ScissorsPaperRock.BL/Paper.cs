using System;
using System.Collections.Generic;
using System.Text;

namespace ScissorsPaperRock.BL
{
    public class Paper : IMove
    {
        public int NumericalValue { get; private set; } = 2;

        public IMove MoveThatCurrentMoveWillLoseTo { get; set; }
    }
}
