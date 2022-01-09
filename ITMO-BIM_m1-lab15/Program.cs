using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pt;
            int x, j, delta;
            Console.WriteLine("Укажите тип прогрессии: \n   \"0\" - Арифметическая;\n   \"1\" - Геометрическая.");
            Console.Write("\t");
            try
            {
                pt = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Введите начальное значение:");
                Console.Write("\t");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите шаг/знаменатель:");
                Console.Write("\t");
                delta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число итераций:");
                Console.Write("\t");
                j = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Некорректный ввод данных");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Результат:");
            if (!pt)
            {
                ArithProgression AP = new ArithProgression(delta);
                AP.setStart(x);
                Console.WriteLine($"\t{x}");
                for (int i = 0; i < j - 1; i++)
                    Console.WriteLine($"\t{AP.getNext()}");
            }
            else if (pt)
            {
                GeomProgression GP = new GeomProgression(delta);
                GP.setStart(x);
                Console.WriteLine($"\t{x}");
                for (int i = 0; i < j - 1; i++)
                    Console.WriteLine($"\t{GP.getNext()}");
            }
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }
}
