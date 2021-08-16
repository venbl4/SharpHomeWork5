﻿using System;

namespace SharpHomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nИмеется следующий текст: \n" + Message.text);

            Console.WriteLine("\nВыведем слова текста, которые содержат не более 5 букв:");
            Message.GetWordsByLength(5);

            Console.WriteLine();
            Console.Write("\nУдалим из текста слова, заканчивающиеся на 'е': ");
            Message.DeleteWordByEndChar('е');

            Console.WriteLine();
            Console.WriteLine("\nСамое длинное слово в тексте: " + Message.FindMaxLengthWord());

            Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + Message.GetLongWordsString());

            Console.ReadKey();
        }
    }   
}
