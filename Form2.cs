using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneMinesweeperConsole
{
    public partial class Form2 : Form
    {

        Button[,] buttonGrid = new Button[8, 8];
        Board gameBoard = new Board(8, 0);
        public static Stopwatch watch = new Stopwatch();
        int score = 6000;


        public Form2(double difficulty)
        {
            InitializeComponent();
            
            populateGrid();
            gameBoard.bombNum = difficulty;
            gameBoard.setupLiveBombs();
            gameBoard.calculateLiveNeighbors();
            watch.Start();
        }
        public void populateGrid()
        {
            int buttonSize = grpbx_minesweeper.Width / 8;
            grpbx_minesweeper.Height = grpbx_minesweeper.Width;


            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Button newBtn = new Button();

                    newBtn.Width = buttonSize;
                    newBtn.Height = buttonSize;
                    buttonGrid[r, c] = newBtn;
                    newBtn.MouseUp += Grid_Button_MouseUp;

                    grpbx_minesweeper.Controls.Add(newBtn);
                    newBtn.Location = new Point(buttonSize * r, buttonSize * c);

                    newBtn.Text = c+" "+r;

                    newBtn.Tag = c+" "+r;
                }
            }
        }
      
        private void Grid_Button_MouseUp(object sender, MouseEventArgs e)
        {
          


            // goes through each button in the button grid
            foreach (Button b in buttonGrid)
            {



                // finds the button with the same text value, and therefore row and column value
                if (b.Text == (sender as Button).Text)
                {
                    try
                    {

                        string[] rowAndColumn = b.Text.Split(' ');


                        int c = int.Parse(rowAndColumn[0]);
                        int r = int.Parse(rowAndColumn[1]);

                        //right click event handler
                        if (e.Button == MouseButtons.Right)
                        {
                           
                                buttonGrid[r, c].Text = "FLAG";
                           
                        }
                        else
                        {
                        //check if button is a bomb
                        if (gameBoard.Grid[r, c].isBomb)
                        {
                            for (int row = 0; row < 8; row++)
                            {
                                for (int col = 0; col < 8; col++)
                                {
                                    gameBoard.Grid[row, col].isClicked = true;
                                }
                            }
                            updateBoard();

                            MessageBox.Show("You clicked a bomb, you lose");
                            watch.Reset();
                            break;
                        }
                        //check for flood fill capability
                        else if (gameBoard.Grid[r, c].bombsAjacent == 0)
                        {
                            gameBoard.floodFill(r, c);
                        }
                        //otherwise only make button show value
                        else
                        {
                            gameBoard.Grid[r, c].isClicked = true;
                        }
                        }

                    }
                    catch
                    {
                    }

                }
            }
            updateBoard();

        }

        private void updateBoard()
        {
            int clickCounter = 0;

            //Iterate through each array to check for the value and change the button to the cell value that is clicked
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c<8; c++)
                {
                   
                    if (gameBoard.Grid[r, c].isClicked)
                    {
                        if (gameBoard.Grid[r, c].isBomb)
                        {
                            clickCounter++;

                            buttonGrid[r, c].Text = "BOMB";
                        }
                        else
                        {
                            clickCounter++;
                            
                            if (gameBoard.Grid[r,c].bombsAjacent == 0)
                            {
                                buttonGrid[r, c].Text = " ";

                            }
                            else
                            {
                                buttonGrid[r, c].Text = gameBoard.Grid[r, c].bombsAjacent.ToString();
                            }
                          

                        }
                    }
                }
            }
            // check for win condition
            int numOfBombs = (int)(gameBoard.bombNum * 64);
            
            if (clickCounter == 64 - numOfBombs)
            {
                MessageBox.Show("You win! Score: "+(score*gameBoard.bombNum*10).ToString());
                string filePath = @"C:\demos\highScores.txt";

                List<string> scores = File.ReadAllLines(filePath).ToList();

                scores.Add((score * gameBoard.bombNum * 10).ToString());

                File.WriteAllLines(filePath, scores);
                watch.Reset();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = watch.Elapsed.ToString();
            score -= 10;
        }
    }
}
