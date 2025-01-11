using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    public static class FindXPowerN
    {
        public static void GetXPowerN()
        {
            Console.WriteLine("Enter x^n (Example:3^4)");
            Console.WriteLine("Enter x value: ");
            int baseValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n value: ");
            int power = Convert.ToInt32(Console.ReadLine());
            int result = Exponentiate(baseValue, power);
            Console.WriteLine("Result is " + result);
        }

       public static int Exponentiate(int baseValue, int power)
       {
            int res = baseValue;
            for (int i = 1; i < power; i++)
            {
                res = Multiply(res, baseValue);
            }
            return res;
       }

        public static int Multiply(int res, int baseValue)
        {
            int sum = 0;
            for(int i=0;i<baseValue;i++)
            {
                sum += res;
            }
            return sum;
        }
    }
}
