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
            decimal totalPrice = Helper.CalculateTotalPrice(itemPrice, quantity);

            // Display the result
            Console.WriteLine($"Total Price: {totalPrice:C}");
        }

      
       
    }
}
