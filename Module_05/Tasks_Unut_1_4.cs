using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    class Tasks_Unut_1_4
    {
        static void Tasks() 
        {
            //Задание 1
            //(string Name, string[] Dishes) user;

            //Console.WriteLine("Введите имя пользователя");
            //user.Name = Console.ReadLine();

            //user.Dishes = new string[5];
            //for (int i = 0; i < user.Dishes.Length /*5*/; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Введите {0}-е любимое блюдо пользователя", i + 1);
            //    user.Dishes [i] = Console.ReadLine();                
            //}

            //Console.WriteLine();
            //foreach (string item in user.Dishes )
            //{
            //    Console.WriteLine("Пользователю нравится блюдо " + item );
            //}

            //Задание 2
            //while (false) // не будет цикла, так как проверяется на истину
            //{
            //    Console.WriteLine("1");
            //}

            //for (int i = 0; ; i++) // Бесконечный цикл
            //{
            //    Console.WriteLine("1");
            //}

            //do //Одна итерация и выход,так как проверяется на истину
            //{
            //    Console.WriteLine("1"); 
            //} 
            //while (false);

            //while (true) // Бесконечный цикл
            //{
            //    Console.WriteLine("1");
            //}

            ////Задание 5.1.5
            //Console.WriteLine("Введите три любимых цвета пользователя");
            //string[] FavColors = new string[3];
            //for (int i = 0; i < FavColors.Length; i++)
            //{
            //   FavColors[i] = ShowColor();
            //}

            //Console.WriteLine("Ваши любимые цвета");
            //foreach (string item in FavColors)
            //{
            //    Console.WriteLine(item);
            // }

            ////Задание 5.1.6
            //int[] array =  GetArrayFromConsole();

            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}


            ////Задание 5.2.2 - Задание 5.2.7
            //(string name, int age) anketa; //Объявление кортежа

            //Console.Write("Введите Ваше имя: ");
            //anketa.name = Console.ReadLine();

            //Console.Write("Введите Ваш возраст: ");
            //anketa.age = checked(int.Parse(Console.ReadLine()));

            //string[] FavColors = new string[3];
            //for (int i = 0; i < FavColors.Length; i++)
            //{
            //    FavColors[i] = ShowColor(anketa.name, anketa.age);
            //}

            ////Console.WriteLine("\nЗдравствуйте, " + anketa.name);
            ////Console.WriteLine("Вам {0} лет", anketa.age);

            //Console.WriteLine("\nВаши любимые цвета");
            //foreach (string item in FavColors)
            //{
            //    Console.WriteLine(item);
            //}

            ////Задание 5.2.8
            ////Получаем данные в массив
            //int[] array = GetArrayFromConsole();

            ////Сортируем массив
            //array = SortArray(array);

            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            ////Задание 5.2.11
            //(string name, int age) anketa; //Объявление кортежа

            //Console.Write("Введите Ваше имя: ");
            //anketa.name = Console.ReadLine();

            //Console.Write("Введите Ваш возраст: ");
            //anketa.age = checked(int.Parse(Console.ReadLine()));

            //string[] FavColors = new string[3];
            //for (int i = 0; i < FavColors.Length; i++)
            //{
            //    FavColors[i] = ShowColor(anketa.name, anketa.age);
            //}

            //ShowColors(anketa.name, FavColors[0], FavColors[1], FavColors[2]);

            ////Задание 5.2.13
            //ShowColors();

            ////Задание 5.2.14
            ////Получаем данные в массив
            //int[] array = GetArrayFromConsole(7);

            ////Сортируем массив
            //array = SortArray(array);

            //Console.WriteLine();
            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}


            //////Задание 5.2.15
            ////Получаем данные в массив
            ////int[] array = GetArrayFromConsole();
            //var array = GetArrayFromConsole();

            ////Сортируем массив
            ////int[] sortedarray = SortArray(array);
            //var sortedarray = SortArray(array); //Можно с var, чтобы не указывать, что это массив

            //Console.WriteLine();
            //foreach (int item in sortedarray)
            //{
            //    Console.WriteLine(item);
            //}

            ////Задание 5.2.17
            //var array = GetArrayFromConsole();

            //Console.WriteLine();
            //ShowArray(array);

            ////Задание 5.2.18
            //var array = GetArrayFromConsole(10);

            //Console.WriteLine();
            //ShowArray(array, true);

            ////Задание 5.3.1
            //Console.WriteLine("Введите Ваш возраст");
            //int age = int.Parse(Console.ReadLine());

            //ChangeAge(ref age);
            //Console.WriteLine("Ваш возраст {0}", age);


            ////Задание 5.3.6
            //var arr = new int[] { 1, 2, 3 };

            //Console.WriteLine(arr[0]);
            //BigDataOperation(arr);
            //Console.WriteLine(arr[0]);

            ////Задание 5.3.8
            //int arraylenght = 6;
            //var array = GetArrayFromConsole(ref arraylenght);

            //Console.WriteLine();
            //ShowArray(array, true);

            //Задание 5.3.13
            int arraylenght = 5;
            var array = GetArrayFromConsole(ref arraylenght);

            //int[] arraydesc;
            //int[] arrayasc;

            SortArray(in array, out int[] arraydesc, out int[] arrayasc);

            Console.WriteLine();
            ShowArray(arraydesc);

            Console.WriteLine();
            ShowArray(arrayasc);
        }

        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1}" + Environment.NewLine + "Напишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        //static int[] GetArrayFromConsole(string username)
        //{
        //    var result = new int[5];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        //        result[i] = int.Parse(Console.ReadLine());
        //    }

        //    int swap;
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        for (int j = i + 1; j < result.Length; j++)
        //        { 
        //            if (result[i] > result[j])
        //            {
        //                swap = result[i];
        //                result[i] = result[j];
        //                result[j] = swap;
        //            }
        //        }
        //    }
        //        return result;
        //}

        //static int[] GetArrayFromConsole()
        //{
        //    var result = new int[5];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        //        result[i] = int.Parse(Console.ReadLine());
        //    }
        //    return result;
        //}

        //static int[] SortArray(int[] array)
        //{
        //    int swap;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (array[i] > array[j])
        //            {
        //                swap = array[i];
        //                array[i] = array[j];
        //                array[j] = swap;
        //            }
        //        }
        //    }
        //    return array;
        //}

        //static void ShowColors(string username, params string[] favcolors)
        //{
        //    Console.WriteLine("Ваши любимые цвета:");
        //    foreach (var color in favcolors)
        //    {
        //        Console.WriteLine(color);
        //    }
        //}

        static void ShowColors(string username = "Jane", params string[] favcolors)
        {
            Console.WriteLine("Здравствуйте, {0}", username);
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        //static int[] GetArrayFromConsole(int num = 5) //Задание 5.2.14 Необязательный параметр с дефолтнфм значением
        //{
        //    var result = new int[num];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        //        result[i] = int.Parse(Console.ReadLine());
        //    }
        //    return result;
        //}

        static int[] GetArrayFromConsole(ref int num) //Задание 5.3.8
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        //static int[] SortArray(int[] array)//Задание 5.2.14
        //{
        //    int swap;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (array[i] > array[j])
        //            {
        //                swap = array[i];
        //                array[i] = array[j];
        //                array[j] = swap;
        //            }
        //        }
        //    }
        //    return array;
        //}

        //static void ShowArray(int[] array, bool DoSort = false) //Задание 5.2.17
        //{
        //    var tmp_array = array; //Чтобы не портить исходный массив. Так как массив ссылочный тип, то при его обработке данных меняются даже без ключеговго слова ref (byref в vb)

        //    if (DoSort == true)
        //    {
        //        tmp_array = SortArray(array);
        //    }

        //    foreach (int item in tmp_array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static void ShowArray(int[] array, bool DoSort = false) //Задание 5.2.17
        //{
        //    var tmp_array = array; //Чтобы не портить исходный массив. Так как массив ссылочный тип, то при его обработке данных меняются даже без ключеговго слова ref (byref в vb)

        //    if (DoSort == true)
        //    {
        //        tmp_array = SortArray(array);
        //    }

        //    foreach (int item in tmp_array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        static void ChangeAge(ref int age)
        {
            Console.WriteLine("Введите Ваш возраст повторно");
            age = int.Parse(Console.ReadLine());
        }

        static void BigDataOperation(in int[] arr) //При передаче сылочного типа защита in не работает
        {
            arr[0] = 4;
        }

        //static int SumNumbers(ref int num1, in int num2, out int num3, int num4) //Задание 5.3.11
        //{
        //    var a = 5;
        //    num3 = a;
        //    return a;
        //}

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc) //Задание 5.3.13
        {
            sorteddesc = SortArrayDesc(in array);
            sortedasc = SortArrayAsc(in array);
        }

        static int[] SortArrayAsc(in int[] array) //Задание 5.3.13 - от меньшего к большему
        {
            //int[] sortedasc = array; //Это не прокатит - так как массив ссылочный тип и будут менятся оба (два имени одной области памяти)

            /*
            Делаем так
            https://learn.microsoft.com/ru-ru/dotnet/api/system.array.copy?view=net-7.0
            */
            int[] sortedasc = new int[array.Length];
            Array.Copy(array, sortedasc, array.Length);

            int swap;
            for (int i = 0; i < sortedasc.Length; i++)
            {
                for (int j = i + 1; j < sortedasc.Length; j++)
                {
                    if (sortedasc[i] > sortedasc[j])
                    {
                        swap = sortedasc[i];
                        sortedasc[i] = sortedasc[j];
                        sortedasc[j] = swap;
                    }
                }
            }
            return sortedasc;
        }

        static int[] SortArrayDesc(in int[] array) //Задание 5.3.13 - от большего к меньшему 
        {
            //int[] sorteddesc = array; //Это не прокатит - так как массив ссылочный тип и будут менятся оба (два имени одной области памяти)

            /*
            Делаем так
            https://learn.microsoft.com/ru-ru/dotnet/api/system.array.copy?view=net-7.0
            */

            int[] sorteddesc = new int[array.Length];
            Array.Copy(array, sorteddesc, array.Length);

            int swap;
            for (int i = 0; i < sorteddesc.Length; i++)
            {
                for (int j = i + 1; j < sorteddesc.Length; j++)
                {
                    if (sorteddesc[i] < sorteddesc[j])
                    {
                        swap = sorteddesc[i];
                        sorteddesc[i] = sorteddesc[j];
                        sorteddesc[j] = swap;
                    }
                }
            }
            return sorteddesc;
        }

        static void ShowArray(int[] array) //Задание 5.3.13
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

}
