using System;

namespace Amazon
{

    
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(excludeOrders: true);
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed");
        }
        //    if(rating == 0)
        //    {
        //        Console.WriteLine("promoted to level 1");
        //    }
        //    else
        //    {
        //        Console.WriteLine("promoted to level 2");
        //    }

        //}
        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}