﻿using System;
using System.Collections.Generic;
class DecimalToBinaryConverter
{
    static void Main() // 100/100
    {
        int decNumber = int.Parse(Console.ReadLine());

        if (decNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Stack<int> remainders = new Stack<int>();

            while (decNumber > 0)
            {
                remainders.Push(decNumber % 2);
                decNumber /= 2;
            }
            while (remainders.Count > 0)
            {
                Console.Write(remainders.Pop());
            }
            Console.WriteLine();
        }
    }
}