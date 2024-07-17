using PlayerApp;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool mainWhileLoop = true;
            Player[] players = new Player[]
            {
                    new Player(1,"Atharv",21),
                    new Player(2,"Shubu",10),
                    new Player(3,"Nishank"),
                    new Player(4,"Athul",90)
            };

            int userPlayerId;

            while (mainWhileLoop)
            {
                Console.WriteLine("Press 1 for Entering the Player Id or 2 to Exit or 3 for getting Max Age Player");

                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the Player Id");
                        userPlayerId = int.Parse(Console.ReadLine());
                        Player selectedPlayer = players[userPlayerId - 1];

                        Console.WriteLine("The Player's Id is {0}", selectedPlayer.GetId());
                        Console.WriteLine("The Player's Name is {0}",selectedPlayer.GetName());
                        Console.WriteLine("The Player's Age is {0}", selectedPlayer.GetAge());
                        break;
                    case 2:
                        Console.WriteLine("Exiting......");
                        mainWhileLoop = false;
                        break;

                    case 3:
                        Player maxAgePlayer = WhoIsElder(players);
                        Console.WriteLine("The Details of Player with Maximum Age is :");
                        Console.WriteLine("Player Id :{0}",maxAgePlayer.GetId());
                        Console.WriteLine("Player Name :{0}",maxAgePlayer.GetName());
                        Console.WriteLine("Player Age :{0}",maxAgePlayer.GetAge());
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }


            }

        }

        public static Player WhoIsElder(Player[] player)
        {
            int maxPlayerAge = 0;
            Player maxAgePlayer = null;

            foreach (Player selectedPlayer in player)
            {
                int currentPlayerAge = selectedPlayer.GetAge();
                if (currentPlayerAge > maxPlayerAge)
                {
                    maxPlayerAge = currentPlayerAge;
                    maxAgePlayer = (Player)selectedPlayer;
                }   
            }
            return maxAgePlayer;

        }
    }
}
