using System;



question();


void question()
{
    int secretNum = new Random().Next(0, 100);
    int guessLimit = 0;
    int difficultyLevel = 0;
    int easy = 1;
    int medium = 2;
    int hard = 3;


    while (difficultyLevel == 0)
    {
        Console.WriteLine("What difficulty level would you like?");
        Console.WriteLine($"{easy} {medium} {hard}");

        difficultyLevel = int.Parse(Console.ReadLine());
        if (difficultyLevel == easy)
        {
            guessLimit = 8;

        }
        else if (difficultyLevel == medium)
        {
            guessLimit = 6;

        }
        else if (difficultyLevel == hard)
        {
            guessLimit = 4;

        }
        else
        {
            Console.WriteLine("Please enter a valid selection.");
        }


    }

    for (int i = 1; i < guessLimit; i++)
    {

        Console.WriteLine("What is the secret number?");
        int guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("You guessed it!!!");

        }

        else if (guess < secretNum)
        {
            Console.WriteLine($"Your guess was too low. You have {guessLimit - i} guesses left. Try again!");

        }

        else if (guess > secretNum)
        {
            Console.WriteLine($"Your guess was too high. You have {guessLimit - i} guesses left. Try again!");

        }

    }
}





