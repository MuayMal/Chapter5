﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZipCode.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = new int[10] {18042, 36548, 98624, 13597, 24584, 36489, 36897, 21549, 12654, 15034};

            

            Console.Write("Enter one of the listed zipcodes: ");
            String input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int index = -1;


            for (int x = 0; x < zip.Length; x++)
            {
                if (n == zip[x])
                {
                    index++;
                    Console.WriteLine("Your package will be there in 5-7 buisness days.");
                   
                }

            }
            if (index == -1)
            {
                Console.WriteLine("Sorry we can't ship it there");
            }
        }
    }
}
