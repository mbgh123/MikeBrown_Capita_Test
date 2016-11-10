using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CurrencyConverter
{
    public class Rate
    {
        public string FromISO { get; set; }
        public string ToISO { get; set; }
        public decimal ConversionRate { get; set; }
    }
}
