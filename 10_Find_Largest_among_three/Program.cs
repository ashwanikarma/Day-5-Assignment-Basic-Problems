namespace _10_Find_Largest_among_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program to Find the Largest Among Three Numbers");
            Console.WriteLine("Enter Three Different Values only");
            Console.Write("Enter value of A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of B : ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of C : ");
            int C = Convert.ToInt32(Console.ReadLine());

            if ( A > B && A > C)
            {
                Console.WriteLine("A is Greatest Number among Three numbers");
            }
            else if ( B > A && B > C)
            {
                Console.WriteLine("B is Greatest Number among Three numbers");
            }
            else
            {
                Console.WriteLine("C is Greatest Number among Three numbers");
            }
        }
    }
}