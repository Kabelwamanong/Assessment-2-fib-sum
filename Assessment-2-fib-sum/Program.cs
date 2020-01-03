using System;

namespace Assessment_2_fib_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Assessment 2: Finding the sum of even-valued terms in a Fibonacci sequence where terms dont exceed 5 million
            var prev = 0;
            var cur = 1;
            var total = 0;

            while (true)
            {
                var nx = prev + cur;
                prev = cur;
                cur = nx;

                if (cur >= 5000000)
                {
                    break;
                }
                if (cur % 2 == 0)
                {
                    total += cur;
                }
            }
            Console.WriteLine(total);
        }
    }
}
