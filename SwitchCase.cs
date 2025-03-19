namespace Work
{
    class SwitchCase
    {
        void Main(string[] args)
        {
            while (true)
                {
                Console.WriteLine("Enter Day Number");
                int week = int.Parse(Console.ReadLine());

                switch (week)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        return;
                    case 2:
                        Console.WriteLine("Tuesday");
                        return;
                    case 3:
                        Console.WriteLine("Wednesday");
                        return;
                    case 4:
                        Console.WriteLine("Thursday");
                        return;
                    case 5:
                        Console.WriteLine("Friday");
                        return;
                    case 6:
                        Console.WriteLine("Saturday");
                        return;
                    case 7:
                        Console.WriteLine("Sunday");
                        return;
                    default:
                        Console.WriteLine("Invalid Day");
                        break;
                }
            }
        }
    }
}