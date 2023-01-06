using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneMinesweeperConsole
{
    class Board
    {
        public int Size { get; set; }
        public double bombNum { get; set; }
        public Cell[,] Grid { get; set; }

        public Board(int size, double bombs)
        {
            this.Size = size;
            this.bombNum = bombs;
            Cell[,] grid = new Cell[size, size];
            this.Grid = grid;
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Grid[r, c] = new Cell(r, c, false, false, -1);
                }

            }

        }
        
        public void setupLiveBombs()
        {
            Random rand = new Random();
            int isBomb = 0;
            int bombCount = 0;
            int range = (int)(bombNum * (Size*Size));
            while(bombCount<range)
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    isBomb = rand.Next(0, 100);
                    if(isBomb <= range && !(Grid[r,c].isBomb) && bombCount<range)
                    {
                        Grid[r, c] = new Cell(r, c, false, true, 0);
                        bombCount++;
                    }
                }

            }


        }
        public void calculateLiveNeighbors()
        {
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    //Checks if cell is a bomb
                    if (!(Grid[r, c].isBomb))
                    {
                        int count = 0;
                        //If not it checks to see if it is an edge piece
                        try
                        {
                            // upper left diagonal ajacent
                            if (Grid[r - 1, c - 1].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            // direct up
                            if (Grid[r - 1, c].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            // upper right diagonal ajacent
                            if (Grid[r - 1, c + 1].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            // direct left
                            if (Grid[r, c - 1].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            // direct right
                            if (Grid[r, c + 1].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            // bottom left diagonal ajacent
                            if (Grid[r + 1, c - 1].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            //direct bottom ajacent
                            if (Grid[r + 1, c].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            // bottom right diagonal ajacent
                            if (Grid[r + 1, c + 1].isBomb)
                            {
                                count++;
                            }
                        }
                        catch
                        {

                        }
                        Grid[r, c] = new Cell(r, c, false, false, count);
                    }
                   
                }

            }
        }
        public void floodFill(int row, int col)
        {
        
                Grid[row, col].isClicked = true;
                Console.WriteLine("Flood Fill is running");
                if (Grid[row, col].bombsAjacent == 0)
                {
                try { if (Grid[row + 1, col].isClicked == false) floodFill(row + 1, col); } catch { }
                try { if (Grid[row - 1, col].isClicked == false) floodFill(row - 1, col); } catch { }
                try { if (Grid[row, col + 1].isClicked == false) floodFill(row, col + 1); } catch { }
                try { if (Grid[row, col - 1].isClicked == false) floodFill(row, col - 1); } catch { }
                }
            
        }
    }
}
