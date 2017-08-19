using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C17_Ex02_Yakov_Hason
{
    public class UserInterface
    {


        private static void WelcomeScreen()
        {
        Console.Write(@" Welcome to my game ");
   
        }



        /*
        private static void   CreatingTheBord(MethodAndLogic i_Game)

        {
            int MiddelPoint;
            char Letter = 'A';
            StringBuilder Board = new StringBuilder();


            for(int i = 0; i< (9    * 2)+1 ; i++)
            {
                if(i % 2 == 1)
                { Bord.Append("   ="); }

                //Bord.AppendFormat(" {0}  |"(i / 2));



                for (int j = 0; j < 9; j++)

                {






                }





            }

            { 
                    if (i % 2 == 1)
                    {
                        Board.Append("   =");
                    }
                    else if (i != 0)
                    {
                        Board.AppendFormat("{0} |", (i / 2).ToString().PadLeft(2));
                    }
                    else
                    {
                        Board.Append(' ', 5);
                    }

                    for (int j = 0; j < 9 ; j++)
                    {
                        if (i == 0)
                        {
                            Board.AppendFormat("{0}   ", Letter++);
                        }
                        else if (i % 2 == 1)
                        {
                            Board.Append('=', 4);
                        }
                        else
                        {
                            Board.Append(" ");
                            if (i_CurrentGame.GameBoard[(i / 2) - 1, j] == GameLogic.eCellState.X)
                            {
                                Board.Append('X');
                            }
                            else if (i_CurrentGame.GameBoard[(i / 2) - 1, j] == GameLogic.eCellState.O)
                            {
                                Board.Append('O');
                            }
                            else if (i_CurrentGame.GameBoard[(i / 2) - 1, j] == GameLogic.eCellState.PossibleMove)
                            {
                                Board.Append('.');
                            }
                            else
                            {
                                Board.Append(" ");
                            }

                            Board.Append(" |");
                        }
                    }

                    if (i == middleOfBoardPrint)
                    {
                        Board.AppendFormat(" Last move: {0}", getMoveAsString(i_CurrentGame.CurrentMove));
                    }
                    else if (i == middleOfBoardPrint + 2)
                    {
                        Board.AppendFormat(" [{0} ({1}): {2}]", PlayerOne.PlayerName, PlayerOne.PlayerColor, i_CurrentGame.GameBoard.XCount.ToString());
                    }
                    else if (i == middleOfBoardPrint + 3)
                    {
                        Board.AppendFormat(" [{0} ({1}): {2}]", PlayerTwo.PlayerName, PlayerTwo.PlayerColor, i_CurrentGame.GameBoard.OCount.ToString());
                    }
                    else if (i == middleOfBoardPrint + 5)
                    {
                        Board.AppendFormat(" Possible moves: {0}", i_CurrentGame.PossibleMovesCounter);
                    }

                    Board.Append(Environment.NewLine);
                }

                drawBoardByColor(Board);
            }
            */


        
        }





    }








    
}
