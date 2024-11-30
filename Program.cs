namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example item price and quantity
            decimal itemPrice = 15.75m; // Price of a single item
            int quantity = 7;          // Number of items purchased

            // Calculate the total price using the method
            decimal totalPrice = CalculateTotalPrice(itemPrice, quantity);

            // Display the result
            Console.WriteLine($"Total Price: {totalPrice:C}");
        }

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
