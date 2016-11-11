using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
	public interface ICard
	{
        int Id { get; set; }
        string Suit { get; set; }
        int Value { get; set; }
        string Name { get; set; }
    }
}
