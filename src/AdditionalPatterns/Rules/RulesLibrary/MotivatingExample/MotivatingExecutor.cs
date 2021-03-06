using System;
using BuildingBlocks;
using RulesLibrary.Common;

namespace RulesLibrary.MotivatingExample
{
    public static class MotivatingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Motivating example");

            var customer = new Customer()
            {
                DateOfBirth = DateTime.Now.AddYears(-70),
                DateOfFirstPurchase = DateTime.Today.AddYears(-6),
                IsVeteran = false,
            };

            var discountCalculator = new DiscountCalculator();

            var discountPercentage = discountCalculator.Calculate(customer);

            Console.WriteLine($"Customer can get a {discountPercentage:P2} discount on any product.");
        }
    }
}
