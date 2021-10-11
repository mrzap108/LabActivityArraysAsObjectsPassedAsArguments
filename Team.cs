using System;

class Team
{
    int totals=0;
    int loopVar = 0;
    Player[] players = new Player[5];

    public Team()
    {
        totals = 0;
        while(loopVar < 5)
            {
                players[loopVar] = new Player();
                loopVar++;
            }
    }

    public void CreateTeam(Player[] players)
    {
        
        loopVar = 0;
        while(loopVar < 5)
        {
            this.players[loopVar].PlayerName = players[loopVar].PlayerName;
            this.players[loopVar].Points = players[loopVar].Points;
            this.players[loopVar].Rebounds = players[loopVar].Rebounds;
            this.players[loopVar].Assists = players[loopVar].Assists;
            loopVar++;
        }
    }
    
    public int ComputeTotals(int mode)
    {
        int totals = 0;
        int loopVar = 0;
        while(loopVar < 5)
        {
            if(mode == 1)
            {
                totals = totals + players[loopVar].Points;
            }
            else if(mode == 2)
            {
                totals = totals + players[loopVar].Rebounds;
            }
            else if(mode == 3)
            {
                totals = totals + players[loopVar].Assists;
            }
            else{}
                
            loopVar++;
        }
        
        return(totals);
    }

    public void RevealPlayers()
    {
        loopVar = 0;
        while(loopVar < 5)
        {
            Console.WriteLine("Player {0}: \t{1}", loopVar+1, players[loopVar].PlayerName);
            loopVar++;
        }
    }

    public void RevealScores()
    {
        loopVar = 0;
        while(loopVar < 5)
        {
            Console.WriteLine("Player {0}:\tPoints: {1}\tRebounds: {2}\tAssists: {3}", players[loopVar].PlayerName, players[loopVar].Points, players[loopVar].Rebounds, players[loopVar].Assists);
            loopVar++;
        }
    }

}