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


        if (guess == secretNum)
        {
            Console.WriteLine("You guessed it!!!");
            guess = int.Parse(Console.ReadLine());
        }

        else if (guess < secretNum)
        {
            Console.WriteLine($"Your guess was too low. You have {guessLimit - i} guesses left. Try again!");
            guess = int.Parse(Console.ReadLine());
        }

        else if (guess > secretNum)
        {
            Console.WriteLine($"Your guess was too high. You have {guessLimit - i} guesses left. Try again!");
            guess = int.Parse(Console.ReadLine());
        }





    }
}



