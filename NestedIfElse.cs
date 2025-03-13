using System;

namespace Work
{
    internal class NestedIfElse
    {
        static void Main(string[] args)
        {
            string email, password;
            string choice;

            do
            {
                Console.Write("Enter your Email: ");
                email = Console.ReadLine();

                if (email == "abc")
                {
                    Console.Write("Enter your Password: ");
                    password = Console.ReadLine();

                    if (password == "123")
                    {
                        Console.WriteLine("Login Successfull...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Password");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
                do
                {
                    Console.WriteLine("Do you want to try again? Yes or No");
                    choice = Console.ReadLine()?.ToLower();

                    if (choice != "yes" && choice != "no")
                    {
                        Console.WriteLine("Invalid Choice, Please Selecct Yes or No");
                    }
                } while (choice != "yes" && choice != "no");
            } while (choice == "yes");
        }
    }
}
          