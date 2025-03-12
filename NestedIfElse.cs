using System;
    internal class NestedIfElse
    {
        static void Main(string[] args)
        {
            string email, password;
            {
                Console.Write("Enter your Email: ");
                email = Console.ReadLine().ToLower();

                if (email == "bilal@gmail.com")
                {
                    {
                        Console.Write("Enter your Password: ");
                        password = Console.ReadLine();
                        if (password == "Bilal123")
                        {
                            Console.WriteLine("Login Successful...");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Password, try again.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Email, try again.");
                }
            }
        }
    }