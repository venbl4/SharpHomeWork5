using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpHomeWork5
{
    static class Message
    {
        static public string text;

        static Message()
        {
            text = "Всякий ученый болтун, откопав новое или хорошо забытое " +
                "старое средство: физическое, химическое или атомное – спешит " +
                "проверить его действие на мне, ссылаясь при этом на весьма " +
                "сомнительные книги. Клянусь памятью отца, в Галактике вымерли " +
                "двуногие, которые умеют осматривать больного собственными глазами" +
                " и лечить собственными руками. Нынешние лекари не могут даже пульс " +
                "сосчитать, не заглядывая в трактат древней знаменитости. Мне плохо, " +
                "а они заявляют: Природа заболевания неизвестна! Бестолочи! За " +
                "тысячи лет человеческое тело научилось болеть новыми, неизвестными " +
                "науке предков, способами, и современные врачи не могут помешать " +
                "ему болеть. Либо древние рано умерли, либо я поздно родился!";
        }

        //Выводит слова сообщения, которые содержат не более n букв
        static public void GetWordsByLength(int numChar)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '!', '\n', '\t' });
            //Console.WriteLine("Вывод слов, длинной не более " + len + ": " );
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= numChar)
                    Console.Write(word + " ");
            }
        }

        //Удаляет из сообщения все слова, которые заканчиваются на заданный символ
        static public void DeleteWordByEndChar(char symbol)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            //Console.WriteLine("Будут удалены слова, оканчивающиеся на символ '" + symbol + "': ");
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == symbol)
                {
                    Console.Write(word + " ");
                    text.Replace(word, "");
                }
            }
            //Console.WriteLine("В результате работы метода, исходный текст изменился на: " + text);
        }

        //Находит самое длинное слово сообщения
        static public string FindMaxLengthWord()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            //Console.WriteLine("Слово с самой большой длинной: " + maxWord);
            return maxWord;
        }

        //Формирует строку StringBuilder из самых длинных слов сообщения
        static public StringBuilder GetLongWordsString()
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder result = new StringBuilder();
            int max = Message.FindMaxLengthWord().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            //Console.WriteLine("Полученная строка самых длинных слов: " + result);
            return result;
        }

    }
}

