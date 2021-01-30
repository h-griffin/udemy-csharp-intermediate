
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}

// class coupling
//      how intereconected classes and subsytems are
//      - classes inside namespace inside assembly
//      - tighly coupled : change in class A will affect class B & C etc...
//      - loosly coupled : encapsulated classes, other classes do not know details


// class relationships
//      - inheritance
//          - UML : unified modeling language
//      - composition : less coupling (good)