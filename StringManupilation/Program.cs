using System;
using System.Linq;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("Количество знаков препинания в тексте: " + text.Count(char.IsPunctuation));

            string[] words = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            IsWordSearch(text);
        }
        private static void IsWordSearch(string text)
        {
            string[] splitText = text.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLenght = 0, index = 0;
            for (int i = 0; i < splitText.Length; i++)
            {
                if (splitText[i].Length > maxLenght)
                {
                    maxLenght = splitText[i].Length;
                    index = i;
                }
            }
            string longWord = splitText[index];

            IsLongWord(maxLenght, longWord);
        }
        private static void IsLongWord(int maxLenght, string longWord)
        {
            if (maxLenght % 2 == 1)
            {
                char[] longWordAsChars = longWord.ToCharArray();
                longWordAsChars[longWord.Length / 2] = '*';
                string updatedLongWord = new string(longWordAsChars);

                Console.WriteLine("Самое длинное слово нечётное \"{0}\", его изменнённая версия \"{1}\" ", longWord, updatedLongWord);
            }
            else
            {
                string updatedLongWord = longWord.Substring(longWord.Length / 2);

                Console.WriteLine("Самое длинное слово чётное \"{0}\", его изменнённая версия \"{1}\" ", longWord, updatedLongWord);
            }
        }
    }
}
