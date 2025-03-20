using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class TryCatchFinally
    {
        static void Main(string[] args)
        {
            int age = 17;
            try
            {

            if(age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                throw new Exception("You are not eligible to vote");
            }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            }


                //try
                //{
                //    int a = 10;
                //    int b = 0;
                //    int c = a / b;
                //}
                //catch (DivideByZeroException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //catch (NullReferenceException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //finally
                //{
                //    Console.WriteLine("Finally Block Executed");
                //}

        }

    }
}
