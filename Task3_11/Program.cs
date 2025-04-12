namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите габариты участка");
            Console.WriteLine("Сторона a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите габариты первого дома");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите габариты второго дома");
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            int maxQS = Math.Max(q, s);
            int maxQR = Math.Max(q, r);
            int maxPS = Math.Max(p, s);
            int maxPR = Math.Max(p, r);

            int sum1 = p + r;
            int sum2 = p + s;
            int sum3 = q + r;
            int sum4 = q + s;

            if (((sum1 <= a && maxQS <= b) || (sum1 <= b && maxQS <= a)) || ((sum2 <= a && maxQR <= b) || (sum2 <= b && maxQR <= a)) || ((sum3 <= a && maxPS <= b) || (sum3 <= b && maxPS <= a)) || ((sum4 <= a && maxPR <= b) || (sum4 <= b && maxPR <= a)))
            {
                Console.WriteLine("На участке можно разместить дома");
            }
            else
            {
                Console.WriteLine("Разместить дома на участке нельзя");
            }
            Console.ReadKey();
        }
    }
}
