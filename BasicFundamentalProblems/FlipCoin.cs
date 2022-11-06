using System;
namespace BasicFundamentalProblems

{

    public class FlipCoin
    {
        Random random = new Random();
        public void Play()
        {
            double head = 0, tail = 0;
            Console.WriteLine("Number of times of flip the coin");        
            int n = Convert.ToInt32(Console.ReadLine());
            double COUNT = n;
            while (n > 0)
            {
                if (random.NextDouble() > 0.5)
                    head++;
                else
                    tail++;
                n--;
            }
            Console.WriteLine("Head will come - " +  head);
            Console.WriteLine("Tail will come - " +  tail);
            double HEAD_PERCENTAGE = (head / COUNT) * 100;
            double TAIL_PERCENTAGE = (tail / COUNT) * 100;
            Console.WriteLine("Head Percenage will be - " + HEAD_PERCENTAGE + "\n" + "Tail Percentage will be - " + TAIL_PERCENTAGE);
        }
    }
}