using System;

namespace TicTacToe {
    class Game {
        private char[] spaces = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private int  count = 0;
        private string player;
        private char symbol;

        public Game() {
            player = "";

        }

        public char[] GetSpaces() {
            return spaces;
        }

        public void CheckInput(string p, char s, int pos) {
            player = p;
            symbol = s;
            if (spaces[pos] == 'X' || spaces[pos] == 'O') {
                throw new ArgumentException("Space taken");
            } else {
                spaces[pos] = s;
                count++;
            }
        }

        public bool IsWon() {
            if (count >= 9) {
                Console.WriteLine("Tie!");
                return true;
            } else if (spaces[0] == symbol && spaces[1] == symbol && spaces[2] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else if (spaces[3] == symbol && spaces[4] == symbol && spaces[5] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else if (spaces[6] == symbol && spaces[7] == symbol && spaces[8] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else if (spaces[0] == symbol && spaces[3] == symbol && spaces[6] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else if (spaces[1] == symbol && spaces[4] == symbol && spaces[7] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else if (spaces[2] == symbol && spaces[5] == symbol && spaces[8] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else if (spaces[0] == symbol && spaces[4] == symbol && spaces[8] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else if (spaces[2] == symbol && spaces[4] == symbol && spaces[6] == symbol) {
                Console.WriteLine($"{player} wins!");
                return true;
            } else {
                return false;
            }
        }
    }
}
