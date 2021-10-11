using System;

namespace Lab11ArrayOfObjectsPassedParametersVSCode
{
    class Program
    {
        //#1
        // static void Main(string[] args)
        // {
        //     Console.Clear();
        //     ItemOnSale[] items = new ItemOnSale[5];
        //     Displays display = new Displays();
        //     ComputeGrocery compute = new ComputeGrocery();

        //     int loopVar = 0;
        //     string choice;
        //     int numOfItems;
        //     double price;
        //     double moneyPaid;
        //     double change;
            
        //     while(loopVar < 5)
        //     {
        //         items[loopVar] = new ItemOnSale();
        //         loopVar++;
        //     }

        //     Console.WriteLine("Enter name and price of each item to be on sale: ");
        //     loopVar = 0;
        //     while(loopVar < 5)
        //     {
        //         Console.Write("Enter name of item {0}: ", loopVar+1);
        //         items[loopVar].ItemName = Console.ReadLine();
        //         Console.Write("Enter price of item: " );
        //         items[loopVar].Price = Convert.ToDouble(Console.ReadLine());
        //         loopVar++;
        //     }
        //     Console.WriteLine("");
        //     display.DisplayItemsOnSale(items);
        //     Console.WriteLine("Select your choice from 1 to 5: ");
        //     choice = Console.ReadLine();
        //     Console.WriteLine("Enter number of items to purchase: ");
        //     numOfItems = Convert.ToInt32(Console.ReadLine());
        //     price = compute.TotalPrice(items, choice, numOfItems);
        //     Console.WriteLine("The total price is {0}", price); 
        //     Console.WriteLine("Enter money to pay: ");
        //     moneyPaid = Convert.ToDouble(Console.ReadLine());
        //     change = compute.ComputeChange(moneyPaid);
        //     Console.WriteLine("Your change is {0}", change);

        // }

        //#2
        static void Main(string[] args)
        {
            Console.Clear();
            Player[] players = new Player[5];
            Team[] teams = new Team[2];
            Association theAssociation = new Association();
            int loopVar = 0;
            int totalScore1 = 0;
            int totalScore2 = 0;
            
            while(loopVar < 5)
            {
                players[loopVar] = new Player();
                loopVar++;
            }
            loopVar = 0;
            while(loopVar < 2)
            {
                teams[loopVar] = new Team();
                loopVar++;
            }

            Console.WriteLine("Creating Team 1");
            players[0] = new Player("jimmy cricket", 12, 10, 15);
            players[1] = new Player("tom sawyer", 22, 15, 9);
            players[2] = new Player("Pau Gasol", 22, 8, 4);
            players[3] = new Player("Damian Lillard", 35, 3, 10);
            players[4] = new Player("Luis Scola", 32, 10, 10);
            
            teams[0].CreateTeam(players);
            teams[0].RevealPlayers();

            Console.WriteLine("Creating Team 2");
            players[0] = new Player("michael jordan", 35, 10, 15);
            players[1] = new Player("scottie pippen", 22, 11, 9);
            players[2] = new Player("toni kukoc", 17, 8, 4);
            players[3] = new Player("dennis rodman", 0, 20, 1);
            players[4] = new Player("steve kerr", 15, 0, 0);

            teams[1].CreateTeam(players);
            teams[1].RevealPlayers();

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Individual Player Game Stats");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Team 1");
            teams[0].RevealScores();
            Console.WriteLine("Team 2");
            teams[1].RevealScores();
           
            Console.Write("\n");

            totalScore1 = teams[0].ComputeTotals(1);
            totalScore2 = teams[1].ComputeTotals(1);

            Console.WriteLine("Final Team Scores=>\t Team 1: \t{0}\t\tTeam 2: \t{1}", totalScore1, totalScore2);
            //Console.WriteLine("SCore Team 2: \t{0}", totalScore2);

            totalScore1 = teams[0].ComputeTotals(2);
            totalScore2 = teams[1].ComputeTotals(2);

            Console.WriteLine("Final Team Rebounds=>\t Team 1: \t{0}\t\tTeam 2: \t{1}", totalScore1, totalScore2);
            // Console.WriteLine("Rebounds Team 1: \t{0}", totalScore1);
            // Console.WriteLine("Rebounds Team 2: \t{0}", totalScore2);

            totalScore1 = teams[0].ComputeTotals(3);
            totalScore2 = teams[1].ComputeTotals(3);

            Console.WriteLine("Final Team Assists=>\t Team 1: \t{0}\t\tTeam 2: \t{1}", totalScore1, totalScore2);
            // Console.WriteLine("Assists Team 1: \t{0}", totalScore1);
            // Console.WriteLine("Assists Team 2: \t{0}", totalScore2);

