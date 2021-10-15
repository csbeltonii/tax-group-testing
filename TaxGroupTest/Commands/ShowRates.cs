using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaxGroupTest.Data;
using TaxGroupTest.Models;
using static System.Console;

namespace TaxGroupTest.Commands
{
    public class ShowRates
    {
        public ShowRates()
        {
            GetRates();
        }

        public List<TaxRate> Rates { get; set; }

        public void Display()
        {
            foreach (var rate in Rates)
            {
                WriteLine($"{rate.TaxRateId} - {rate.Name}");
                WriteLine("Groups:");

                foreach (var group in rate.Groups)
                {
                    WriteLine($"\t{group.TaxGroup.Name}");
                }

                WriteLine("");
            }
        }

        private void GetRates()
        {
            var db = new Database();


            var rates = db.TaxRates
                          .Include(rate => rate.Groups)
                          .ThenInclude(group => group.TaxGroup)
                          .ToList();

            Rates = rates;
        }
    }
}
