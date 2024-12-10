using IgnatovLab1lib;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            Console.Title = "Спринт #1 | Выполнил: Игнатов А.В | МКМб-22-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Лабраторная работа #1                                                      *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #9                                                                *");
            Console.WriteLine("* Выполнил: Игнатов Александр Вадимович | МКМб-22-1                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("X: = 2");
            Console.WriteLine("Y: = -2");
            Console.WriteLine("A: = 5");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("-----------------------");
            int x = 2; int y = -2; int a = 5;
            Console.WriteLine("* Первая функция:                                                            *");
            double zf1 = z1.Zfunc1(x, y, a);
            Console.WriteLine($"z = {zf1}");
            int x2 = 2; int y2 = 4; int a2 = 7;
            Console.WriteLine("* Вторая функция:                                                            *");
            double zf2 = z2.Zfunc2(x2, y2, a2);
            Console.WriteLine($"z = {zf2}");
        }
    }
}