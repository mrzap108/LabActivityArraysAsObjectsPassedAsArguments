class Player
{
    string playerName;
    int points;
    int rebounds;
    int assists;
    
    public Player()
    {
        playerName = " ";
        points = 0;
        rebounds = 0;
        assists = 0;
    }

    public Player(string playerName, int points, int rebounds, int assists)
    {
        this.playerName = playerName;
        this.points = points;
        this.rebounds = rebounds;
        this.assists = assists;
    }

    public string PlayerName
    {
        get
        {
            return playerName;
        }
        set 
        {
            playerName = value;
        }
    }

    public int Points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
        }
    }

    public int Rebounds
    {
        get
        {
            return rebounds;
        }
        set
        {
            rebounds = value;
        }
    }

    public int Assists
    {
        get
        {
            return assists;
        }
        set
        {
            assists = value;
        }
    }

    public string GetName()
    {
        return playerName;
    }
    
    public int GetPoints()
    {
        return points;
    }

    public int GetRebounds()
    {
        return rebounds;
    }

    public int GetAssists()
    {
        return assists;
    }

    public int HasMorePoints(int comparedPoints)
    {
        if(points > comparedPoints)
        {
            return 0;
        }
        else if(points < comparedPoints)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public int HasMoreRebounds(int comparedRebounds)
    {
        if(rebounds > comparedRebounds)
        {
            return 0;
        }
        else if(rebounds < comparedRebounds)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public int HasMoreAssists(int comparedAssists)
    {
        if(assists > comparedAssists)
        {
            return 0;
        }
        else if(assists < comparedAssists)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    
}