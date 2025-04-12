namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int max1 = a > b ? a : b; // Определение бОльшего среди первой пары чисел
            int max2 = c > d ? c : d; // Определение бОльшего среди второй пары чисел
            int max3 = max1 > max2 ? max1 : max2; // Сравнение результатов и определение максимального
            Console.WriteLine(max3);
            Console.ReadKey();
        }
    }
}
