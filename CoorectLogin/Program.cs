using System;

namespace CoorectLogin
{
    class Program
    {

        //Метод проверки на соответствие логина требованиям
        static bool CheckLogin(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || IsLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }


        //Метод проверяет, что символ - латинская буква
        private static bool IsLatinLetter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа проверки корректности логина.\nУ вас 3 попытки");
            int NumofTries = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                if (CheckLogin(login))
                {
                    Console.WriteLine("Логин корректен!");
                    break;
                }
                else
                {
                    NumofTries--;
                    Console.WriteLine("Неверный ввод логина. \nДолжны быть соблюдены следующие условия:"
                        + "\nдлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой."
                        + Environment.NewLine + "У Вас осталось " + NumofTries + "попыток");
                }

               
            } while (NumofTries > 0); 

                if(NumofTries == 0)
            {
                Console.WriteLine("У вас не осталось попыток! Приходите в следующий раз.");
            }


            Console.ReadKey();
        }
    }
}
