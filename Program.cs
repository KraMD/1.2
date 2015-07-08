using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = Enterv1(); //вводим скорость такси
            var v2 = Enterv2(); //вводим скорость пешехода
            var S = EnterS(); //вводим продолжительнгость пути
            var T = EnterT(); //вводим время пути
            var p1 = Enterp1(); //вводим стоимость такси
            if ((S / v2) < T) //вставляем функцию if else
            {
                Console.WriteLine("можно идти пешком и успеть.это займет {0} времени", S / v2);
            }
            else
            {
                Console.WriteLine("пешком успеть нельзя.нужно ехать на такси.это займет {0} времени и будет стоить {1} рублей", S / v1, p1 * (S / v1));
            }
            Console.WriteLine("Нажмите кнопку для завершения программы.");
            Console.ReadKey();
        }
        /// <summary>
        /// Функция возвращающая вводимое пользователем значение скорости такси
        /// </summary>
        /// <returns></returns>
        internal static float Enterv1()
        {
            var result = 0f;
            while (result <= 0f)
            {  //  Цикл будет повторяется, пока не будет введено допустимое значение скорости такси
                Console.Write("Введите скорость такси v1: ");
                var value = Console.ReadLine(); // значение пользователя
                Console.WriteLine();    //  Перевод строки ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0)
                {
                    //  Информация об ошибоке в введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое число должно быть числом не равное нулю и не меньшее нуля.");
                }
            }
            return result;
            }
        /// <summary>
        /// Функция возвращающая вводимое пользователем значение скорости пещехода
        /// </summary>
        /// <returns></returns>
        internal static float Enterv2()
        {
            var result = 0f;
            while (result <= 0f)
            {  //  Цикл будет повторяется, пока не будет введено допустимое значение скорости пешехода
                Console.Write("Введите скорость пешехода v2: ");
                var value = Console.ReadLine(); //  значение пользователя
                Console.WriteLine();    // Перевод строки ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0)
                {
                    //  Информация об ошибоке в введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое число должно быть числом не равное нулю и не меньшее нуля.");
                }
            }
            return result;
        }
        /// <summary>
        /// Функция возвращающая вводимое пользователем значение пути
        /// </summary>
        /// <returns></returns>
        internal static float EnterS()
        {
            var result = 0f;
            while (result <= 0f)
            {  //   Цикл будет повторяется, пока не будет введено допустимое значение пути
                Console.Write("Введите расстояние S: ");
                var value = Console.ReadLine(); //  значение пользователя
                Console.WriteLine();    //  Перевод строки ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0)
                {
                    // Информация об ошибоке в введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое число должно быть числом не равное нулю и не меньшее нуля.");
                }
            }
            return result;
            }
        /// <summary>
        /// Функция возвращающая вводимое пользователем значение времени
        /// </summary>
        /// <returns></returns>
        internal static float EnterT()
        {
            var result = 0f;
            while (result <= 0f)
            {  //  Цикл будет повторяется, пока не будет введено допустимое значение времени на путь
                Console.Write("Введите время T: ");
                var value = Console.ReadLine(); //  значение пользователя
                Console.WriteLine();    //  Перевод строки ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0)
                {
                    //  Информация об ошибоке в введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое число должно быть числом не равное нулю и не меньшее нуля.");
                }
            }
            return result;
            }
        /// <summary>
        /// Функция возвращающая вводимое пользователем значение цены на такси
        /// </summary>
        /// <returns></returns>
        internal static float Enterp1()
        {
            var result = 0f;
            while (result <= 0f)
            {  //  Цикл будет повторяется, пока не будет введено допустимое значение цены на такси
                Console.Write("Введите стоимость поездки на такси p1: ");
                var value = Console.ReadLine(); //  значение пользователя
                Console.WriteLine();    //  Перевод строки ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0)
                {
                    //  Информация об ошибоке в введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое число должно быть числом не равное нулю и не меньшее нуля.");
                }
            }
            return result;
        }
    }
}