using System;

Console.WriteLine("-------------------------");
Console.WriteLine("| Player:  | Computer:  |");
Console.WriteLine("-------------------------");

Console.WriteLine("What would you like to throw?");
Console.WriteLine("1) Rock");
Console.WriteLine("2) Paper");
Console.WriteLine("3) Scissors");

string userThrowToConvert = Console.ReadLine();
int userThrow = Convert.ToInt32(userThrowToConvert);
int compThrow = new Random().Next(1, 3);

userThrows();

void userThrows()
{
    if (userThrow == 1)
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
    else if (userThrow == 2)
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
    else if (userThrow == 3)
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