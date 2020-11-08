using System;
using System.Collections.Generic;
using System.Text;

namespace ScissorsPaperRock.BL
{
    public interface IMove
    {
        int NumericalValue { get; }
        IMove MoveThatCurrentMoveWillLoseTo { get; set; }
    }
}
