// See https://aka.ms/new-console-template for more information
using System;

namespace TicTacToe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choice;
        static int move = 0;
        static int flag;
        static void Main(string[] args)
        {
            do 
            {             
                Console.Clear();
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] == 'X' || arr[choice] == 'O')
                {
                    Console.WriteLine("Already taken");
                }
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (move % 2 == 0)
                    {
                        arr[choice] = 'X';
                        move++;
                    }
                    else 
                    {
                        arr[choice] = 'O';
                        move++;
                    }
                    flag = CheckWin();

                }
                else
                {
                    Console.WriteLine("wtf, wrong move, man! Wait for a sec!");
                    Console.WriteLine("\n");
                    Thread.Sleep(1000);
                }
                if (move == 8)
                {
                    Console.WriteLine("it's foking draw");
                }
            }   
            while (flag != 1 && flag != -1);
            if (flag == 1)
                // if flag value is 1 then someone has win or
                //means who played marked last time which has win
            {
                Console.WriteLine("X has won");
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
        }

        static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        private static int CheckWin()
        {
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            // If all the cells or values filled with X or O then any player has won the match
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
