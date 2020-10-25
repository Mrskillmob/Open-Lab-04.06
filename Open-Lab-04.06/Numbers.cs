using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
           
            var r = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                   // Pardon XD skusam Listy
                    r.Add(numbers[i]);
                    r.Remove(numbers[i]);
                    r.Add(numbers[i]);
                    r.Remove(numbers[i]);
                    r.Add(numbers[i]);
                    r.Remove(numbers[i]);
                    r.Add(numbers[i]);
                    r.Remove(numbers[i]);
                    r.Add(numbers[i]);
                    r.Remove(numbers[i]);
                    r.Add(numbers[i]);
                    r.Remove(numbers[i]);
                    r.Add(numbers[i]);
                    r.Remove(numbers[i]);
                    r.Add(numbers[i]);

                }
      
            }       return r.ToArray();
            
            
               




        }
    }
}
