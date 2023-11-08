using System;

namespace Triqui
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int currentPlayer = 1; // 1 representa al Jugador 1, 2 representa al Jugador 2
        static bool gameEnded = false;

        static void Main(string[] args)
        {
            while (!gameEnded)
            {
                DrawBoard();
                PlayTurn();
                CheckGameEnd();
                ChangePlayer();
            }
        }

        static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0], board[1], board[2]);
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[3], board[4], board[5]);
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[6], board[7], board[8]);
        }

        static void PlayTurn()
        {
            Console.WriteLine("Turno del Jugador {0}", currentPlayer);
            Console.Write("Selecciona un número de 1 a 9: ");
            int position = int.Parse(Console.ReadLine()) - 1;

            if (position < 0 || position > 8 || board[position] == 'X' || board[position] == 'O')
            {
                Console.WriteLine("Movimiento inválido. Inténtalo de nuevo.");
                PlayTurn();
            }
            else
            {
                board[position] = currentPlayer == 1 ? 'X' : 'O';
            }
        }

        static void CheckGameEnd()
        {
            if (board[0] == board[1] && board[1] == board[2] ||
                board[3] == board[4] && board[4] == board[5] ||
                board[6] == board[7] && board[7] == board[8] ||
                board[0] == board[3] && board[3] == board[6] ||
                board[1] == board[4] && board[4] == board[7] ||
                board[2] == board[5] && board[5] == board[8] ||
                board[0] == board[4] && board[4] == board[8] ||
                board[2] == board[4] && board[4] == board[6])
            {
                DrawBoard();
                Console.WriteLine("¡El Jugador {0} ha ganado!", currentPlayer);
                gameEnded = true;
            }
            else if (!Array.Exists(board, element => element != 'X' && element != 'O'))
            {
                DrawBoard();
                Console.WriteLine("El juego ha terminado en empate.");
                gameEnded = true;
            }
        }

        static void ChangePlayer()
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;
        }
    }
}
