﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFundamentalProblems
{
    public class EvenOdd
    {
        public void Number()
        {
            Console.WriteLine("Enter Value");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Number is even number");
            else
                Console.WriteLine("Number is odd number");
        }

    }
}