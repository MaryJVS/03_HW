namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число домов");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case int k when (k == 1 || k % 10 == 1):
                    Console.WriteLine("Мы построили {0} дом", n);
                    break;
                case int k when (k == 2 || k % 10 == 2):
                case int l when (l == 3 || l % 10 == 3):
                case int m when (m == 4 || m % 10 == 4):
                    Console.WriteLine("Мы построили {0} дома", n);
                    break;
                default:
                    Console.WriteLine("Мы построили {0} домов", n);
                    break;
            }
            Console.ReadKey();
        }
    }
}
