
namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);          // <<< coposition

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}

// is a     inheritance
// has a    composition

// composition : one can contain another
//      ex: car 'has an' engine
//      installer 'has a' logger

// pros of inheritance : 
//      - code re-use
// cons of inhereitance :
//      - easily abused
//      - large hierarchies
//      - fragility
//      - tight coupling

// pros of composition :
//      - code re-use
//      - flexible
//      - less coupling
// cons of composition :
//      - harder to understand
