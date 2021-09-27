using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var nbr2 = 1; nbr2 <= 30; nbr2++)
            {
                if (nbr2 % 3 == 0 && nbr2 % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (nbr2 % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (nbr2 % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                    Console.Write($"{nbr2} ");
            }
    }
}
