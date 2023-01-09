namespace PowerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Power of 2 Program");
            do
            {
                Console.WriteLine("Enter the argument N (only values from 0 to 31 : ");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N > 31 || N < 0);
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("2 power {0} is {1} ",i , Math.Pow(2, i));
            }
        }
    }
}