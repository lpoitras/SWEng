using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab6
{
    class GameEngine
    {
        int row;
        int col;
        int count = 0;
        Form1.CellSelection[,] grid;
        int rcount1 = 0;
        int xCount = 0;
        int oCount = 0;
        int rcount2 = 0;
        int rcount3 = 0;
      
        int rcounto0 = 0;
        int rcounto1 = 0;
        int rcounto2 = 0;

        int ccounto0 = 0;
        int ccounto1 = 0;
        int ccounto2 = 0;

        int ccountd0 = 0;
        int ccountd1 = 0;
        int ccountd2 = 0;

        // GameEngine constructors
        public GameEngine() { }
            
        public GameEngine(int row, int col, Form1.CellSelection[,] myGrid)
        {
            this.row = row;
            this.col = col;
            grid = myGrid;
        }

        // Method called from form when New game menu item clicked
        // Sets all grid squares to N
        public void NewGame()
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                     grid[i, j] = Form1.CellSelection.N;
                }
            }
        }

        // Method called from within OnPaint method in form
        // If the player clicks on a valid grid square, make that square an X 
        public bool PlayX()
        {
            if((grid[this.row, this.col] == Form1.CellSelection.N))         
            {
                grid[this.row, this.col] = Form1.CellSelection.X;    
                return true; 
            }  
            else
                return false;
        }
        
        // Method called from form when computer player selected
        // to start first from menu.
        // After this method is called once and places an O,
        // it will never be able to pass an O again.
        public void OStarts(bool oStartClicked)
        {
            if (oStartClicked == true)
            {
                Random r = new Random();
                Random c = new Random();
                int rr = r.Next(0, 3);
                int rc = c.Next(0, 3);

                for(int i = 0; i <= 2; i++)
                {
                    for(int j = 0; j <= 2; j++)
                    {
                        if (grid[rr, rc] == Form1.CellSelection.N)
                        {
                             grid[rr, rc] = Form1.CellSelection.O;
                             oStartClicked = false;
                             return;
                        }
                    }
                }
            }
        }

        public void PlayO()
        {
            Random r = new Random();
            Random c = new Random();
            int rr = r.Next(0, 3);
            int rc = c.Next(0, 3);
            
            for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (grid[i, j] == Form1.CellSelection.X || grid[i, j] == Form1.CellSelection.O)
                        {
                            count++;

                            if ((grid[i, j] == Form1.CellSelection.X)||(grid[i, j] == Form1.CellSelection.O))
                            {
                                xCount++;
                                oCount++;
                            }
                        }
                    }
                }
                if ((xCount == 1)||(oCount==1))
                {
                    // If there is only one X placed, then randomly place an O
                    while ((grid[rr, rc] == Form1.CellSelection.X))
                    {
                        Random rw = new Random();
                        Random cl = new Random();
                        int rrr = rw.Next(0, 3);
                        int rcc = cl.Next(0, 3);
                        if ((rrr != rr) || (rcc != rc))
                        {
                            rr = rrr; rc = rcc;
                            grid[rr, rc] = Form1.CellSelection.O;
                            count++;
                        }
                    }
                    grid[rr, rc] = Form1.CellSelection.O;
                    count++;
                }
                else
                {
                    //  ATTACK: O COLUMNS
                    for (int x = 0; x <= 2; x++)
                    {
                        if (grid[x, 0] == Form1.CellSelection.O)
                            rcounto0++;

                        if (rcounto0 == 2)
                        {
                            for (int a = 0; a <= 2; a++)
                            {
                                if (grid[a, 0] == Form1.CellSelection.N)
                                {
                                    grid[a, 0] = Form1.CellSelection.O;
                                    count++;
                                    return;
                                }
                            }
                        }
                        if (grid[x, 1] == Form1.CellSelection.O)
                            rcounto1++;

                        if (rcounto1 == 2)
                        {
                            for (int a = 0; a <= 2; a++)
                            {
                                if (grid[a, 1] == Form1.CellSelection.N)
                                {
                                    grid[a, 1] = Form1.CellSelection.O;
                                    count++;
                                    return;
                                }
                            }
                        }
                        if (grid[x, 2] == Form1.CellSelection.O)
                            rcounto2++;

                        if (rcounto2 == 2)
                        {
                            for (int a = 0; a <= 2; a++)
                            {
                                if (grid[a, 2] == Form1.CellSelection.N)
                                {
                                    grid[a, 2] = Form1.CellSelection.O;
                                    count++;
                                    return;
                                }
                            }
                        }

                        // ATTACK: O ROWS
                        if (grid[0, x] == Form1.CellSelection.O)
                            ccounto0++;

                        if (ccounto0 == 2)
                        {
                            for (int a = 0; a <= 2; a++)
                            {
                                if (grid[0, a] == Form1.CellSelection.N)
                                {
                                    grid[0, a] = Form1.CellSelection.O;
                                    count++;
                                    return;
                                }
                            }
                        }

                        if (grid[1, x] == Form1.CellSelection.O)
                            ccounto1++;

                        if (ccounto1 == 2)
                        {
                            for (int a = 0; a <= 2; a++)
                            {
                                if (grid[1, a] == Form1.CellSelection.N)
                                {
                                    grid[1, a] = Form1.CellSelection.O;
                                    count++;
                                    return;
                                }
                            }
                        }
                        if (grid[2, x] == Form1.CellSelection.O)
                            ccounto2++;

                        if (ccounto2 == 2)
                        {
                            for (int a = 0; a <= 2; a++)
                            {
                                if (grid[2, a] == Form1.CellSelection.N)
                                {
                                    grid[2, a] = Form1.CellSelection.O;
                                    count++;
                                    return;
                                }
                            }
                        }
                    }

                    // Os attack diagonals
                    if ((grid[0, 0] == Form1.CellSelection.O) && (grid[0, 0] == grid[1, 1]) && (grid[2, 2] == Form1.CellSelection.N))
                    {
                        grid[2, 2] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[0, 0] == Form1.CellSelection.O) && (grid[0, 0] == grid[2, 2]) && (grid[1, 1] == Form1.CellSelection.N))
                    {
                        grid[1, 1] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[1, 1] == Form1.CellSelection.O) && (grid[1, 1] == grid[2, 2]) && (grid[0, 0] == Form1.CellSelection.N))
                    {
                        grid[0, 0] = Form1.CellSelection.O;
                        count++;
                        return;
                    }

                    if ((grid[2, 0] == Form1.CellSelection.O) && (grid[2, 0] == grid[1, 1]) && (grid[0, 2] == Form1.CellSelection.N))
                    {
                        grid[0, 2] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[1, 1] == Form1.CellSelection.O) && (grid[1, 1] == grid[0, 2] && (grid[2, 0] == Form1.CellSelection.N)))
                    {
                        grid[2, 0] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[0, 2] == Form1.CellSelection.O) && (grid[0, 2] == grid[2, 0]) && (grid[1, 1] == Form1.CellSelection.N))
                    {
                        grid[1, 1] = Form1.CellSelection.O;
                        count++;
                        return;
                    }


                    // DEFENSE: Check Rows
                    for (int k = 0; k <= 2; k++)
                    {
                        if (grid[k, 0] == Form1.CellSelection.X)
                            rcount1++;
                        if (rcount1 == 2)
                        {
                            for (int m = 0; m <= 2; m++)
                            {
                                if (grid[m, 0] == Form1.CellSelection.N)
                                {
                                    grid[m, 0] = Form1.CellSelection.O;
                                    count++;
                                    rcount1++;
                                    return;
                                }
                            }
                        }
                    }
                    for (int q = 0; q <= 2; q++)
                    {
                        if (grid[q, 1] == Form1.CellSelection.X)
                            rcount2++;
                        if (rcount2 == 2)
                        {
                            for (int p = 0; p <= 2; p++)
                            {
                                if (grid[p, 1] == Form1.CellSelection.N)
                                {
                                    grid[p, 1] = Form1.CellSelection.O;
                                    count++;
                                    rcount2++;
                                    return;
                                }
                            }
                        }
                    }
                    for (int s = 0; s <= 2; s++)
                    {
                        if (grid[s, 2] == Form1.CellSelection.X)
                            rcount3++;
                        if (rcount3 == 2)
                        {
                            for (int n = 0; n <= 2; n++)
                            {
                                if (grid[n, 2] == Form1.CellSelection.N)
                                {
                                    grid[n, 2] = Form1.CellSelection.O;
                                    count++;
                                    rcount3++;
                                    return;
                                }
                            }
                        }
                    }

                    //    DEFENSE: Check Columns
                    for (int k = 0; k <= 2; k++)
                    {
                        if (grid[0, k] == Form1.CellSelection.X)
                            ccountd0++;
                        if (ccountd0 == 2)
                        {
                            for (int m = 0; m <= 2; m++)
                            {
                                if ((grid[0, m] == Form1.CellSelection.N))
                                {
                                    grid[0, m] = Form1.CellSelection.O;
                                    count++;
                                    ccountd0++;
                                    return;
                                }
                            }
                        }
                    }
                    for (int q = 0; q <= 2; q++)
                    {
                        if (grid[1, q] == Form1.CellSelection.X)
                            ccountd1++;
                        if (ccountd1 == 2)
                        {
                            for (int p = 0; p <= 2; p++)
                            {
                                if ((grid[1, p] == Form1.CellSelection.N))
                                {
                                    grid[1, p] = Form1.CellSelection.O;
                                    count++;
                                    ccountd1++;
                                    return;
                                }
                            }
                        }
                    }
                    for (int s = 0; s <= 2; s++)
                    {
                        if (grid[2, s] == Form1.CellSelection.X)
                            ccountd2++;
                        if (ccountd2 == 2)
                        {
                            for (int n = 0; n <= 2; n++)
                            {
                                if ((grid[2, n] == Form1.CellSelection.N))
                                {
                                    grid[2, n] = Form1.CellSelection.O;
                                    count++;
                                    ccountd2++;
                                    return;
                                }
                            }
                        }
                    }

                    // O Defense: check diagonals
                    if ((grid[0, 0] == Form1.CellSelection.X) && (grid[0, 0] == grid[1, 1]) && (grid[2, 2] == Form1.CellSelection.N))
                    {
                        grid[2, 2] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[0, 0] == Form1.CellSelection.X) && (grid[0, 0] == grid[2, 2]) && (grid[1, 1] == Form1.CellSelection.N))
                    {
                        grid[1, 1] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[1, 1] == Form1.CellSelection.X) && (grid[1, 1] == grid[2, 2]) && (grid[0, 0] == Form1.CellSelection.N))
                    {
                        grid[0, 0] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[2, 0] == Form1.CellSelection.X) && (grid[2, 0] == grid[1, 1]) && (grid[0, 2] == Form1.CellSelection.N))
                    {
                        grid[0, 2] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[1, 1] == Form1.CellSelection.X) && (grid[1, 1] == grid[0, 2]) && (grid[2, 0] == Form1.CellSelection.N))
                    {
                        grid[2, 0] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                    else if ((grid[0, 2] == Form1.CellSelection.X) && (grid[0, 2] == grid[2, 0]) && (grid[1, 1] == Form1.CellSelection.N))
                    {
                        grid[1, 1] = Form1.CellSelection.O;
                        count++;
                        return;
                    }


                    Random randr = new Random();
                    Random randc = new Random();
                    int randrr = r.Next(0, 3);
                    int randrc = c.Next(0, 3);
                    int dr = 0;
                    int dc = 0;

                    if (count < 9)
                    {
                        // If there are no apparent attack or defense moves, then randomly place an O
                        while ((grid[randrr, randrc] == Form1.CellSelection.X) || (grid[randrr, randrc] == Form1.CellSelection.O))
                        {
                            Random rw = new Random();
                            Random cl = new Random();
                            int rrr = rw.Next(0, 3);
                            int rcc = cl.Next(0, 3);
                            if (((rrr != randrr) || (rcc != randrc)) && (this.row != rrr) || (this.col != rcc))
                            {
                                if ((grid[rrr, rcc] == Form1.CellSelection.N))
                                {
                                    dr = rrr; dc = rcc;
                                    grid[dr, dc] = Form1.CellSelection.O;
                                    count++;
                                    return;
                                }
                            }
                        }
                        grid[randrr, randrc] = Form1.CellSelection.O;
                        count++;
                        return;
                    }
                }
        }

 
        // Checks if move is a winner
        public bool CheckWinner()
        {
           int z = 0;
            int inccounter = 0;
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (grid[i, j] != Form1.CellSelection.N)
                    {
                        inccounter++;

                        // If there are 9 pieces on the board and 
                        // not a winner, then game is a draw.
                        if (inccounter == 9)
                        {
                            return true;
                        }
                    }
                }
            }

            // Check rows for winner
            if ((grid[z, 0] == Form1.CellSelection.X) && (grid[z, 0] == grid[z + 1, 0]) && (grid[z + 1, 0] == grid[z + 2, 0]))
            {
                return true;
            }
            else if ((grid[z, 0] == Form1.CellSelection.O) && (grid[z, 0] == grid[z + 1, 0]) && (grid[z + 1, 0] == grid[z + 2, 0]))
            {
                return true;
            }
            else if ((grid[z, 1] == Form1.CellSelection.X) && (grid[z, 1] == grid[z + 1, 1]) && (grid[z + 1, 1] == grid[z + 2, 1]))
            {
                return true;
            }
            else if ((grid[z, 1] == Form1.CellSelection.O) && (grid[z, 1] == grid[z + 1, 1]) && (grid[z + 1, 1] == grid[z + 2, 1]))
            {
                return true;
            }
            else if ((grid[z, 2] == Form1.CellSelection.X) && (grid[z, 2] == grid[z + 1, 2]) && (grid[z + 1, 2] == grid[z + 2, 2]))
            {
                return true;
            }
            else if ((grid[z, 2] == Form1.CellSelection.O) && (grid[z, 2] == grid[z + 1, 2]) && (grid[z + 1, 2] == grid[z + 2, 2]))
            {
                return true;
            }

            // Check columns for winner
            else if ((grid[0, z] == Form1.CellSelection.X) && (grid[0, z] == grid[0, z + 1]) && (grid[0, z + 1] == grid[0, z + 2]))
            {
                return true;
            }
            else if ((grid[0, z] == Form1.CellSelection.O) && (grid[0, z] == grid[0, z + 1]) && (grid[0, z + 1] == grid[0, z + 2]))
            {
                return true;
            }
            else if ((grid[1, z] == Form1.CellSelection.X) && (grid[1, z] == grid[1, z + 1]) && (grid[1, z + 1] == grid[1, z + 2]))
            {
                return true;
            }
            else if ((grid[1, z] == Form1.CellSelection.O) && (grid[1, z] == grid[1, z + 1]) && (grid[1, z + 1] == grid[1, z + 2]))
            {
                return true;
            }
            else if ((grid[2, z] == Form1.CellSelection.X) && (grid[2, z] == grid[2, z + 1]) && (grid[2, z + 1] == grid[2, z + 2]))
            {
                return true;
            }
            else if ((grid[2, z] == Form1.CellSelection.O) && (grid[2, z] == grid[2, z + 1]) && (grid[2, z + 1] == grid[2, z + 2]))
            {
                return true;
            }

        //Check Diags
            else if ((grid[0, 0] == Form1.CellSelection.X) && (grid[0, 0] == grid[1, 1]) && (grid[1, 1] == grid[2, 2]))
            {
                return true;
            }
            else if ((grid[0, 0] == Form1.CellSelection.O) && (grid[0, 0] == grid[1, 1]) && (grid[1, 1] == grid[2, 2]))
            {
                return true;
            }
            else if ((grid[0, 2] == Form1.CellSelection.X) && (grid[0, 2] == grid[1, 1]) && (grid[1, 1] == grid[2, 0]))
            {
                return true;
            }
            else if ((grid[0, 2] == Form1.CellSelection.O) && (grid[0, 2] == grid[1, 1]) && (grid[1, 1] == grid[2, 0]))
            {
                return true;
            }
            else
                return false;
            }

        // If method CheckWinner returns true, as in there is a winner,
        // then this method will check who has won.
        public string WhoWon()
        {
            int z = 0;
            int inccounter = 0;
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (grid[i, j] != Form1.CellSelection.N)
                    {
                        inccounter++;
                    }
                }
            }

            // Check rows for winner
            if ((grid[z, 0] == Form1.CellSelection.X) && (grid[z, 0] == grid[z + 1, 0]) && (grid[z + 1, 0] == grid[z + 2, 0]))
            {
                return "X Wins!";
            }
            else if ((grid[z, 0] == Form1.CellSelection.O) && (grid[z, 0] == grid[z + 1, 0]) && (grid[z + 1, 0] == grid[z + 2, 0]))
            {
                return "O Wins!";
            }
            else if ((grid[z, 1] == Form1.CellSelection.X) && (grid[z, 1] == grid[z + 1, 1]) && (grid[z + 1, 1] == grid[z + 2, 1]))
            {
                return "X Wins!";
            }
            else if ((grid[z, 1] == Form1.CellSelection.O) && (grid[z, 1] == grid[z + 1, 1]) && (grid[z + 1, 1] == grid[z + 2, 1]))
            {
                return "O Wins!";
            }
            else if ((grid[z, 2] == Form1.CellSelection.X) && (grid[z, 2] == grid[z + 1, 2]) && (grid[z + 1, 2] == grid[z + 2, 2]))
            {
                return "X Wins!";
            }
            else if ((grid[z, 2] == Form1.CellSelection.O) && (grid[z, 2] == grid[z + 1, 2]) && (grid[z + 1, 2] == grid[z + 2, 2]))
            {
                return "O Wins!";
            }

            // Check columns for winner
            else if ((grid[0, z] == Form1.CellSelection.X) && (grid[0, z] == grid[0, z + 1]) && (grid[0, z + 1] == grid[0, z + 2]))
            {
                return "X Wins!";
            }
            else if ((grid[0, z] == Form1.CellSelection.O) && (grid[0, z] == grid[0, z + 1]) && (grid[0, z + 1] == grid[0, z + 2]))
            {
                return "O Wins!";
            }
            else if ((grid[1, z] == Form1.CellSelection.X) && (grid[1, z] == grid[1, z + 1]) && (grid[1, z + 1] == grid[1, z + 2]))
            {
                return "X Wins!";
            }
            else if ((grid[1, z] == Form1.CellSelection.O) && (grid[1, z] == grid[1, z + 1]) && (grid[1, z + 1] == grid[1, z + 2]))
            {
                return "O Wins!";
            }
            else if ((grid[2, z] == Form1.CellSelection.X) && (grid[2, z] == grid[2, z + 1]) && (grid[2, z + 1] == grid[2, z + 2]))
            {
                return "X Wins!";
            }
            else if ((grid[2, z] == Form1.CellSelection.O) && (grid[2, z] == grid[2, z + 1]) && (grid[2, z + 1] == grid[2, z + 2]))
            {
                return "O Wins!";
            }

        //Check Diags
            else if ((grid[0, 0] == Form1.CellSelection.X) && (grid[0, 0] == grid[1, 1]) && (grid[1, 1] == grid[2, 2]))
            {
                return "X Wins!";
            }
            else if ((grid[0, 0] == Form1.CellSelection.O) && (grid[0, 0] == grid[1, 1]) && (grid[1, 1] == grid[2, 2]))
            {
                return "O Wins!";
            }
            else if ((grid[0, 2] == Form1.CellSelection.X) && (grid[0, 2] == grid[1, 1]) && (grid[1, 1] == grid[2, 0]))
            {
                return "X Wins!";
            }
            else if ((grid[0, 2] == Form1.CellSelection.O) && (grid[0, 2] == grid[1, 1]) && (grid[1, 1] == grid[2, 0]))
            {

                return "O Wins!";
            }
            else if (inccounter == 9)
                // If there are 9 pieces on the board and 
                // not a winner, then game is a draw.
                {
                    return "Game is drawn!";
                }
            else
            {
                return "";
            }   
        }
        }
    }



            
            
        
        
    

