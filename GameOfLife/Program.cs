using System;

namespace GameOfLife
{
    class Program
    {
        //Rules
        //For a space that is populated:
        //    Each cell with one or no neighbors dies, as if by solitude.
        //    Each cell with four or more neighbors dies, as if by overpopulation.
        //    Each cell with two or three neighbors survives.
        //For a space that is empty or unpopulated:
        //    Each cell with three neighbors becomes populated.
        const int HEIGHT = 10;
        const int WIDTH = 10;

        static void Main(string[] args)
        {

            Board board = SetInitialStatus();
            Console.WriteLine("Initial Step");
            Console.WriteLine(board.ToString());

            GameEngine game = new GameEngine();

            board = game.NextStep(board);

            Console.WriteLine("Final Step");
            Console.WriteLine(board.ToString());

            Console.WriteLine("Expected Status");
            Console.WriteLine(SetExpectedStatus().ToString());

        }

        private static Board SetInitialStatus()
        {
            Board board = new Board(HEIGHT, WIDTH);
            /*board.SetAlive(3, 4);
            board.SetAlive(4, 4);
            board.SetAlive(5, 4);*/
            return board;
        }

        private static Board SetExpectedStatus()
        {
            Board board = new Board(HEIGHT, WIDTH);
            /*board.SetAlive(4, 3);
            board.SetAlive(4, 4);
            board.SetAlive(4, 5);*/
            return board;
        }
    }
}
