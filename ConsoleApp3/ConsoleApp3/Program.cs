// Программа задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ArrayShow());
        }

        
        static string ArrayShow() //  Метод для создания и отображения массива в консоли
        {                               
            int[] arr = new int[8];
            //int values = 0;
            bool isInt = false;


            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                isInt = int.TryParse(Console.ReadLine(), out int values);
                                
                
                    for(int j = 0; j <= 10 && isInt == false; j++)//защита от ввода значений формата НЕ int
                    {
                        if (j == 10)
                            return "\n!!!     ERROR: В массив вводятся числа непринадлежащие к типу Integer       !!!\n";

                        Console.WriteLine("Число не входит в формат Integer");
                        Console.Write($"Повторите ввод {i + 1} элемента массива: ");
                        isInt = int.TryParse(Console.ReadLine(), out values);
                        Console.Write("");
                    }
                                        
                arr[i] = values;
                Console.Write("");
            }

            Console.WriteLine("\n                 Вывод\n-------------------------------------------------------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"        {i + 1} элемент массива: {arr[i]}");
                Console.Write("\n");
            }

            return "";
        }
    }
}
