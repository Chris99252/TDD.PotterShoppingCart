using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart.Service.Chris
{
    public class PotterShopping
    {

        public double PotterCalculator(Dictionary<string, double> potterBooks)
        {
            double total = 0;
            var bookCount = potterBooks.Sum(x => x.Value);
            if (bookCount == 1)
            {
                total = bookCount * 100;
            }
            else if (bookCount == 2)
            {
                total = bookCount * 100 * 0.95;
            }
            return total;
        }
    }
}
