using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzipDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "##";
            var error = str.UnzipContent();
            Console.Clear();
            Console.WriteLine(error);
            Console.ReadKey();
        }
    }
}
