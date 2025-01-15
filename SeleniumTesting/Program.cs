using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginTest.RunTest();

            SearchTest.RunTest();

            NavigationTest.RunTest();

            Console.WriteLine("The end of testing. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
