﻿using System.Collections.Generic;

using NUnit.Framework;

using SkeletonCode.CardGame;

namespace UnitTests.CardGame
{
	[TestFixture]
	public class CardGameTests
	{
		[Test]
		public void ThePackOfCardsShouldContain52CardsWhenCreated ()
		{
			IPackOfCardsCreator packOfCardsCreator = new PackOfCardsCreator();
			IPackOfCards packOfCards = packOfCardsCreator.Create();
			const int expectedNumberOfCards = 52;
			int numberOfCards = packOfCards.Count;

			Assert.AreEqual(expectedNumberOfCards, numberOfCards);
		}

		[Test]
		public void TheCardsShouldAllBeUniqueAfterTheShuffle ()
		{
			IPackOfCardsCreator packOfCardsCreator = new PackOfCardsCreator();
			IPackOfCards packOfCards = packOfCardsCreator.Create();

			packOfCards.Shuffle();

			CollectionAssert.AllItemsAreUnique(packOfCards);
		}

        [Test]
        public void ShufflesShouldNotRepeatPreviousShuffleOrders()
        {
            // We want to check that the shuffle will produce a different order on each call.
            

            IPackOfCardsCreator packOfCardsCreator = new PackOfCardsCreator();
            IPackOfCards packOfCards = packOfCardsCreator.Create();

            packOfCards.Shuffle();

            // Save the id's from the first suffle
            List<int> firstShuffleIids = new List<int>();
            foreach (var item in packOfCards)
            {
                firstShuffleIids.Add(item.Id);
            }

            // Shuffle again
            packOfCards.Shuffle();

            // Save the id's from the second suffle
            List<int> secondShuffleIids = new List<int>();
            foreach (var item in packOfCards)
            {
                secondShuffleIids.Add(item.Id);
            }


            CollectionAssert.AreNotEqual(firstShuffleIids, secondShuffleIids);
        }

        [Test]
		public void ThePackOfCardsShouldContainTheSameNumberOfCardsWhenShuffled()
		{
			IPackOfCardsCreator packOfCardsCreator = new PackOfCardsCreator();
			IPackOfCards packOfCards = packOfCardsCreator.Create();
			int expectedCount = packOfCards.Count;

			packOfCards.Shuffle();

			int resultCount = packOfCards.Count;

			Assert.AreEqual(expectedCount, resultCount);
		}

		[Test]
		public void TheCountOfThePackShouldDecreaseByOneAfterACardIsTakenFromTheTop()
		{
			IPackOfCardsCreator packOfCardsCreator = new PackOfCardsCreator();
			IPackOfCards packOfCards = packOfCardsCreator.Create();
			int countBeforeTheCardIsRemoved = packOfCards.Count;
			int expectedCountAfterCut = countBeforeTheCardIsRemoved - 1;

			ICard card = packOfCards.TakeCardFromTopOfPack();

			int countResult = packOfCards.Count;

			Assert.AreEqual(expectedCountAfterCut, countResult);
		}

		[Test]
		public void TheCardShouldNoLongerBeInThePackAfterACardIsRemoved()
		{
			IPackOfCardsCreator packOfCardsCreator = new PackOfCardsCreator();
			IPackOfCards packOfCards = packOfCardsCreator.Create();
			
			ICard cardRemoved = packOfCards.TakeCardFromTopOfPack();

			CollectionAssert.DoesNotContain(packOfCards, cardRemoved);
		}
	}
}
