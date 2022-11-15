using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace NumbersTranslation
{
    class Program
    {
        static void Main(string[] args)
        {
            string isNegative = "";
            try
            {
                Console.WriteLine("Enter a Number to convert to currency");
                string? number = Console.ReadLine();
                number = Convert.ToDouble(number).ToString();

                if (number.Contains('-'))
                {
                    isNegative = "Minus ";
                    number = number[1..];
                }
                if (number == "0")
                {
                    Console.WriteLine("The number you entered is \nZero Only");
                }
                else
                {
                    Console.WriteLine("The number you entered is \n{0}", isNegative + NumbersToWords.ConvertToWords(number));
                    string newWord = Convert.ToString(NumbersToWords.ConvertToWords(number));
                    Console.WriteLine("Press Enter to convert back to numbers!");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                string numberInWords = "Three hundred Thousand Five Hundred Sixty Two"; //NumbersToWords.ConvertToWords(number);
                string returnnNumber = Convert.ToString(WordsToNumbers.ConvertToNumbers(numberInWords));

                Console.WriteLine("Number is {0}", returnnNumber);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
