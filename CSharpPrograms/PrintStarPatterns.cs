using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.CSharpPrograms
{
    internal static class PrintStarPatterns
    {
        public static void PrintRightTriangle()
        {
            Console.WriteLine("Enter pyramid rows: ");
            bool valid = int.TryParse(Console.ReadLine(), out int rows);
            if (!valid) return;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintInvertedRightTriangle()
        {
            Console.WriteLine("Enter pyramid rows: ");
            bool valid = int.TryParse(Console.ReadLine(), out int rows);
            if (!valid) return;
            for (int i = rows; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintPyramid()
        {
            Console.WriteLine("Enter pyramid rows: ");
            bool valid = int.TryParse(Console.ReadLine(), out int rows);
            if (!valid) return;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j <= rows; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintDiamond()
        {
            Console.WriteLine("Enter pyramid rows: ");
            bool valid = int.TryParse(Console.ReadLine(), out int rows);
            if (!valid) return;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintDiamondSimplified()
        {
            Console.WriteLine("Enter pyramid rows: ");
            bool valid = int.TryParse(Console.ReadLine(), out int rows);
            if (!valid) return;

            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(BuildDiamondLine(rows, i));
            }
            for (int i = rows - 1; i >= 1; i--)
            {
                Console.WriteLine(BuildDiamondLine(rows, i));
            }

            static string BuildDiamondLine(int rows, int i)
            {
                StringBuilder line = new();
                line.Append(' ', rows - i);
                line.Append('*', 2 * i - 1);
                return line.ToString();
            }
        }

    }
}
