namespace _9_Alphabet_Vovel_or_Consonent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program to Check Whether an Alphabet is Vowel or Consonant");
            Console.Write("Please enter the alphabet : ");
            char alphabet = (char)Console.Read();
            if ( alphabet == 'A' || alphabet == 'I' || alphabet == 'E' || alphabet == 'O' || alphabet == 'U' || alphabet == 'a' || alphabet == 'i' || alphabet == 'e' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine(" Alphabet "+alphabet+" is vowel");
            }
            else
            {
                Console.WriteLine(" Alphabet " + alphabet + " is consonent");
            }
        }
    }
}