using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class ArraysTypes
    {
        public static void Name(string name="Unknown", string age ="Unknown")
        {
           Console.WriteLine("Your name is " + name + " and your age is " + age);
        }
        static void Main(string[] args)
        {

            ArraysTypes.Name();


            //Jagged Array
            int[][] b = new int[3][];

            b[0] = new[] { 1, 2, 3, 54, 342, 34, 23, 4, 23 };
            b[1] = new[] { 4, 5, 6, 34, 3432, 24, 4, 2 };
            b[2] = new[] { 7, 8, 9, 234, 43, 4, 423 };

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + " ");
                }

                Console.WriteLine();
            }






            Multi Dimensional Array
            int[,] a = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12}
            };


        }
    }
}
