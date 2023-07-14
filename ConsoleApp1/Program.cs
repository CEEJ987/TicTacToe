namespace TicTacToe;

    public class Player
{
    public string Name;
    public string Marker;
    public Player(string name, string marker)
    {
        Name = name;
        Marker = marker;
    }
    internal class Prgram
    {
        public static string[][] Board;
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Let's play TicTacToe!");
            Console.Write("Playr1's name:");
            string player1name = Console.ReadLine();
            Player player1 = new Player(player1name, "X");


            Console.Write("Playr2's name:");
            string player2name = Console.ReadLine();
            Player player2 = new Player(player2name, "O");

            Board = new string[][]
            {
                new string[] {"1", "2", "3",},
                new string[] {"4", "5", "6",},
                new string[] {"7", "8", "9",},
            };

            Console.WriteLine("====== {0} vs {1} =====", player1, player2);
            
            Player currentPlayer = player1;
            string winner = null;
            while (winner == null)
            {
                Console.WriteLine("It's {0}'s turn!", currentPlayer.Name);
                Console.WriteLine("Please choose a spot.");
                DisplayBoard();
                string selectedSlot = Console.ReadLine();
                if (selectedSlot == "1")
                {
                    Board[0][0] = currentPlayer.Marker;

                }
                else if (selectedSlot == "2")
                {
                    Board[0][1] = currentPlayer.Marker;
                }
                else if (selectedSlot == "3")
                {
                    Board[0][2] = currentPlayer.Marker;
                }
                else if (selectedSlot == "4")
                {
                    Board[1][0] = currentPlayer.Marker;
                }
                else if (selectedSlot == "5")
                {
                    Board[1][1] = currentPlayer.Marker;
                }
                else if (selectedSlot == "6")
                {
                    Board[1][2] = currentPlayer.Marker;
                }
                else if (selectedSlot == "7")
                {
                    Board[2][0] = currentPlayer.Marker;
                }
                else if (selectedSlot == "8")
                {
                    Board[2][1] = currentPlayer.Marker;
                }
                else if (selectedSlot == "9")
                {
                    Board[2][2] = currentPlayer.Marker;
                }
                else if (currentPlayer == player2)
                {
                    currentPlayer = player1;
                }
                   
                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else if 
                    (currentPlayer == player2)
                {
                    currentPlayer = player1;
                }
            }
        }
        static void DisplayBoard()
        {
            Console.WriteLine("|{0}||{1}||{2}|", Board[0][0], Board[0][1], Board[0][2]);
            Console.WriteLine("|{0}||{1}||{2}|", Board[1][0], Board[1][1], Board[1][2]);
            Console.WriteLine("|{0}||{1}||{2}|", Board[2][0], Board[2][1], Board[2][2]);

        }
    } 
}


