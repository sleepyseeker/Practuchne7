using System;
using System.Linq;

public class Program
{
    public static string ReverseWords(string sentence)
    {
        string sentenceWithReversedWords = String.Empty, currentWord = String.Empty;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (!Char.IsLetter(sentence[i]))
            {
                if (!String.IsNullOrEmpty(currentWord))
                {
                    sentenceWithReversedWords += new string(currentWord.Reverse().ToArray());
                    currentWord = String.Empty;
                }
                sentenceWithReversedWords += sentence[i];
            }
            else
            {
                currentWord += sentence[i];
            }
        }
        if (!String.IsNullOrEmpty(currentWord))
            sentenceWithReversedWords += new string(currentWord.Reverse().ToArray());

        return sentenceWithReversedWords;
    }

    public static void Main()
    {
        string sentence1 = String.Empty, sentence2 = String.Empty, sentence3 = String.Empty;

        Console.WriteLine("Увед1ть першу пропозиц1ю: ");
        sentence1 = Console.ReadLine();
        Console.WriteLine("Увед1ть другу пропозиц1ю: ");
        sentence2 = Console.ReadLine();
        Console.WriteLine("Увед1ть третю пропозиц1ю: ");
        sentence3 = Console.ReadLine();

        Console.WriteLine($"Зм1нена перша пропозиц1я: {ReverseWords(sentence1)}");
        Console.WriteLine($"Зм1нена друга пропозиц1я: {ReverseWords(sentence2)}");
        Console.WriteLine($"Зм1нена третя пропозиц1я: {ReverseWords(sentence3)}");

        Console.ReadKey();
    }
}