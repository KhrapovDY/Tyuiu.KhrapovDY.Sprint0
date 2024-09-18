namespace Tyuiu.KhrapovDY.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        //Пример линейной структуры
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //Пример линейной структуры
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        //Пример линейной структуры
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                // Привем создан в целях демострации ветвления
                // В реальных проектах нужно использования Exception
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
