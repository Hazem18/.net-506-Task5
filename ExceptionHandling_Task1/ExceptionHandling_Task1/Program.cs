
namespace ExceptionHandling_Task1
{
    internal class Program
    {
        public static void checkdublicates(List<int> list , int value)
        {
            bool flag = false;
            foreach (int i in list)
            {
                if (i == value)

                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                throw new DuplicateNumberException("Error...Attempt to add duplicate numbers");
            else
                list.Add(value);
        }

        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                Console.Write("Enter the number of elements: ");
                int lenght = int.Parse(Console.ReadLine());

                for (int i = 0; i <lenght; i++)
                {
                    Console.Write($"Enter Element [{i+1}]: ");
                    int value = int.Parse(Console.ReadLine());
                    checkdublicates(list, value);
                }

                Console.Write("List elements [");
                foreach (int i in list)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("]");
            }

            catch (DuplicateNumberException de)
            {

                Console.WriteLine(de.Message); 
            }
        }

    }
}
