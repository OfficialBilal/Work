using System;

namespace Work
{
    internal class NestedIfElse
    {
        static void Main(string[] args)
        {
            string email, password;
            {
                string choice = string.Empty;
                do
                { 
                   Console.Write("Enter your Email: ");
                   email = Console.ReadLine().ToLower();

                    if (email == "abc")
                    {
                        Console.Write("Enter your Password: ");
                        password = Console.ReadLine();
                        {
                            if (password == "123")
                            {
                                Console.WriteLine("Login Successful...");
                                do
                                {
                                    Console.WriteLine("Do you want to try again Yes / No");
                                    choice = Console.ReadLine().ToLower();
                                    if (choice != "yes" && choice != "no")
                                    {
                                        Console.WriteLine("Invalid Choice");
                                    }
                                } while (choice != "yes" && choice != "no");
                            }
                            else
                            {
                                Console.WriteLine("You have Entered Wrong Password");
                            }
                        }
                    }
                    else { Console.WriteLine("You have Entered Wrong Email"); }
                      
                } while (choice == "yes");
            }
        }
    }
}
