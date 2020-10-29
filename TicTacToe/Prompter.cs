using System;

namespace TicTacToe {
    class Prompter {
        private string player;
        private char symbol;
        private char[] spaces;
        private Game game;
        public Prompter(string player, char symbol, Game game) {
            this.player = player;
            this.symbol = symbol;
            this.game = game;
        }

        public void PromptForGuess() {
            DisplayBoard();
            int position;
            Console.Write($"{player}, what space would you like to use? ");
            bool isAccepted = false;
            do {
                try {                    
                    position = int.Parse(Console.ReadLine()) - 1;
                    game.CheckInput(player, symbol, position);
                    isAccepted = true;
                } catch (ArgumentException e) {
                    Console.WriteLine($"{e.Message}. Please try again.");
                } catch (FormatException e) {
                    Console.WriteLine($"{e.Message} Please try again.");
                } catch (IndexOutOfRangeException e) {
                    Console.WriteLine("That posistion is not selectable. Please try again.");
                }
            } while (!isAccepted);
        }

        public void DisplayBoard() {

            spaces = game.GetSpaces();

            Console.WriteLine("\n" +
                $"| {spaces[0]} | {spaces[1]} | {spaces[2]} |\n--------------\n" +
                $"| {spaces[3]} | {spaces[4]} | {spaces[5]} |\n--------------\n" +
                $"| {spaces[6]} | {spaces[7]} | {spaces[8]} |\n");
        }
    }
}
