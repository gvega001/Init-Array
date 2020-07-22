using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace InitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] jagged = {new int[] {1, 2},
                 new int[] {3},
                new int[] {4,5,6} };
            OutputArray(rectangular);
            WriteLine();
            OutputArray(jagged);

        }
        static void OutputArray(int[,] array)
        {
            WriteLine("Values in the rectangular array by row are: ");
            //loop through arrays rows
            for (int row = 0; row < array.GetLength(0); row++)
            {
                //loop through columns of current row
                for (int column = 0; column < array.GetLength(1); ++column)
                {
                    Write($"{array[row, column]}");
                }
                WriteLine();
            }
        }
        static void OutptArray(int[][] array)
        {
            WriteLine("Values in the jagged array by row are:");

            //loop throught each row
            foreach (var row in array)
            {
                //loop through each element in current row
                foreach (var element in row)
                {
                    Write($"{element}");
                }
                WriteLine();
            }
        }
    }
}
