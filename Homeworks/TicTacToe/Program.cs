namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        char[,] gameBoard = new char[3, 3];
        PrintGameIndexBoard(gameBoard);
        PrintGameBoard(gameBoard);
        while (true)
        {
            RunX(gameBoard);
            if (BoardCheck(gameBoard)) break; 
            if (MoveCheck(gameBoard)) break;

            RunO(gameBoard);
            if (BoardCheck(gameBoard)) break;
            if (MoveCheck(gameBoard)) break;
        }	
    }
    public static void PrintGameBoard(char[,] gameBoard)
    {
        Console.Clear();
        for (int i = 0; i < gameBoard.GetLength(0); i++)
        {
            if (i == 0) Console.WriteLine("┌───┬───┬───┐");
            else Console.WriteLine("├───┼───┼───┤");

            for (int j = 0; j < gameBoard.GetLength(1); j++)
            {
                Console.Write("│"); 

                if (gameBoard[i, j] == 'X')
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (gameBoard[i, j] == 'O')
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            
                Console.Write($" {gameBoard[i, j]} ");
            
                Console.ResetColor();
            }
        
            Console.WriteLine("│");
        }
        Console.WriteLine("└───┴───┴───┘"); 
    }
    private static void PrintGameIndexBoard(char[,] gameBoard)
    {
        int count = 0;
        for (int i = 0; i < gameBoard.GetLength(0); i++)
        {
            for (int j = 0; j < gameBoard.GetLength(1); j++)
            {
                if (gameBoard[i, j] == 0)
                {
                    count++;
                    gameBoard[i, j] = (char)('0' + count);;
                }
            }
        }
    }
    public static void RunX(char[,] gameBoard)
    {
        bool isMove = false;
        while (!isMove)
        {
            Console.Write("Ход X: ");
            if (int.TryParse(Console.ReadLine(), out int ch) && ch <= 9 && ch >= 1)
            {
                int row = (ch - 1) / 3;
                int col = (ch - 1) % 3;

                if (gameBoard[row, col] == 'O' || gameBoard[row, col] == 'X')
                {
                    Console.WriteLine("Поле занято! Попробуйте еще раз.");
                }
                else
                {
                    gameBoard[row, col] = 'X';
                    isMove = true;
                    PrintGameBoard(gameBoard);
                }
            }
        }
    }
    public static void RunO(char[,] gameBoard)
    {
        bool isMove = false;
        while (!isMove)
        {
            Console.Write("Ход O: ");
            if (int.TryParse(Console.ReadLine(), out int ch) && ch <= 9 && ch >= 1)
            {
                int row = (ch - 1) / 3;
                int col = (ch - 1) % 3;

                if (gameBoard[row, col] == 'O' || gameBoard[row, col] == 'X')
                {
                    Console.WriteLine("Поле занято! Попробуйте еще раз.");
                }
                else
                {
                    gameBoard[row, col] = 'O';
                    isMove = true;
                    PrintGameBoard(gameBoard);
                }
            }
        }
    }
    public static bool BoardCheck(char[,] gameBoard)
    {
        for (int i = 0; i < 3; i++)
        {
            if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
            {
                char winner = gameBoard[i, 0];
                Console.WriteLine($"Игра окончена. Победил: {winner} ");
                return true;
            }

            if (gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i])
            {
                char winner = gameBoard[0, i];
                Console.WriteLine($"Игра окончена. Победил: {winner} ");           
                return true;
            }
        }

        if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2] ||
            gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0])
        {
            char winner = gameBoard[1, 1];
            Console.WriteLine($"Игра окончена. Победил: {winner} ");           
            return true;
        }
        return false;
    }
    public static bool MoveCheck(char[,] gameBoard)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (char.IsDigit(gameBoard[i, j]))
                {
                    return false;
                }
            }
        }
        Console.WriteLine("Ничья!");
        return true;
    }
}