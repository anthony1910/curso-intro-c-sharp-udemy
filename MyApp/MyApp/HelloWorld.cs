using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class HelloWorld
    {
        /* Hello World simples
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        */

        /* Hello World identificando valores informados
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
            }
        }
        */

        // Hello World com retorno int
        static int Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            return 42;
        }

    }
}
