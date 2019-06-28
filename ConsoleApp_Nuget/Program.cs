using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp_Nuget
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =1;
            int b = 2;
            Class1 math = new Class1();
            Console.Write("a + b = {0}", math.add(a,b));
            Console.ReadKey();
        }
    }
}
