namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];

            // Fill the array with random numbers and display them
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Random.Shared.Next(100);
                Console.WriteLine($"x[{i}] = {x[i]} {(x[i] % 2 == 0 ? "even" : "odd")}");
            }

            // Declare variables to hold sums, counts, and averages
            int evenSum = 0,
                oddSum = 0,
                evenCount = 0,
                oddCount = 0;
            double? evenAverage = null,
                oddAverage = null;

            // Calculate sums and counts
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    evenSum += x[i];
                    evenCount++;
                }
                else
                {
                    oddSum += x[i];
                    oddCount++;
                }
            }

            // Calculate averages if counts are greater than zero
            if (evenCount > 0)
            {
                evenAverage = (double)evenSum / evenCount;
            }
            if (oddCount > 0)
            {
                oddAverage = (double)oddSum / oddCount;
            }

            // Find the maximum of even numbers
            int? evenMax = null;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    if (evenMax == null || x[i] > evenMax)
                    {
                        evenMax = x[i];
                    }
                }
            }

            int? oddMax = null;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 != 0)
                {
                    if (oddMax == null || x[i] > oddMax)
                    {
                        oddMax = x[i];
                    }
                }
            }

            int? evenMin = null;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    if (evenMin == null || x[i] < evenMin)
                    {
                        evenMin = x[i];
                    }
                }
            }

            int? oddMin = null;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 != 0)
                {
                    if (oddMin == null || x[i] < oddMin)
                    {
                        oddMin = x[i];
                    }
                }
            }

            // todo: We need to finish following tasks:
            // 1. Find the maximum of odd numbers
            // 2. Find the minimum of even numbers
            // 3. Find the minimum of odd numbers

            // Display the results
            Console.WriteLine($"Sum of even numbers: {evenSum}");
            Console.WriteLine($"Sum of odd numbers: {oddSum}");
            Console.WriteLine($"Count of even numbers: {evenCount}");
            Console.WriteLine($"Count of odd numbers: {oddCount}");
            Console.WriteLine($"Average of even numbers: {(evenAverage != null ? evenAverage : "N/A")}");
            Console.WriteLine($"Average of odd numbers: {(oddAverage != null ? oddAverage : "N/A")}");
            Console.WriteLine($"Maximum of even numbers: {(evenMax != null ? evenMax : "N/A")}");
        }
    }
}
