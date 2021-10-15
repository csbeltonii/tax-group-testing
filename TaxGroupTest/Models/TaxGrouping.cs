namespace TaxGroupTest.Models
{
    public class TaxGrouping
    {
        public int TaxRateId { get; set; }
        public TaxRate TaxRate { get; set; }
        public int TaxGroupId { get; set; }
        public TaxGroup TaxGroup { get; set; }
    }
}
