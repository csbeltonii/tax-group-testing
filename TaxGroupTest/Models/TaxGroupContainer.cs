using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaxGroupTest.Data;
using TaxGroupTest.Strategies;
using static System.Console;

namespace TaxGroupTest.Models
{
    public class TaxGroupContainer
    {
        public TaxGroup TaxGroup { get; set; }
        public decimal LocalTaxRate { get; set; }
        public decimal StateTaxRate { get; set; }
        public decimal CountyTaxRate { get; set; }

        public ITaxCalculationStrategy TaxCalculationStrategy { get; set; }


        public TaxGroupContainer()
        {
            GetTaxGroup();
            GetTaxRates();
        }

        private void GetTaxGroup()
        {
            var db = new Database();

            TaxGroup = db.TaxGroups
                         .Include(group => group.Rates)
                         .ThenInclude(rates => rates.TaxRate)
                         .First(group => group.TaxGroupId == 1);
        }

        private void GetTaxRates()
        {
            LocalTaxRate = TaxGroup.Rates
                                   .First(grouping => grouping.TaxRateId == 4)
                                   .TaxRate.Rate / 100;
            StateTaxRate = TaxGroup.Rates
                                   .First(grouping => grouping.TaxRateId == 3)
                                   .TaxRate.Rate / 100;
            CountyTaxRate = TaxGroup.Rates
                                    .First(grouping => grouping.TaxRateId == 2)
                                    .TaxRate.Rate / 100;
        }

        public void CalculateTaxes() 
        {
            var result = TaxCalculationStrategy.Calculate();

            WriteLine($"Result when calculating for Other:\t {result:C2}");
        }
    }
}
