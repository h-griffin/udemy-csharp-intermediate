
using Amazon;             // <<< namespace

namespace AccessModifiers // <<<
{
    //public class Goldcustomer
    //{
    //    public void OfferVoucher()
    //    {
    //        this.CalculateRating(excludeOrders: true); 
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            // -- bad -- Amazon dependancy
            // internal, cannot view in this assembly
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}

// present as a black box, revealing no information about inside

// Acess modifiers
//  public - accessable everywhere                           - Customer
//  private - only accesable from the class                  - RateCalculator()
//  protected - accesable only from class & derived class    - 
//      breaks encapulation - can see from other classes
//  internal - accessable from same assembly                 - 
//  protected internal - from same assebly or derived class  -

// DLL dynamically linked library  - Amazon > AccessModifiers