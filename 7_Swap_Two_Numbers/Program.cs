namespace _7_Swap_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program to Swap Two Numbers");
            Console.Write("Enter the value of A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B : ");
            int B = Convert.ToInt32(Console.ReadLine());
            int swapNum = A;
            A = B;
            B = swapNum;
            Console.WriteLine("Value of A after swapping : " + A);
            Console.WriteLine("Value of B after swapping : " + B);
        }
    }
}