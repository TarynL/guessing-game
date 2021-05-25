using System;

string secretNum = "42";

question();

void question()
{
    Console.WriteLine("What is the secret number?");

    {
        string answer = Console.ReadLine();
        // while (answer != secretNum)

        for (int i = 0; i < 3; i++)
        {
            if (answer != secretNum)
            {
                Console.WriteLine("Try Again");
                answer = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("You guessed it!!!");

            }
        };


    };

}

