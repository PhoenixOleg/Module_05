using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    class Recursion
    {
        static void Tasks_Ubit_5()
        {
            //Юнит - Рекурсия
            //Задание 5.5.3

            //Console.WriteLine("Напишите что-то");
            //var str = Console.ReadLine();

            //Console.WriteLine("Укажите глубину эха");
            //var deep = int.Parse(Console.ReadLine());

            //Echo(str, deep);

            ////Задание 5.5.5
            //Console.WriteLine(Factorial(20));

            //Задание 5.5.8
            Console.WriteLine(PowerUp(3, 5));
            
            Console.ReadKey();
        }

        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep; //Приведение int в System.ConsoleColor
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        static decimal Factorial(int x) //Задание 5.5.5
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private static int PowerUp(int N, byte pow) //Задание 5.5.8
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }
}
