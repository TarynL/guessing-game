using System;

int secretNum = 42;

question();

void question()
{
    Console.WriteLine("What is the secret number?");
    int guess = int.Parse(Console.ReadLine());

    for (int i = 1; i < 4; i++)
    {
        if (guess != secretNum)
        {
            Console.WriteLine($"Guess #{i} Try Again");
            guess = int.Parse(Console.ReadLine());
        }

        else
        {
            Console.WriteLine("You guessed it!!!");

        }


    }
}



