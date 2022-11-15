using System;
namespace ToPigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to convert to PigLatin:");
            string? sentence = Console.ReadLine();
            string? pigLatin = ToPigLatin(sentence);
            string? english = ToEnglishn(pigLatin);
            Console.WriteLine(pigLatin);
            Console.WriteLine(english);
        }
        //change pig latin to english
        public static string ToPigLatin(string sentence)
        {
            List<string> newWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);//isolate the first letter
                string restOfWord = word.Substring(1, word.Length - 1);//the rest of the word
                newWords.Add(restOfWord + firstLetter + "ay");//append the new formed words
            }
            return string.Join(" ", newWords);
        }
        //Change back the pig latin to english
        public static string ToEnglishn(string pigLatin)
        {
            List<string> newWords = new List<string>();
            foreach (string word in pigLatin.Split(' '))
            {
                //length of each word
                string lastTwoLetter = word.Substring(0, word.Length - 2); // remove the last two letters ay
                string restOfWord = lastTwoLetter.Substring(0, lastTwoLetter.Length - 1); //remove the last letter after removing ay
                string lastletter = lastTwoLetter.Substring(lastTwoLetter.Length - 1);// isolate the last letter
                newWords.Add(lastletter + restOfWord);//append the last letter to the front
            }
            return string.Join(" ", newWords);
        }
    }
}