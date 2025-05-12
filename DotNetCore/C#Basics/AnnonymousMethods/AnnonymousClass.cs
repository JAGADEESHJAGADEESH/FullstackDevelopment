using System;

namespace C_Basics.AnnonymousMethods
{
    public static class AnnonymousClass
    {
        // Define a delegate
        delegate string GreetDelegate(string name);
        public static void DemonstrateAnonymousFeatures()
        {
            // Anonymous class
            var product = new
            {
                ProductId = 1,
                ProductName = "Laptop",
                Price = 1000.00,
                Quantity = 5
            };

            Console.WriteLine($"Product Details: ID = {product.ProductId}, Name = {product.ProductName}, Price = {product.Price}, Quantity = {product.Quantity}");


            // Anonymous method using a delegate
            GreetDelegate greetDelegate = delegate (string name)
            {
                return $"Hello, {name}!";
            };
            // Call the delegate
            string greeting = greetDelegate("Jagadeesh");
            Console.WriteLine(greeting);
        }
        

        
        
    }
}