        //     Team theTeam = new Team();
        //     int scoreP1;
        //     int scoreP2;
        //     int scoreP3;
        //     int scoreP4;
        //     int scoreP5;
        //     int reboundP1;
        //     int reboundP2;
        //     int reboundP3;
        //     int reboundP4;
        //     int reboundP5;
        //     int assistsP1;
        //     int assistsP2;
        //     int assistsP3;
        //     int assistsP4;
        //     int assistsP5;
        //     int totalScore;
        //     int totalRebounds;
        //     int totalAssists;
        //     int compare;

        //     player1.PlayerName = "jimmy cricket";
        //     player1.Points = 12;
        //     player1.Rebounds = 10;
        //     player1.Assists = 5;

        //     player2.PlayerName = "tom sawyer";
        //     player2.Points = 22;
        //     player2.Rebounds = 15;
        //     player2.Assists = 9;

        //     scoreP1 = player1.GetPoints();
        //     scoreP2 = player2.GetPoints();
        //     scoreP3 = player3.GetPoints();
        //     scoreP4 = player4.GetPoints();
        //     scoreP5 = player5.GetPoints();

        //     reboundP1 = player1.GetRebounds();
        //     reboundP2 = player2.GetRebounds();
        //     reboundP3 = player3.GetRebounds();
        //     reboundP4 = player4.GetRebounds();
        //     reboundP5 = player5.GetRebounds();

        //     assistsP1 = player1.GetAssists();
        //     assistsP2 = player2.GetAssists();
        //     assistsP3 = player3.GetAssists();
        //     assistsP4 = player4.GetAssists();
        //     assistsP5 = player5.GetAssists();

        //     totalScore = theTeam.ComputeTotals(scoreP1, scoreP2, scoreP3, scoreP4, scoreP5);

        //     Console.WriteLine("Player 1 has {0} points", scoreP1);
        //     Console.WriteLine("Player 2 has {0} points", scoreP2);
        //     Console.WriteLine("Player 3 has {0} points", scoreP3);
        //     Console.WriteLine("Player 4 has {0} points", scoreP4);
        //     Console.WriteLine("Player 5 has {0} points", scoreP5);

        //     Console.WriteLine("The team has score {0} points", totalScore);

        //     totalRebounds = theTeam.ComputeTotals(reboundP1, reboundP2, reboundP3, reboundP4, reboundP5);

        //     Console.WriteLine("Player 1 has {0} rebounds", reboundP1);
        //     Console.WriteLine("Player 2 has {0} rebounds", reboundP2);
        //     Console.WriteLine("Player 3 has {0} rebounds", reboundP3);
        //     Console.WriteLine("Player 4 has {0} rebounds", reboundP4);
        //     Console.WriteLine("Player 5 has {0} rebounds", reboundP5);

        //     Console.WriteLine("The team has score {0} rebounds", totalRebounds);

        //     totalAssists = theTeam.ComputeTotals(assistsP1, assistsP2, assistsP3, assistsP4, assistsP5);

        //     Console.WriteLine("Player 1 has {0} assists", assistsP1);
        //     Console.WriteLine("Player 2 has {0} assists", assistsP2);
        //     Console.WriteLine("Player 3 has {0} assists", assistsP3);
        //     Console.WriteLine("Player 4 has {0} assists", assistsP4);
        //     Console.WriteLine("Player 5 has {0} assists", assistsP5);

        //     Console.WriteLine("The team has score {0} assists", totalAssists);

            
        //     compare = player3.HasMorePoints(scoreP4);
        //     if(compare == 0)
        //     {
        //         Console.WriteLine("Player 3 has more points than Player 4");
        //     }
        //     else if(compare == 1)
        //     {
        //         Console.WriteLine("Player 4 has more points than Player 3");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Player 3 and Player 4 have same score");
        //     }

        //     compare = player2.HasMorePoints(scoreP3);
        //     if(compare == 0)
        //     {
        //         Console.WriteLine("Player 2 has more points than Player 3");
        //     }
        //     else if(compare == 1)
        //     {
        //         Console.WriteLine("Player 3 has more points than Player 2");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Player 2 and Player 3 have same score");
        //     }

        //     compare = player3.HasMoreRebounds(reboundP4);
        //     if(compare == 0)
        //     {
        //         Console.WriteLine("Player 3 has more rebound than Player 4");
        //     }
        //     else if(compare == 1)
        //     {
        //         Console.WriteLine("Player 4 has more rebound than Player 3");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Player 3 and Player 4 have same score");
        //     }

        //     compare = player2.HasMoreRebounds(reboundP3);
        //     if(compare == 0)
        //     {
        //         Console.WriteLine("Player 2 has more rebounds than Player 3");
        //     }
        //     else if(compare == 1)
        //     {
        //         Console.WriteLine("Player 3 has more rebounds than Player 2");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Player 2 and Player 3 have same score");
        //     }

        //     Console.WriteLine("The name of player 1 is {0}", player1.GetName());

        }
    }
}
