using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPinBowl
{
    public class GameTenPin
    {
        /* Bowling game
         * Main points - Strike - Spare
         * Frame - 2 Rolls
         * 10th Frame - 3 Rolls allowable provided first two rolls have ten pin down
         */

        public int[] rolls = new int[21];
        private int currentRoll = 0;

        /// <summary>
        /// This represents each throw of the player.
        /// </summary>
        /// <param name="pins">Number of pins knocked during the throw. </param>
        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        /// <summary>
        /// This method calculates the score for a game. 
        /// </summary>
        public int score()
        {
            int score = 0;
            int frameIndex = 0;

            // iterate over 10 frames of a game
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += SumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return score;

        }

        /// <summary>
        /// This method checks if the current rolls is a strike
        /// </summary>
        /// <param name="frameIndex"></param>
        private bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        /// <summary>
        /// This method checks if the roll results in a Spare 
        /// </summary>
        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        /// <summary>
        /// This method returns the sum of a frame - 2 rolls
        /// </summary>
        /// <param name="frameIndex"></param>
        private int SumOfBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        /// <summary>
        /// THis methods calculates Spare bonus
        /// </summary>
        /// <param name="frameIndex"></param>
        private int SpareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        /// <summary>
        /// This method calculates the Strike bonus.
        /// </summary>
        /// <param name="frameIndex"></param>
        private int StrikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

    }
}
