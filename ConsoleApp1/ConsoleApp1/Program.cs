// Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {                                                  
                exponentiation();          
            
        }

        static void exponentiation()  // Метод для возведения числа в степень, выводит значение на экран
        {
            string input;
            bool numberIsTrue = false;
            

            //Вводим целое число, которое хотим возвести в степень
            Console.Write("Введите число: ");
            input = Console.ReadLine();
            numberIsTrue = int.TryParse(input, out int number);
            
            for (int i = 0; numberIsTrue == false && i < 10; i++)
            {
                Console.Write("Число введено некорректно.\nПовторите ввод: ");
                input = Console.ReadLine();
                numberIsTrue = int.TryParse(input, out number);
            }   //даём 10 попыток на ввод корректного числа


            //Вводим натуральное число, которое будет являться степенью числа
            Console.Write("Введите значение степени: ");
            input = Console.ReadLine();
            numberIsTrue = int.TryParse(input, out int exponent);
            
            for (int i = 0; (numberIsTrue == false || exponent < 1) && i < 10; i++)
            {
                Console.Write("Введено не натуральное число.\nПовторите ввод: ");
                input = Console.ReadLine();
                numberIsTrue = int.TryParse(input, out exponent);
            }   //даём 10 попыток на ввод натурального числа


            //Возводим число в степень
            int result = number;
            for(int i = 1; i < exponent; i++)
            {
                result *= number;
                _ = result != 0 ? true : false;
            }

            Console.Write($"Результат возведения в степень: {result}"); //Выводим результат на экран

        }
    }
}
