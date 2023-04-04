using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
namespace myspace
{
    internal class program
    {
        static List<string> map = new List<string>();
        static void fillMap()
        {
            for (int i = 0; i < 9; i++)
            {

                map.Add(".");
            }
        }
        static void showmap()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write('\n');
                }
                Console.Write(map[i]);
            }
        }
        static void choiceX()
        {
            int choiceNum;
            showmap();
            choiceNum = Console.ReadKey().KeyChar - 48;
            Console.Clear();
            if (map[choiceNum - 1] == "X" || map[choiceNum - 1] == "O" || choiceNum < 1 || choiceNum > 9)
            {
                Console.WriteLine("Wrong choice.Please try again");
                choiceX();
            }
            map[choiceNum - 1] = "X";
        }
        static void choiceO()
        {
            int choiceNum;
            showmap();
            choiceNum = Console.ReadKey().KeyChar - 48;
            Console.Clear();
            if (map[choiceNum - 1] == "X" || map[choiceNum - 1] == "O" || choiceNum < 1 || choiceNum > 9)
            {
                Console.WriteLine("Wrong choice.Please try again");
                choiceO();
            }
            map[choiceNum - 1] = "O";
        }
        static char CheckWinner()
        {
            if (map[0] == "X" && map[1] == "X" && map[2] == "X")
            {
                return 'X';
            }
            else if (map[3] == "X" && map[4] == "X" && map[5] == "X")
            {
                return 'X';
            }
            else if (map[6] == "X" && map[7] == "X" && map[8] == "X")
            {
                return 'X';
            }
            else if (map[0] == "X" && map[3] == "X" && map[6] == "X")
            {
                return 'X';
            }
            else if (map[1] == "X" && map[4] == "X" && map[7] == "X")
            {
                return 'X';
            }
            else if (map[2] == "X" && map[5] == "X" && map[8] == "X")
            {
                return 'X';
            }
            else if (map[0] == "X" && map[4] == "X" && map[8] == "X")
            {
                return 'X';
            }
            else if (map[2] == "X" && map[4] == "X" && map[6] == "X")
            {
                return 'X';
            }
            else if (map[0] == "O" && map[1] == "O" && map[2] == "O")
            {
                return 'O';
            }
            else if (map[3] == "O" && map[4] == "O" && map[5] == "O")
            {
                return 'O';
            }
            else if (map[6] == "O" && map[7] == "O" && map[8] == "O")
            {
                return 'O';
            }
            else if (map[0] == "O" && map[3] == "O" && map[6] == "O")
            {
                return 'O';
            }
            else if (map[1] == "O" && map[4] == "O" && map[7] == "O")
            {
                return 'O';
            }
            else if (map[2] == "O" && map[5] == "O" && map[8] == "O")
            {
                return 'O';
            }
            else if (map[0] == "O" && map[4] == "O" && map[8] == "O")
            {
                return 'O';
            }
            else if (map[2] == "O" && map[4] == "O" && map[6] == "O")
            {
                return 'O';
            }
            else return ' ';
        }
        static void startTicTacToe()
        {
            fillMap();
            char check;
            for (int i = 0; i < 8; i++)
            {
                choiceX();
                check = CheckWinner();
                if (check == 'X')
                {
                    Console.WriteLine("X win");
                    return;
                }
                choiceO();
                check = CheckWinner();
                if (check == 'O')
                {
                    Console.WriteLine("O win");
                    return;
                }

            }
        }
        static void Main(string[] args)
        {
            startTicTacToe();
        }
    }

}
