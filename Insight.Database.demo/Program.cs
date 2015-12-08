using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Database.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new PersonTest();
            test.Run();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
