namespace FlipCoin
{
    internal class FlipCoin 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            Console.WriteLine("Flip Coin and print percentage of Heads and Tails");
            double NumberOfTimesCoin;
            double headCount=0, tailCount=0;
            Console.WriteLine("Enter the positive number of times you want to flip a coin : ");
            NumberOfTimesCoin = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();            
            for (int i = 0; i < NumberOfTimesCoin; i++)
            {
                double coin = random.Next(0, 2);
                double num = coin / 2;
                Console.WriteLine(num);
                if (num == 0.5)
                {
                    Console.WriteLine("Tail");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
            }
            //calculating % of Head & % of Tail
            double perHead = (headCount / NumberOfTimesCoin) * 100;
            double perTail = (tailCount / NumberOfTimesCoin) * 100;
            Console.WriteLine("Percetage Head is {0} and Percentage Tail is {1}",perHead,perTail);

        }
    }
}