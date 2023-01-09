namespace LeapYear
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap Year Program");
            Console.WriteLine("Please Enter only 4 digit Number : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if( year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(year + " is a Leap Year!");
            }
            else if (year % 400 == 0 )
            {
                Console.WriteLine(year + " is a Leap Year!");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year!");
            }

        }
    }
}