namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max1 = a > b ? a : b; // Определение бОльшего среди первой пары чисел
            int max2 = max1 > c ? max1 : c; // Сравнение с третьим числом
            Console.WriteLine(max2);
            Console.ReadKey();
        }
    }
}
