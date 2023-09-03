using System;

namespace Module_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Итоговое задание модуля 5.

            (string Name, string LastName, int Age, string[] PetsName, string[] FavoriteColors) user;
            user = GetPersonalData();
            ShowResult(user);

            Console.Write("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static (string Name, string LastName, int Age, string[] PetsName, string[] FavoriteColors) GetPersonalData()
            {
            //Кортеж, который вернем из метода
            (string Name, string LastName, int Age, string[] PetsName, string[] FavoriteColors) user;

            //Инициализация массива имен животных. Т. к. по ходу не факт,что он будет инициализирован (нет живности у пользователя),
            //а студия ругается и не дает вернуть кортеж из метода xD
            user.PetsName = new string[0]; 

            do
            {
                Console.Write("Введите имя пользователя: ");
                user.Name = Console.ReadLine();
            }
            //т. к. в задании есть упоминание о проверке и имени, сделал ее. Но сделал отдельным четвертым методом ValidateString
            while (ValidateString(user.Name, out user.Name) == false);

            do
            {
            Console.Write("Введите фамилию пользователя: ");
            user.LastName = Console.ReadLine();
            }
            while (ValidateString(user.LastName, out user.LastName) == false);

            string strvalueforint; //Промежуточная переменная для записи строкого представления введеного числа
            do
            {
                Console.Write("Введите полный возраст пользователя (сколько полных лет): ");
                strvalueforint = Console.ReadLine();

            }
            while (ValidateNumeric(strvalueforint, out user.Age) == false);

            // Разбираемся с питомцами
            bool flag = false;
            bool havepet = false; //Наличие питомцев. Если не присвоить значение будет ошибка на возможно отсутствующее значение
            Console.WriteLine("Есть ли у пользователя животные? (Да или Нет): ");
            do
            {
                switch (Console.ReadLine().ToUpper()) //Сделал case insensitive
                {
                    case "ДА":
                        havepet = true;
                        flag = true;
                        break;
                    case "НЕТ":
                        havepet = false;
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Вы ввели недопустимый ответ. Давайте попробуем еще раз");
                        break;
                }
            }
            while (flag == false);

            if (havepet)
            {
                int countpets; //Переменная блока кода.
                do
                {
                    Console.Write("Введите количество питомцев у пользователя: ");
                    strvalueforint = Console.ReadLine();

                }
                while (ValidateNumeric(strvalueforint, out countpets) == false);

                user.PetsName = GetObjectsName(countpets, "Введите имя {0}-го питомца: ");
            }
            //Закончили с питомцами

            int countfavcolors;
            do
            {
                Console.Write("Введите количество любимых цветов пользователя: ");
                strvalueforint = Console.ReadLine();

            }
            while (ValidateNumeric(strvalueforint, out countfavcolors) == false);

            user.FavoriteColors = GetObjectsName(countfavcolors, "Введите название {0}-го цвета: ");

            return (user.Name, user.LastName, user.Age, user.PetsName, user.FavoriteColors);
        }

        static bool ValidateNumeric(string origvaluenum, out int correctvaluenum)
        {
            bool flag = int.TryParse(origvaluenum, out correctvaluenum);
            if (flag == false || correctvaluenum <= 0) //Сделал проверку и на 1,5 попугая
            {
                flag = false; // Принудительно выставляю flag в false на случай выполнения условия correctvalueage <= 0
                Console.WriteLine("Вы ввели недопустимый ответ. Давайте попробуем еще раз");
            }
            return flag;
        }

        static bool ValidateString(string origvaluestring, out string correctvaluestring)
        {
            decimal temp;

            if (decimal.TryParse(origvaluestring, out temp)) //Если конвертация удалась, значит строка является числом. Decimal, а не int - потому что 3.14 тоже не сконвертируется, но это не имя
            {
                correctvaluestring = "";
                Console.WriteLine("Вы ввели недопустимый ответ (является числом). Давайте попробуем еще раз");
                return false;
            }
            else
            {
                correctvaluestring = origvaluestring;
                return true;
            }
        }

        static string[] GetObjectsName(in int itemscount, string text)
        /*
        Надо запросить и список кличек, и названия цветов, а код по сути один и тот же. 
        Различается только формулировка ввода.
        Ее можно также передать как параметр. При этом, к моему удивлению и удовольствию, даже отрабатывает подстановка значения {0}

        А вот имя питомца на "не-число" не проверяю. Сам читал о кличках-числительных. Фантазия безгранична.
        
        Также не стал проверять на "не-число" цвета. Тем более, что корректнее уже проверка на корректность названия.
        Тогда нужен будет уже другой валидатор.
        */
        {
            string[] itemsname = new string[itemscount];

            for (int i = 0; i < itemscount; i++)
            {
                Console.Write(text, i + 1);
                itemsname[i] = Console.ReadLine();
            }

            return itemsname;
        }

        static void ShowResult((string Name, string LastName, int Age, string[] PetsName, string[] FavoriteColors) user)
        {
            Console.WriteLine("\nДанные о пользователе:");
            Console.WriteLine("======================");
            Console.WriteLine("Имя - " + user.Name);
            Console.WriteLine("Фамилия - " + user.LastName);
            Console.WriteLine("Возраст - " + user.Age);
            
            if (user.PetsName.Length == 0)
            {
                Console.WriteLine("Пользователь не имеет питомцев");
            }
            else
            {
                string text;
                switch (user.PetsName.Length)
                {
                    case 1:
                        text = "питомец";
                        break;
                    case 2: case 3: case 4:
                        text = "питомца";
                        break;
                    default:
                        text = "питомцев";
                        break;
                }
                Console.WriteLine("У пользователя {0} {1}", user.PetsName.Length, text);
                if (user.PetsName.Length == 1)
                {
                    Console.WriteLine("Его кличка:");
                }
                else 
                {
                    Console.WriteLine("Их клички:");
                }
                
                foreach (string petname in user.PetsName)
                {
                    Console.WriteLine("\t- " + petname);
                }
            }

            Console.WriteLine("Любимые цвета пользователя:");
            foreach (string colorname in user.FavoriteColors)
            {
                Console.WriteLine("\t- " + colorname);
            }
        }
    }
}
