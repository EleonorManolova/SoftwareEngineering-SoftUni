﻿namespace _04._OrderedSet
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var set = new OrderedSet<int>();
            set.Add(17);
            set.Add(9);
            set.Add(12);
            set.Add(19);
            set.Add(6);
            set.Add(25);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}
