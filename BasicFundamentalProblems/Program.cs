﻿using System;
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
                Console.WriteLine("1. FlipCoin" + "\n" + "2. Leap Year " + "\n" + "3. Power Of Two" + "\n" + "4. Exit");
                Console.WriteLine("Enter The Above Mention Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
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
                        PowerOfTwo power = new PowerOfTwo();
                        power.Table();
                        break;
                    case 4:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}
