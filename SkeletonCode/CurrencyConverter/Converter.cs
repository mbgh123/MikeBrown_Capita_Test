using System;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
        // Having a rate table that gives you the option of a different conversion factor
        // dependent on direction seems like a reasonable idea.
        // The next step would be to inject the rate table. That would then allow the rates
        // to be changed, and allow the unit tests to setup appropriate rates.
        List<Rate> _rates;

        public Converter()
        {
            _rates = new List<Rate>();

            _rates.Add(new Rate { FromISO = "USD", ToISO = "GBP", ConversionRate = 0.8m });
            _rates.Add(new Rate { FromISO = "GBP", ToISO = "USD", ConversionRate = 1.25m });

            _rates.Add(new Rate { FromISO = "EUR", ToISO = "GBP", ConversionRate = 1.00m });
            _rates.Add(new Rate { FromISO = "GBP", ToISO = "EUR", ConversionRate = 1.00m });
        }



        public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
            // Input Validation
            if (inputCurrency == null)
            {
                throw new ArgumentException("inputCurrency is null. Please provide a valid ISO code");
            }

            if (outputCurrency == null)
            {
                throw new ArgumentException("outputCurrency is null. Please provide a valid ISO code");
            }

            if (_rates.Any( r => r.FromISO == inputCurrency && r.ToISO == outputCurrency) == false)
            {
                throw new ArgumentException("Did not find a valid pair of input/output ISO codes in rate table. Please check the rate table and provide a valid code pair");
            }

            if (_rates.Count(r => r.FromISO == inputCurrency && r.ToISO == outputCurrency) > 1)
            {
                throw new ArgumentException("More than one matching entry in rate table. Please check the rate table for duplicates");
            }

            // Convert
            var conversionFactor = _rates.Single(r => r.FromISO == inputCurrency && r.ToISO == outputCurrency).ConversionRate;

            return amount * conversionFactor;
		}
	}
}
