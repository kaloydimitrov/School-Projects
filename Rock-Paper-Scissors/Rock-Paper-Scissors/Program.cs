List<string> choices = new List<string>() { "rock", "paper", "scissors" };


while (true)
{
    Console.WriteLine("\n----------------- New Game -----------------\n");

    Console.Write("Enter 'rock', 'paper' or 'scissors': ");
    string userChoice = Console.ReadLine();

    // Validates user choice
    while (!choices.Contains(userChoice))
    {
        Console.WriteLine("Invalid input!");
        userChoice = Console.ReadLine();
    }

    // Creates random computer choice
    Random random = new Random();
    int randomIndex = random.Next(choices.Count);
    string computerChoice = choices[randomIndex];

    Console.Write("Computer choose: ");
    Console.WriteLine(computerChoice);


    // Checks the winner
    if (computerChoice == userChoice)
    {
        Console.WriteLine("Game Draw!");
    }
    else if ((computerChoice == "rock" && userChoice == "scissors") ||
             (computerChoice == "scissors" && userChoice == "paper") ||
             (computerChoice == "paper" && userChoice == "rock"))
    {
        Console.WriteLine("You Lose!");
    }
    else
    {
        Console.WriteLine("You Win!");
    }

    // Asks for new game
    Console.Write("Do you want to play a new game? (y/n): ");

    string userAnswer = Console.ReadLine();

    // Validates user answer
    while (userAnswer != "y" && userAnswer != "n")
    {
        Console.WriteLine("Invalid answer!");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "n")
    {
        break;
    }
}
