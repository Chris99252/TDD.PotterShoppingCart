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
            int kindCount = 0;

            for (int i = 1; i < potterBooks.Count; i++)
            {
                var key = "episode" + i;
                if (potterBooks[key] > 0)
                {
                    kindCount += 1;
                }
            }

            var bookCount = potterBooks.Sum(x => x.Value);

            if (bookCount == 1 || kindCount == 1)
            {
                total = bookCount * 100;
            }
            else if (bookCount == 2)
            {
                total = bookCount * 100 * 0.95;
            }
            else if (bookCount == 3)
            {
                total = bookCount * 100 * 0.9;
            }
            return total;
        }
    }
}
