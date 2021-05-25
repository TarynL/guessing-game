using System;

string secretNum = "42";

question();

void question()
{
    Console.WriteLine("What is the secret number?");
    string answer = Console.ReadLine();
    if (secretNum == answer)
    {
        Console.WriteLine("You guessed it!!!");
    }
    else
    {
        Console.WriteLine("Not even close.");
    }
}

