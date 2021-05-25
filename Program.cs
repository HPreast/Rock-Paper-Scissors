using System;

int userScore = 0;
int compScore = 0;

game();
void game()
{
    if (userScore == 3)
    {
        Console.WriteLine("You win!");
    }
    else if (compScore == 3)
    {
        Console.WriteLine("You lose! :(");
    }
    else
    {

        Console.WriteLine("-------------------------");
        Console.WriteLine($"| Player: {userScore} | Computer: {compScore} |");
        Console.WriteLine("-------------------------");

        Console.WriteLine("What would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");

        string choice = Console.ReadLine();
        int userThrow = Convert.ToInt32(choice);
        int compThrow = new Random().Next(1, 3);


        throws(userThrow);
        Console.WriteLine("VS");
        throws(compThrow);

        if (userThrow == compThrow)
        {
            game();
        }
        else if (userThrow == 1)
        {
            if (compThrow == 2)
            {
                compScore++;
                game();
            }
            else
            {
                userScore++;
                game();
            }
        }
        else if (userThrow == 2)
        {
            if (compThrow == 3)
            {
                compScore++;
                game();
            }
            else
            {
                userScore++;
                game();
            }
        }
        else if (userThrow == 3)
        {
            if (compThrow == 1)
            {
                compScore++;
                game();
            }
            else
            {
                userScore++;
                game();
            }
        }
    }
}




void throws(int choice)
{
    if (choice == 1)
    {
        Console.WriteLine(@"""
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
""");
    }
    else if (choice == 2)
    {
        Console.WriteLine(@"""
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
""");
    }
    else if (choice == 3)
    {
        Console.WriteLine(@"""
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
""");
    }
}