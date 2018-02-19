using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleParser
{

    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            parser.Expr();
            Console.WriteLine();
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
