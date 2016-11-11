using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CardGame.Library
{
    /// <summary>
    /// I was inially using new Random().Next, but this occassionaly gave me duplicated results set.
    /// After a quick google I've opted for this..although the use of Random needs deeper study.
    /// 
    /// Taken from Jon Skeet Blog. http://csharpindepth.com/Articles/Chapter12/Random.aspx
    /// </summary>
    public static class RandomProvider
    {
        private static int seed = Environment.TickCount;

        private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
            new Random(Interlocked.Increment(ref seed))
        );

        public static Random GetThreadRandom()
        {
            return randomWrapper.Value;
        }
    }
}
