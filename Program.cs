using System;



question();

void question()
{
    Console.WriteLine("What is the secret number?");
    int guess = int.Parse(Console.ReadLine());
    Random r = new Random();
    int secretNum = r.Next(0, 100);
    int guessLimit = 4;

    for (int i = 1; i < 4; i++)
    {
        if (guess != secretNum)
        {
            Console.WriteLine($"You have {guessLimit - i} guesses left. Try Again");
            guess = int.Parse(Console.ReadLine());
        }

        else
        {
            Console.WriteLine("You guessed it!!!");

        }


    }
}



