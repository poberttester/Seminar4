// Программа принимает на вход число и выдаёт сумму цифр в числе.
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            sumOfDigits();
        }

        static void sumOfDigits()   // Метод для расчёта суммы цифр в числе 
        {           
            string input;
            int sum = 0;
            bool isInt = false;

            Console.Write("Введите целое число: ");
            input = Console.ReadLine();
            isInt = int.TryParse(input, out int numb);
            
            for(int i = 0; i < 10 && isInt == false; i++)  // 10 попыток на ввод целого числа
            {
                Console.Write("Вы ввели не целое (или слишком большое) число.\n Повторите ввод: ");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out numb);
            }  

            for (; numb >= 1; numb = numb / 10) //  Рассчёт суммы цифр числа 
            {
                sum = sum + numb % 10;                
            }

            Console.Write("Сумма цифр в числе: " + sum);
        }
    }
}
