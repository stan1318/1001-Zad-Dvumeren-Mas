using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001_Zad_Dvumeren_Mas
{
    class Program
    {
        static void printArray(int[,] darray, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(darray[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int rows;
            int cols;
            do
            {
                Console.WriteLine("Type in how many rows you want(max 10): ");
                rows = Convert.ToInt32(Console.ReadLine());
            }
            while (rows < 0 || rows > 10);
            do
            {
                Console.WriteLine("Type in how many columns you want(max 10): ");
                cols = Convert.ToInt32(Console.ReadLine());
            }
            while (cols < 0 || cols > 10);
            Console.WriteLine("Type the array numbers with space between them and each row on a new line: " + Environment.NewLine);
            int[,] darray = new int[rows, cols];
            string[] arrstr = new string[cols];
            for (int i = 0; i < rows; i++)
            {
                arrstr = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    darray[i, j] = Convert.ToInt32(arrstr[j]);
                }
            }
            // MaxandMin(darray, rows, cols);
            ReverseRowsCols(darray, rows, cols);
            
            Console.ReadLine();
        }
        static void MaxandMin(int[,] darray, int rows, int cols)
        {
            int max = darray[0, 0];
            int min = darray[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (min > darray[i, j])
                        min = darray[i, j];

                    if (max < darray[i, j])
                        max = darray[i, j];
                }

            }
            Console.WriteLine("Min:{0} Max:{1}", min, max);
        }
        static void ReverseRowsCols(int[,] darray, int rows, int cols)
        {
            int[,] revarray = new int[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    revarray[i, j] = darray[j, i];
                }

            }
            Console.WriteLine();
            printArray(revarray, cols, rows);


        }

    }
}
