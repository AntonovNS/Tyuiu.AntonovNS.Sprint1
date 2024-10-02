using Tyuiu.AntonovNS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.AntonovNS.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Антонов Н.С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("#* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Антонов Никита Сергеевич |  ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу:                          *");
            Console.WriteLine("* два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно,         *");
            Console.WriteLine("* находятся на расстоянии S км друг от друга и движутся в противоположные *");
            Console.WriteLine("* стороны. Определить расстояние между ними через T часов. Ответ          *");
            Console.WriteLine("* округлите до 3 знаков после запятой.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            double v1, v2, S, T;
            Console.WriteLine("Введите значение V1:");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение V2:");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение S:");
            S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение T:");
            T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Площадь прямоугольника равна: " + ds.DistanceOverTime(v1, v2, S, T));
            Console.ReadKey();
        }
    }
}
