namespace _6_Compute_Quotient_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program to Compute Quotient and Remainder");
            Console.Write("Enter the Number Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Number Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend %  divisor;
            Console.WriteLine("Quotient : "+quotient);
            Console.WriteLine("Remainder : "+remainder);
        }
    }
}