namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[] x = new int[10];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Random.Shared.Next(100);
                Console.WriteLine($"x[{i}] = {x[i]}");
            }

            int sum = 0;
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    sum += x[i];
                    count++;
                }
            }
            Console.WriteLine($"Even Sum = {sum}");

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"Even Average = {average}");
            }
            else
            {
                Console.WriteLine();
            }

            int? max = null;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    if (max == null || x[i] > max)
                    {
                        max = x[i];
                    }
                }
            }
            if (max != null)
            {
                Console.WriteLine($"Even Maximum = {max}");
            }
            else
            {
                Console.WriteLine();
            }

            int? min = null;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    if (min == null || x[i] < min)
                    {
                        min = x[i];
                    }
                }
            }
            if (min != null)
            {
                Console.WriteLine($"Even Minimum = {min}");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
