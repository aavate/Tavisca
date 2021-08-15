using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Standard : FrameScore
    {
        public override int GetScore(int[] rolls, int rollindex)
        {
            return rolls[rollindex] + rolls[rollindex + 1];
        }
    }
}
