using System;
namespace BasicFundamentalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. FlipCoin" + "\n" + "2. Leap Year " + "\n" + "3. Exit");
                Console.WriteLine("Enter The Above Mention Case");
                int Case = Convert.ToInt32(Console.ReadLine());
                switch (Case)
                {
                    case 1:
                        FlipCoin enter = new FlipCoin();
                        enter.Play();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.Year();
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}