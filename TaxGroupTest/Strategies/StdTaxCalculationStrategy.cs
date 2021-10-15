namespace TaxGroupTest.Strategies
{
    public class StdTaxCalculationStrategy : ITaxCalculationStrategy
    {
        public decimal TaxableAmount { get; set; }
        public decimal LocalRate { get; set; }
        public decimal StateRate { get; set; }
        public decimal CountyRate { get; set; }

        public StdTaxCalculationStrategy(decimal taxableAmount, decimal localRate, decimal countyRate, decimal stateRate)
        {
            TaxableAmount = taxableAmount;
            LocalRate = localRate;
            CountyRate = countyRate;
            StateRate = stateRate;
        }

        public decimal Calculate() => (LocalRate + CountyRate + StateRate) * TaxableAmount;
    }
}
