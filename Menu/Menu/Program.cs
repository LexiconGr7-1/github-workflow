using static System.Console;

bool alive = true;
while (alive)
{
    WriteLine("A little menu");
    WriteLine("[1] Hello World!" +
            "\n[Q] Quit");

    ConsoleKeyInfo input = Console.ReadKey(true);
    switch (input.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("\nHello World!\n");
            ResetColor();

            break;
        case ConsoleKey.Q:
            WriteLine("Bye :(");
            alive = false;
            break;
    }
}