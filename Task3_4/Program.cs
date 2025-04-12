namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int median = 0;
            if ((b >= a && a >= c) || (c >= a && a >= b))
            {
                median = a;
            }
            else
            {
                if ((a >= b && b >= c) || (c >= b && b >= a))
                {
                    median = b;
                }
                else
                {
                    median = c;
                }
            }
            Console.WriteLine(median);
            Console.ReadKey();
        }
    }
}
