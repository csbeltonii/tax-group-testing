using TaxGroupTest.Commands;
using TaxGroupTest.Models;
using TaxGroupTest.Strategies;
using static System.Console;

namespace TaxGroupTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal taxableAmount = 2000.00M;
            var showRates = new ShowRates();
            var container = new TaxGroupContainer();

            showRates.Display();
            WriteLine();

            var stdCalculation = new StdTaxCalculationStrategy(
                taxableAmount,
                container.LocalTaxRate,
                container.CountyTaxRate,
                container.StateTaxRate
            );

            var otherCalculation = new OtherTaxCalculationStrategy(
                taxableAmount,
                container.LocalTaxRate,
                container.CountyTaxRate,
                container.StateTaxRate
            );

            container.TaxCalculationStrategy = stdCalculation;

            container.CalculateTaxes();

            container.TaxCalculationStrategy = otherCalculation;

            container.CalculateTaxes();

            Read();
        }
    }
}