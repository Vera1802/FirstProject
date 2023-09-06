namespace Algorithms;

using System; 

public enum Player
{
    X,
    O
}
public enum SquareState
{
    Empty, 
    X,     
    O      
}
public class TicTacToe
{
    private SquareState[,] board; 
    private Player currentPlayer; 

    public TicTacToe()
    {
        board = new SquareState[3, 3]; 
        currentPlayer = Player.X; 
    }

    
    public SquareState GetSquareState(int row, int col)
    {
        return board[row, col];
    }

    
    public void XPlay(int row, int col)
    {
        if (currentPlayer == Player.X && board[row, col] == SquareState.Empty)
        {
            board[row, col] = SquareState.X;
            currentPlayer = Player.O; 
        }
    }

    
    public void OPlay(int row, int col)
    {
        if (currentPlayer == Player.O && board[row, col] == SquareState.Empty)
        {
            board[row, col] = SquareState.O;
            currentPlayer = Player.X; 
        }
    }

    
    public Player GetCurrentPlayer()
    {
        return currentPlayer;
    }

    
    public bool IsGameOver(out Player winner)
    {
        
        winner = Player.X; 
        return false; 
    }
    public Player TheWinnerIs()
    {
        
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == SquareState.X && board[i, 1] == SquareState.X && board[i, 2] == SquareState.X)
                return Player.X; 
            if (board[i, 0] == SquareState.O && board[i, 1] == SquareState.O && board[i, 2] == SquareState.O)
                return Player.O; 
        }

        
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == SquareState.X && board[1, i] == SquareState.X && board[2, i] == SquareState.X)
                return Player.X; 
            if (board[0, i] == SquareState.O && board[1, i] == SquareState.O && board[2, i] == SquareState.O)
                return Player.O; 
        }

        
        if (board[0, 0] == SquareState.X && board[1, 1] == SquareState.X && board[2, 2] == SquareState.X ||
            board[0, 2] == SquareState.X && board[1, 1] == SquareState.X && board[2, 0] == SquareState.X)
            return Player.X; 

        if (board[0, 0] == SquareState.O && board[1, 1] == SquareState.O && board[2, 2] == SquareState.O ||
            board[0, 2] == SquareState.O && board[1, 1] == SquareState.O && board[2, 0] == SquareState.O)
            return Player.O; 
        return Player.X; 
    }

    // static void Main(string[] args)
    // {
    //     TicTacToe game = new TicTacToe();
    //     Player winner = Player.X; 

    //     while (winner == Player.X)
    //     {
    //         Console.Clear();
    //         Console.WriteLine("Joueur X, c'est votre tour.");
    //         PrintBoard(game);

            //int row, col;
            //GetMove(out row, out col);

            //game.XPlay(row, col);
//             winner = game.TheWinnerIs();
//         }

//         Console.Clear();
//         PrintBoard(game);
//         Console.WriteLine($"Le joueur {winner} a gagné !");
//     }

//     static void PrintBoard(TicTacToe game)
//     {
//         // Afficher le tableau de jeu ici
//     }

//     //static void GetMove(out int row, out int col)
    
}

