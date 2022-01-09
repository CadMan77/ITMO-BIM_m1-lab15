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
                Console.WriteLine("Введите шаг/знаменатель:");
                Console.Write("\t");
                delta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число итераций:");
                Console.Write("\t");
                j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите начальное значение:");
                Console.Write("\t");
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Некорректный ввод данных");
                Console.ReadKey();
                return;
            }

            ISeries Progression;
            if (!pt)
                Progression = new ArithProgression(delta);
            else
                Progression = new GeomProgression(delta);
/*            Console.WriteLine($"\t{x}");*/
            Progression.setStart(x); // начальное значение - первый член прогрессии
            for (int i = 0; i < j - 1; i++) 
                Console.WriteLine($"\t{Progression.getNext()}");
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }
}
