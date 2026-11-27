namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            int[] x = new int[10];
            int i = 0;
            while (i < 10)
            {
                x[i] = Random.Shared.Next(100);
                Console.WriteLine($"x[{i}] = {x[i]}");
                i++;
            }
            int total = 0;
            i = 0;
            while (i < 10)
            {
                total += x[i];
                i++;
            }
            Console.WriteLine($"jami = {total}");
        }
    }
}
