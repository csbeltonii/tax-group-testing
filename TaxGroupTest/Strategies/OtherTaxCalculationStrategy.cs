namespace TaxGroupTest.Strategies
{
    public class OtherTaxCalculationStrategy : ITaxCalculationStrategy
    {
        public decimal TaxableAmount { get; set; }
        public decimal LocalRate { get; set; }
        public decimal StateRate { get; set; }
        public decimal CountyRate { get; set; }

        public OtherTaxCalculationStrategy(decimal taxableAmount, decimal localRate, decimal stateRate, decimal countyRate)
        {
            TaxableAmount = taxableAmount;
            LocalRate = localRate;
            StateRate = stateRate;
            CountyRate = countyRate;
        }

        public decimal Calculate() => TaxableAmount > 1600 
            ? (LocalRate + StateRate + CountyRate) * (TaxableAmount - 1600)
            : (StateRate + CountyRate) * TaxableAmount;
    }
}
