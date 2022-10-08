using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TDDAssignment
{
    public class MathCompnent
    {
        public int AddNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        public int GetDifference(int num1, int num2)
        {
            return num1 - num2;

        }

        public string GetNumberSign(double number)
        {
            if (number > 0)
                return "Positive";
            else if (number < 0)
                return "Negative";
            else
                return "Zero";
        }

        
    }
}
