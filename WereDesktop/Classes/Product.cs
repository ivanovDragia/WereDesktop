using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WereDesktop
{
    public partial class Product
    {
        public double LotSum => Sum();

        private double Sum()
        {
            var sum = 0.00;

            foreach (var lot in Lot)
            {
                sum += lot.Quantity;
            }

            return sum;
        }
    }
}
