using Tyuiu.KhrapovDY.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KhrapovDY.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метод GetMessage
            // из библеотеки Tyuiu.KhrapovDY.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Даниил"));
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}