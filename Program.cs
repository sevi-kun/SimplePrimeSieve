using System;
using System.Collections.Generic;

namespace SimplePrimeSieve
{
    class Program
    {
        static void Main()
        {
            List<int> primes = new List<int> ();
            primes.Add(1);
            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);

            int lastTest = primes[primes.Count -1] + 1;
            bool isPrime = true;

            Console.WriteLine("Welcome to Prime sieve!");
            Console.Write("Enter Sieve Count: ");
            int sieve = Int32.Parse(Console.ReadLine());
            DateTime checkpoint1 = DateTime.Now;

            for (int r = lastTest; r < sieve; r++){
                isPrime = true;
                for (int i = 0; i < r; i++){

                    int x = r;
                    if (i != 0 & i != 1)
                    {
                        var remainder = x % i;
                        if (remainder == 0) {
                            isPrime = false;
                        };
                    
                    }
                }
                if (isPrime){
                    primes.Add(r);
                }

            }
            DateTime checkpoint2 = DateTime.Now;
            Console.WriteLine("Here are the primes:");
            foreach (var item in primes)
            {
                Console.WriteLine(item);
            }
            TimeSpan time = checkpoint2 - checkpoint1;
            Console.WriteLine(
                $"Sieve took {time.TotalSeconds} Seconds. And there are {primes.Count} primes"
            );
        }

    }
}
