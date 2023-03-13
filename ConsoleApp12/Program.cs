using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = { 1, 3, 4, 5, 7, 11 };

            #region Первое задание 

            var buf1 = array1.Except(array2);
            foreach (int i in buf1)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region Второе задание  

            var buf2 = array1.Intersect(array2);
            foreach (int i in buf2)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region Третье задание 

            var buf3 = array1.Union(array2);
            foreach (int i in buf3)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region Четвертое задание

            var buf4 = array1.Distinct();
            foreach (int i in buf4)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion
        }
    }
}