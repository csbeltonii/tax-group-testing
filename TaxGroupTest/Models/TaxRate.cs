using System.Collections.Generic;

namespace TaxGroupTest.Models
{
    public class TaxRate
    {
        public int TaxRateId { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal TaxMinimum { get; set; }
        public decimal Cap { get; set; }

        public ICollection<TaxGrouping> Groups { get; set; }
    }
}
