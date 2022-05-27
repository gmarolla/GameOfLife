using System;

namespace GameOfLife
{
    public class Board
    {
        private bool[,] board;
        public int Heigth{ get; }
        public int Width{ get; }


        public Board(int Heigth, int Width)
        {
            board = new bool[Heigth, Width];
            this.Heigth = Heigth;
            this.Width = Width;
        }

        public string ToString()
        {
            string print = null;
            for( int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    print += board[i, j] ? "1 " : "0 ";
                }
                print += "\n";
            }

            return print;
        }

        public void SetAlive(int x, int y)
        {
            board[x, y] = true;
        }

        public void SetDeath(int x, int y)
        {
            board[x, y] = false;
        }

    }
}