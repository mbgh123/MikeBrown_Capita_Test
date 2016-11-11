using SkeletonCode.CardGame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Library
{
    public static class Randomizer 
    {
        public static void Randomize(List<ICard> input)
        {
            Random rnd = RandomProvider.GetThreadRandom();
            int upper = input.Count() -1;

            // Shuffle the source
            while (upper > 0)
            {
                int r = rnd.Next(0, upper); //  Range: 0 to 1 below upper

                // swap _source[r] with _source[upper]
                ICard temp = input[upper];
                input[upper] = input[r];
                input[r] = temp;

                upper--;
            }
        }
    }
}
