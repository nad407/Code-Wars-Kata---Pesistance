using System;
using System.Collections.Generic;
using System.Text;

namespace PersistantBugger
{
    class Persist
    {
        public static int Persistence(long n)
        {
            List<int> numbers = new List<int>();
            int answer = 1;
            int mult = 0;

            while (n > 9)
            {
                while (n > 0)
                {
                    numbers.Add(Convert.ToInt32(n % 10));
                    n = n / 10;
                }

                foreach (int number in numbers)
                {
                    answer = answer * number;
                }

                mult++;

                if (answer < 10)
                {
                    return mult;
                }
                else
                {
                    n = answer;
                    answer = 1;
                    numbers.Clear();
                }
            }

            return 0;
        }
    }
}

        
