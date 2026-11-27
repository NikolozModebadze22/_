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

            // sum of all elements in the array
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
                //sum = sum + x[i]; //this is the same as the line above
            }
            Console.WriteLine($"Sum  = {sum}");

            // average of all elements in the array
            double average = (double)sum / x.Length; // cast sum to double to avoid integer division
            Console.WriteLine($"Average = {average}");

            // find the maximum value in the array
            int max = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
            }
            Console.WriteLine($"Maximum = {max}");

            int min = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
            }
            Console.WriteLine($"Minimum = {min}");

        }
    }
}
