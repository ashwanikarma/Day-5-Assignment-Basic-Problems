namespace _8_Check_Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program to Check Whether a Number is Even or Odd");
            Console.Write("Enter the number you want to check : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}