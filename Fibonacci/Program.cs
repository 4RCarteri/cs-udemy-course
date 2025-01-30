namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 1 1 2 3 5 8 12 21 
            int a = 0, b = 1, c;

            Console.Write("How many values do you want?");
            int values = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci sequence with " + values + " values:");

            for (int i = 0; i < values; i++)
            {
                if (i <= 1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                if (i < values - 1)
                {
                    Console.Write(c + ", ");
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}
