
namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("XYZ1234");


        }
    }
}


// base class
//      - always executed first
//      - constructors not inherited

// vehicle constructor is not given to car
// like a method call : base