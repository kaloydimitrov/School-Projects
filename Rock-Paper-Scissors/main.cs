List<string> choices = new List<string>();
choices.Add("rock");
choices.Add("paper");
choices.Add("scissors");


string userChoice;

while (true) {
    Console.WriteLine("----------------- New Game -----------------");

    while (true)
    {
        Console.WriteLine("Enter rock, paper or scissors: ");
        userChoice = Console.ReadLine();

        if (choices.Contains(userChoice))
        {
            break;
        }

        Console.WriteLine("Invalid input!");
    }


    Random random = new Random();
    int randomIndex = random.Next(choices.Count);

    Console.WriteLine("Computer choose: ");
    string computerChoice = choices[randomIndex];
    Console.WriteLine(computerChoice);

    if (computerChoice == userChoice) {
        Console.WriteLine("Game Draw!");
    }
    else if (computerChoice == "rock" && userChoice == "scissors") {
        Console.WriteLine("You Lose!");
    }
    else if (computerChoice == "scissors" && userChoice == "paper") {
        Console.WriteLine("You Lose!");
    }
    else if (computerChoice == "paper" && userChoice == "rock") {
        Console.WriteLine("You Lose!");
    }
    else {
        Console.WriteLine("You Win!");
    }


    Console.WriteLine("Do you want to play a new game (y/n): ");
    string newGame = Console.ReadLine();

    if (newGame == "n") {
        break;
    }
}
