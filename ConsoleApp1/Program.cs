using System.Text;

namespace Lab1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Функція для табуляції: sin(x) - 1/x ");

            Console.WriteLine($"\nПроміжок [-10;-1]");
            TabulateFunction(-10, -1, 0.1);

            Console.WriteLine();
            Console.WriteLine($"\nПроміжок [1;10]");
            TabulateFunction(1, 10, 0.1);
        }

        static void TabulateFunction(double a, double b, double step)
        {
            for (var x = a; x <= b; x += step)
            {
                double y = Math.Sin(x) - 1 / x;
                Console.WriteLine($"x = {x} | y = {y}");
            }
        }
    }
}
