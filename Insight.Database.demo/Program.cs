// This is a demo for https://github.com/jonwagner/Insight.Database
// It avoids the need for DataReaders and other mapping code.
// It uses stored procedures.

using System;

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
