namespace HarmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harmonic Number");
            Console.Write("Enter the value of N (not equal to zero) :");
            float N = Convert.ToSingle(Console.ReadLine());
            float harmonicValue = 0.00f;
            Console.Write("Nth Harmonic Value is : ");
            for (int i =1; i<=N; i++)
            {
                harmonicValue += (1 / N);
                Console.Write("1/{0} + ", i);
            }
            Console.Write("\b\b : ");
            Console.Write("{0}",harmonicValue);
            
        }
    }
}