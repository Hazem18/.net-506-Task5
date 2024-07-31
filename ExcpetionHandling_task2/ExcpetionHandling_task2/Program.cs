namespace ExcpetionHandling_task2
{
    internal class Program
    {
        public static bool CheckVowels(string s)
        {
         
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            foreach (char c in vowels)
            {
                if (s.Contains(c , StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Valid String");
                    return true;
                }
            }

            throw new NoVowelsException("Invalid string... NO vowels found");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a string: ");
                string s1 = Console.ReadLine();
                CheckVowels(s1);

            }
            catch (NoVowelsException ve)
            {
                Console.WriteLine(ve.Message);
            }
        }
    }
}
