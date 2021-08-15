using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Strike : FrameScore
    {
        public override int GetRollIndex(int rollIndex)
        {
            return rollIndex += 1;
        }
    }
}
