string[] board = { "-", "-", "-",
                   "-", "-", "-",
                   "-", "-", "-"};


void printBoard()
{
    Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
    Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
    Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
}

void handleGameOver()
{
    for (int index = 0; index < board.Length; index++) { board[index] = "-"; }

    Console.Write("Do you want to play a new game? (y/n): ");
    string userAnswer = Console.ReadLine();

    while (userAnswer != "y" && userAnswer != "n")
    {
        Console.Write("Invalid answer! (y/n): ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "y")
    {
        printBoard();
        Game();
    }
    else if (userAnswer == "n")
    {
        Environment.Exit(1);
    }
}

bool areEqual(string val1, string val2, string val3)
{
    if (val1 == val2 && val2 == val3)
    {
        return true;
    }

    return false;
}

void checkGameOver(string player)
{
    if (((board[0] != "-" && board[3] != "-" && board[6] != "-") && areEqual(board[0], board[3], board[6])) ||
        ((board[1] != "-" && board[4] != "-" && board[7] != "-") && areEqual(board[1], board[4], board[7])) ||
        ((board[2] != "-" && board[5] != "-" && board[8] != "-") && areEqual(board[2], board[5], board[8])) ||

        ((board[0] != "-" && board[1] != "-" && board[2] != "-") && areEqual(board[0], board[1], board[2])) ||
        ((board[3] != "-" && board[4] != "-" && board[5] != "-") && areEqual(board[3], board[4], board[5])) ||
        ((board[6] != "-" && board[7] != "-" && board[8] != "-") && areEqual(board[6], board[7], board[8])) ||

        ((board[0] != "-" && board[4] != "-" && board[8] != "-") && areEqual(board[0], board[4], board[8])) ||
        ((board[2] != "-" && board[4] != "-" && board[6] != "-") && areEqual(board[2], board[4], board[6])))
    {
        Console.WriteLine($"({player}) Wins the game!");
        handleGameOver();
    }
    else if (!Array.Exists(board, element => element == "-"))
    {
        Console.WriteLine("Game Draw!");
        handleGameOver();
    }
}

void userTurn(string player)
{
    List<string> validChoices = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    Console.Write($"({player}) Choose a postition (1-9): ");
    var userChoice = Console.ReadLine();

    while (!validChoices.Contains(userChoice) || board[int.Parse(userChoice) - 1] != "-")
    {
        Console.Write($"({player}) Invalid choice! (1-9): ");
        userChoice = Console.ReadLine();
    }

    board[int.Parse(userChoice) - 1] = player;
    printBoard();
    checkGameOver(player);
}


printBoard();

void Game()
{
    while (true)
    {
        userTurn("X");
        userTurn("O");
    }
}

Game();
