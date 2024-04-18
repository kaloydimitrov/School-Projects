using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

string[,] map1 =
{
    { "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# " },
    { "# ", ". ", ". ", "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", "@ ", "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", "# ", ". ", "B ", ". ", ". ", ". ", "B ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", "^ ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", "# ", "# ", "# ", ". ", "B ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "_ ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# " },
};

string[,] map2 =
{
    { "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", "@ ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", "$ ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "$ ", "_ ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "O ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", "$ ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "B ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "B ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", "O ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "B ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "B ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", "# " },
    { "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# ", "# " },
};

string[,] map = { { } };
int coinsCount = 0;

Console.Write("Choose map (1, 2): ");
string userChoice = Console.ReadLine();

while (userChoice != "1" && userChoice != "2")
{
    Console.Write("Invalid choice! (1, 2): ");
    userChoice = Console.ReadLine();
}

if (userChoice == "1")
{
    map = map1;
}
else if (userChoice == "2")
{
    map = map2;
}

int[] position = { 2, 2 };


void drawMap()
{
    Console.Clear();
    for (int x = 0; x < map.GetLength(0); x++)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            Console.Write(map[x, y]);
        }
        Console.WriteLine();
    }
}

int[] getNewPositions(string key, int current_row, int current_col)
{
    int next_row = 0; int next_col = 0;

    if (key == "W")
    {
        next_row = current_row - 1; next_col = current_col;
    }
    else if (key == "A")
    {
        next_row = current_row; next_col = current_col - 1;
    }
    else if (key == "S")
    {
        next_row = current_row + 1; next_col = current_col;
    }
    else if (key == "D")
    {
        next_row = current_row; next_col = current_col + 1;
    }

    int[] row_and_col = { next_row, next_col };
    return row_and_col;
}

void handleTurn(string key)
{
    int current_row = position[0]; int current_col = position[1];
    int[] new_positions = getNewPositions(key, current_row, current_col);
    int next_row = new_positions[0]; int next_col = new_positions[1];

    if (map[next_row, next_col] == ". ")
    {
        map[next_row, next_col] = "@ ";
        map[current_row, current_col] = ". ";
        position[0] = next_row; position[1] = next_col;
    }
    else if (map[next_row, next_col] == "_ ")
    {
        map[next_row, next_col] = "@ ";
        map[current_row, current_col] = ". ";
        position[0] = next_row; position[1] = next_col;
        handleWin();
    }
    else if (map[next_row, next_col] == "^ ")
    {
        map[next_row, next_col] = "X ";
        map[current_row, current_col] = ". ";
        position[0] = next_row; position[1] = next_col;
        handleLose();
    }
    else if (map[next_row, next_col] == "$ ")
    {
        map[next_row, next_col] = "@ ";
        map[current_row, current_col] = ". ";
        coinsCount += 1;
        drawMap();
        map[next_row, next_col] = ". ";
        position[0] = next_row; position[1] = next_col;
    }
    else if (map[next_row, next_col] == "O ")
    {
        int[] firstOPositions = { 0, 0 };
        firstOPositions[0] = next_row; firstOPositions[1] = next_col;

        int[] secondOPositions = { 0, 0 };

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                if (map[x, y] == "O ")
                {
                    int[] currentOPositions = { x, y };

                    if (currentOPositions != firstOPositions)
                    {
                        secondOPositions[0] = x; secondOPositions[1] = y;
                        Console.WriteLine($"{x}, {y}");
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }
    else if (map[next_row, next_col] == "B ")
    {
        bool canHappen = false;
        int next_b_row = next_row; int next_b_col = next_col;

        while (true)
        {
            int[] new_b_positions = getNewPositions(key, next_b_row, next_b_col);
            next_b_row = new_b_positions[0]; next_b_col = new_b_positions[1];

            if (map[next_b_row, next_b_col] == "# " || map[next_b_row, next_b_col] == "_ " || map[next_b_row, next_b_col] == "^ ")
            {
                break;
            }
            else if (map[next_b_row, next_b_col] == ". ")
            {
                canHappen = true;
                map[next_b_row, next_b_col] = "B ";
                break;
            }
        }

        if (canHappen)
        {
            map[next_row, next_col] = "@ ";
            map[current_row, current_col] = ". ";
            position[0] = next_row; position[1] = next_col;
        }
    }
}

void handleWin()
{
    drawMap();
    Console.Write($"You Win! You picked up {coinsCount} coins!");
    Environment.Exit(0);
}

void handleLose()
{
    drawMap();
    Console.Write($"You Lost! You picked up {coinsCount} coins!");
    Environment.Exit(0);
}

while (true)
{
    map[position[0], position[1]] = "@ ";
    drawMap();

    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.Escape:
            return;

        case ConsoleKey.W:
            handleTurn("W");
            break;

        case ConsoleKey.A:
            handleTurn("A");
            break;

        case ConsoleKey.S:
            handleTurn("S");
            break;

        case ConsoleKey.D:
            handleTurn("D");
            break;

        default:
            break;
    }
}
