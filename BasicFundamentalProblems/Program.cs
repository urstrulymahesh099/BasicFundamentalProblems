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
                Console.WriteLine("1. FlipCoin" + "\n" + "2. Leap Year " + "\n" + "3. Power Of Two" + "\n" + "4. Harmonic Number" + "\n" + "5. Find Quoteint and Reminder" + "\n" + "6. Swapping Two Numbers" + "\n" + "7. Find Even or Odd Number" + "\n" + "8. Exit");
                Console.WriteLine("1. FlipCoin" + "\n" + "2. Leap Year " + "\n" + "3. Power Of Two" + "\n" + "4. Harmonic Number" + "\n" + "5. Find Quoteint and Reminder" + "\n" + "6. Swapping Two Numbers" + "\n" + "7. Find Even or Odd Number" + "\n" + "8.Find Alphabets - Vowel Consonant" + "\n" + "9. Exit");
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
                        HarmonicNumber number = new HarmonicNumber();
                        number.Harmonic();
                        break;
                    case 5:
                        QuoteintAndReminder quo = new QuoteintAndReminder();
                        quo.Quotient();
                        break;
                    case 6:
                        SwapTwoNumbers swa = new SwapTwoNumbers();
                        swa.Swap();
                        break;
                    case 7:
                        EvenOdd eve = new EvenOdd();
                        eve.Number();
                        break;
                    case 8:
                        VowelConsonant vow = new VowelConsonant();
                        vow.Vowels();
                        break;
                    case 9:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}