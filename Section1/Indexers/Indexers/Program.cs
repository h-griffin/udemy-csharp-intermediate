
using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
        }
    }
}

// INDEXERS
//    - indexer is property
//    public sting this[string key] <<
//{
//    get {...}
//    set {...}
//}

// cookie["name"] = "Mosh";           <<<
// cookie.SetItem("name", "Mosh");
//
// var name = cookie["name"];         <<<
// var name = cookie.GetItem("name");

