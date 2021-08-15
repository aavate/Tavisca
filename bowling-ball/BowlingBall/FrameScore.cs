using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public abstract class FrameScore
    {
        public virtual int GetScore(int[] rolls, int rollindex)
        {
            return rolls[rollindex] + rolls[rollindex + 1] + rolls[rollindex + 2];
        }

        public virtual int GetRollIndex(int rollIndex)
        {
            return rollIndex += 2;
        }
    }
}
