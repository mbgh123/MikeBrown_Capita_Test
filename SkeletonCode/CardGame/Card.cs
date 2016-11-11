using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
    public class Card : ICard
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Suit { get; set; }

        public int Value { get; set; }
    }
}
