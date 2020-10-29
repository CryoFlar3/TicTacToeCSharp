using System;

namespace TicTacToe {
    class Program {
        static void Main(string[] args) {
            Game game = new Game();
            Prompter player1 = new Prompter("Player 1", 'X', game);
            Prompter player2 = new Prompter("Player 2", 'O', game);
            Console.WriteLine("Hello World!");

            while (!game.IsWon()) {
                
                player1.PromptForGuess();
                if (game.IsWon())
                    break;
                player2.PromptForGuess();
            }
        }
    }
}
