using System;
namespace TickTocktoe;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {'0', '1', '2', '3', '4', '5', '6', '7', '8','9'};
        int player = 1;
        int choice;
        int flag = 0;
        Console.Clear();
        Console.WriteLine("Player 1:X and Player 2:O");
        if(player%2==0)
        {
            Console.WriteLine("Player 2 chance");
        }
        else
        {
            Console.WriteLine("Player 1 chance");
        }

        //creates board
        Console.WriteLine("{0},{1},{2}",arr[1],arr[2],arr[3]);
        Console.WriteLine("{0},{1},{2}",arr[4], arr[5], arr[6]);
        Console.WriteLine("{0},{1},{2}",arr[7], arr[8], arr[9]);

        choice = Convert.ToInt32(Console.ReadLine());

        if(arr[choice]!='X' && arr[choice]!='O')
        {
            if(player%2==0)
            {
                arr[choice] = 'O';
                player++;
                
            }
            else
            {
                arr[choice] = 'X';
                player++;
            }
        }
        else
        {
            Console.WriteLine("The position already Marked", arr[choice]);

        }

        while (flag != 1 && flag != -1)
        {

            if (flag == 1)
            {
                Console.WriteLine("Player has won", (player % 2) + 1);
            }

            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
            //Wining Condition

            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                Console.WriteLine("Won");
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                Console.WriteLine("won");
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                Console.WriteLine("Won");
            }
            //Digonally
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                Console.WriteLine("Won");
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                Console.WriteLine("won", "Digon");
            }

            //Verical Win

            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                Console.WriteLine("Won", "vertical");
            }

            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                Console.WriteLine("Won", "V");
            }

            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                Console.WriteLine("Won", "V");
            }

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                Console.WriteLine("None");

            else
            {
                Console.WriteLine("Nothing");
            }
            if (flag == 1)
            {
                Console.WriteLine("Player 2 has won");
            }
            else
            {
                Console.WriteLine("One has won");
            }
        }

        
    }
}