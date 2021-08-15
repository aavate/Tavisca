using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {
        private const int MaximunPins = 10;
        public int[] rolls = new int[20];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        /// <summary>
        /// Get the score.
        /// </summary>
        /// <returns>the score.</returns>
        public int GetScore()
        {
            var score = 0;
            var rollindex = 0;
            for (int frame = 0; frame < MaximunPins; frame++)
            {
                FrameScore frameScore = this.GetFrameFactory(rollindex);
                score+= frameScore.GetScore(rolls, rollindex);
                rollindex = frameScore.GetRollIndex(rollindex);
            }

            return score;
        }

        /// <summary>
        /// Get Frame factory.
        /// </summary>
        /// <param name="rollindex">The roll index.</param>
        /// <returns>The frame score object.</returns>
        private FrameScore GetFrameFactory(int rollindex)
        {
            if(IsStrike(rollindex))
            {
                return new Strike();
            }
            else if(IsSpare(rollindex))
            {
                return new Spare();
            }
            else
            {
                return new Standard();
            }
        }

        /// <summary>
        /// Determine is strike or not.
        /// </summary>
        /// <param name="rollindex">The roll index.</param>
        /// <returns>return true if strike otherwise false.</returns>
        private bool IsStrike(int rollindex)
        {
            return rolls[rollindex] == 10;
        }

        /// <summary>
        /// Determine is spare or not.
        /// </summary>
        /// <param name="rollindex">The roll index.</param>
        /// <returns>return true if spare otherwise false.</returns>
        private bool IsSpare(int rollindex)
        {
            return rolls[rollindex] + rolls[rollindex + 1] == 10;
        }
    }
}
