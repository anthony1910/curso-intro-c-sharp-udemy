using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int x = 3;
            int y = 4;
            int result = MyClassLibrary.MyMath.AddNumbers(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
