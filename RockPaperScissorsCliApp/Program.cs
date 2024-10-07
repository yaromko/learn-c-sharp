using System;

namespace LearnCSharp.RockPaperScissorsCliApp;

class RockPaperScissorsCliApp
{
    static int playerWins = 0;
    static int computerWins = 0;
    static bool gameStarted = false;


    static void Main(string[] args)
    {
        bool playGame = true;

        while (playGame)
        {
            Console.WriteLine("Welcome to rock, paper sciccors, lizard,spock as feautured in Big bang theory!!");
            Console.WriteLine("Main menu");
            Console.WriteLine("Option 1: Start a new game");
            Console.WriteLine("Option 2: Computer Choose!");
            Console.WriteLine("Option 3: Player Choose!");
            Console.WriteLine("Option 4: Unveil the Winner!!(OF the new office space)");
            Console.WriteLine("Option 5: Show the official score!");
            Console.WriteLine("Option 6: Exit the session ;( ");
            Console.WriteLine("Select an option");

            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {


                case "1":
                    StartNewGame();
                    break;

                case "2":
                    if (gameStarted)
                    {
                        ComputerGo();
                    }

                    else
                    {
                        Console.WriteLine("Please start a new game first.");
                    }
                    break;

                case "3":
                    if (gameStarted)

                    {
                        UserGo();
                    }
                    else

                    {
                        Console.WriteLine("Please start a new game first");

                    }

                    break;

                case "4": DisplayWinner(); break;
                case "5": DisplayScores(); break;
                case "6": playGame = false; break;
                default: Console.WriteLine("Please Select a valid option"); break;


            }
        }


        Console.WriteLine("Thank you for beta testing!!");



    }



    static int computerChoice = 0;
    static int userChoice = 0;

    static void StartNewGame()
    {
        gameStarted = true;
        Console.WriteLine("A new game has started! Current scores will be kept");
    }

    static void ComputerGo()
    {
        Random rnd = new Random();
        computerChoice = rnd.Next(1, 6);
        Console.WriteLine("Computer has selected their fighter!");
    }

    static void UserGo()
    {
        Console.WriteLine("Its your choice now, choose your contender 1.Rock 2.Paper 3.Scissors 4.Lizard 5.Spock ");
        string userInput = Console.ReadLine();

        while (!int.TryParse(userInput, out userChoice) || userChoice < 1 || userChoice > 5)
        {
            Console.WriteLine("Option is not valid :(");

            userInput = Console.ReadLine();
        }

        Console.WriteLine($"You chose {GetMoveName(userChoice)}!");

    }

    static void DisplayWinner()
    {
        if (!gameStarted)
        {
            Console.WriteLine("Please start a new game first");
            return;
        }

        if (userChoice == 0 || computerChoice == 0)
        {
            Console.WriteLine("The computer and player must pick a choice before unveiling the winner ");
            return;
        }


        Console.WriteLine($"You chose {GetMoveName(userChoice)}");
        Console.WriteLine($"The computer chose {GetMoveName(computerChoice)}");


        string result = DetermineWinner(userChoice, computerChoice);
        Console.WriteLine(result);


        userChoice = 0;
        computerChoice = 0;
    }
    static string GetMoveName(int choice)
    {

        switch (choice)
        {
            case 1: return "Rock";
            case 2: return "Paper";
            case 3: return "Scissors";
            case 4: return "Lizard";
            case 5: return "Spock";
            default: return "Invalid";
        }
    }

    static string DetermineWinner(int userChoice, int computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return "It's a tieeeee!";
        }


        //1=Rock
        //2=Paper
        //3=Scissors
        //4=Lizard
        //5=Spock

        if ((userChoice == 1 && (computerChoice == 3 || computerChoice == 4)) ||
            (userChoice == 2 && (computerChoice == 1 || computerChoice == 5)) ||
            (userChoice == 3 && (computerChoice == 2 || computerChoice == 4)) ||
            (userChoice == 4 && (computerChoice == 2 || computerChoice == 5)) ||
            (userChoice == 5 && (computerChoice == 1 || computerChoice == 3)))




        //     Rock crushes Scissors(1 beats 3)
        //     Rock crushes Lizard(1 beats 4)
        //    Paper covers Rock(2 beats 1)
        //     Paper disproves Spock(2 beats 5)
        //    Scissors cuts Paper(3 beats 2)
        //    Scissors decapitates Lizard(3 beats 4)
        //    Lizard eats Paper(4 beats 2)
        //    Lizard poisons Spock(4 beats 5)
        //    Spock smashes Scissors(5 beats 3)
        //    Spock vaporizes Rock(5 beats 1)

        {
            playerWins++;
            return "You win!";
        }
        else
        {
            computerWins++;
            return "Computer wins!";
        }
    }


    static void DisplayScores()
    {

        Console.WriteLine($"Current Scores: User wins = {playerWins}, Computer wins = {computerWins}");
        if (playerWins > computerWins)
        {
            Console.WriteLine("You are the overall winner so far!");
        }
        else if (computerWins > playerWins)

            Console.WriteLine("The computer is the overall winner so far!");

        else
        {
            Console.WriteLine("The overall score is tied!");
        }

    }
}
