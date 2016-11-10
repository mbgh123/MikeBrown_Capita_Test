using NUnit.Framework;

using SkeletonCode.CurrencyConverter;
using System;

namespace UnitTests.CurrencyConverter
{
	[TestFixture]
	public class CurrencyConverterTests
	{
		[Test]
		public void ItShouldConvertFromPoundsToDollarsCorrectly()
		{
			decimal amountInPounds = 1m;
			decimal expectedAmountInDollars =  1.25m;

			Converter converter = new Converter();
			decimal result = converter.Convert("GBP", "USD", amountInPounds);

			Assert.AreEqual(expectedAmountInDollars, result);
		}

		[Test]
		public void ItShouldConvertFromDollarsToPoundsCorrectly()
		{
			decimal amountInDollars = 1m;
			decimal expectedAmountInPounds = 0.8m;

			Converter converter = new Converter();
			decimal result = converter.Convert("USD", "GBP", amountInDollars);

			Assert.AreEqual(expectedAmountInPounds, result);
		}

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "inputCurrency is null. Please provide a valid ISO code")]
        public void AnExceptionShouldBeThrownOnNullInput()
        {
            Converter converter = new Converter();
            converter.Convert(null, null, 100);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Did not find a valid pair of input/output ISO codes in rate table. Please check the rate table and provide a valid code pair")]
        public void AnExceptionShouldBeThrownIfAnUnknownCurrencyTypeIsPassedIn()
		{
            // This test is really the same as the test for a valid pair below.

            Converter converter = new Converter();
			converter.Convert("USD", "DDD", 100);
		}

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Did not find a valid pair of input/output ISO codes in rate table. Please check the rate table and provide a valid code pair")]
        public void AnExceptionShouldBeThrownIfNoValidISOPairFound()
        {
            // For a proper unit test we would need to control the contents of the rate table.

            Converter converter = new Converter();
            converter.Convert("USD", "EUR", 100);
        }
    }
}
