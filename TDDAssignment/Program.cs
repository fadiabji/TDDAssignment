using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TDDAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathCompnent obj = new MathCompnent();

            WriteLine(obj.AddNumber(3, 4));
        }
    }
}
