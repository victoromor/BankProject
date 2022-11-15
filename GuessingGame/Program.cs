using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
Random random = new();
bool playAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
string response;
while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min, max + 1);
    //Added every guess I made to a list of arrays
    var arlist1 = new ArrayList();
    while (guess != number)
    {
        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        //Get values from the users
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Guess: " + guess);
        arlist1.Add(guess);//the code below adds each guess to a list of arrays
                           //conditions for guessing
        if (guess > number)
        {
            Console.WriteLine(guess + " is too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is too low!");
        }
        guesses++;
    }
    //var n = arlist1.Count;
    //Console.Write("These are the numbers you guessed: ");
    //for (int i = 0; i < n; i++)
    //{
    //    var list = (arlist1[i] + ", ");
    //    string[] ar = { Convert.ToString(list) };
    //    Console.Write(ar[0].Length);
    //}
    //Console.Write(ar[0].Length);
    Console.WriteLine("The Correct Number is " + number);
    Console.WriteLine("You WIN!");
    Console.WriteLine("Number of Guesses: " + guesses);
    Console.WriteLine("Would you like to play again (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}
Console.WriteLine("Thanks for playing");
