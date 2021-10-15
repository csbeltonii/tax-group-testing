using System.Collections.Generic;

namespace TaxGroupTest.Models
{
    public class TaxGroup
    {
        public int TaxGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<TaxGrouping> Rates { get; set; }
    }
}
