// See https://aka.ms/new-console-template for more information
using System;

namespace TicTacToe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choice;
        static int move = 0;
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
            while (move < 9);
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
         
        private void CheckWin()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                Console.WriteLine("Winner: " + arr[1]);
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
        }
    }
}
