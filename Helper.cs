using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Helper
    {
        /// <summary>
        /// Calculates the total price of items in a shopping cart.
        /// </summary>
        /// <param name="pricePerItem">The price of a single item.</param>
        /// <param name="quantity">The number of items purchased.</param>
        /// <returns>The total price after applying applicable discounts.</returns>
        public static decimal CalculateTotalPrice(decimal pricePerItem, int quantity)
        {
            // Calculate the initial total price
            decimal totalPrice = pricePerItem * quantity;

            // Apply a 10% discount if the quantity exceeds 5
            if (quantity > 5)
            {
                totalPrice *= 0.9m; // 10% discount
            }

            // Apply an additional $5 discount if the total price exceeds $100
            if (totalPrice > 100)
            {
                totalPrice -= 5;
            }

            // Return the final total price
            return totalPrice;
        }
    }
}
