using CardGame.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        List<ICard> _cards;

        public PackOfCards()
        {
            int id = 1;
            string suit = "Spades";
            _cards = new List<ICard>();

            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ace", Value = 11 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Two", Value = 2 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Three", Value = 3 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Four", Value = 4 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Five", Value = 5 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Six", Value = 6 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Seven", Value = 7 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Eight", Value = 8 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Nine", Value = 9 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ten", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Jack", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Queen", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "King", Value = 10 });

            suit = "Hearts";
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ace", Value = 11 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Two", Value = 2 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Three", Value = 3 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Four", Value = 4 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Five", Value = 5 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Six", Value = 6 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Seven", Value = 7 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Eight", Value = 8 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Nine", Value = 9 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ten", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Jack", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Queen", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "King", Value = 10 });

            suit = "Diamonds";
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ace", Value = 11 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Two", Value = 2 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Three", Value = 3 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Four", Value = 4 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Five", Value = 5 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Six", Value = 6 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Seven", Value = 7 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Eight", Value = 8 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Nine", Value = 9 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ten", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Jack", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Queen", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "King", Value = 10 });

            suit = "Clubs";
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ace", Value = 11 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Two", Value = 2 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Three", Value = 3 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Four", Value = 4 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Five", Value = 5 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Six", Value = 6 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Seven", Value = 7 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Eight", Value = 8 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Nine", Value = 9 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Ten", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Jack", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "Queen", Value = 10 });
            _cards.Add(new Card { Id = id++, Suit = suit, Name = "King", Value = 10 });
        }

        public int Count => _cards.Count();

        public void Shuffle()
        {
            Randomizer.Randomize(_cards);
        }

        public ICard TakeCardFromTopOfPack()
        {
            if (_cards.Count() < 1)
            {
                throw new Exception("Can not take card. Empty pack");
            }

            ICard card = _cards.ElementAt(0);
            _cards.RemoveAt(0);

            return card;
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return _cards.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            // TODO ??
            return _cards.GetEnumerator();
        }
    }
}
