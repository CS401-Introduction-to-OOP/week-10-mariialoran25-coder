using System.Collections;

namespace Week10;

public class Party : IEnumerable<Player>
{
    private List<Player> _players = new List<Player>();

    public void AddPlayer(Player player)
    {
        _players.Add(player);
    }

    public IEnumerator<Player> GetEnumerator()
    {
        foreach (var player in _players)
        {
            yield return player;
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    

    public IEnumerable<Player> GetActiveEnumerable()
    {
        foreach (var player in _players)
        {
            if (player.Status == Player.conditionOfPlayer.Active)
            {
                yield return player;
            }
        }
    }


    public IEnumerable<Player> GetHpUnderValue(int value)
    {
        foreach (var player in _players)
        {
            if (player.CountOFHealth < value)
            {
                yield return player;
            }
        }
    }

    public IEnumerable<Player> FilterLevel(int minLevel)
    {
        return _players.Where(f => f.Level >= minLevel);
    }
    
    public IEnumerable<Player> SortHp()
    {
        return _players.OrderBy(c => c.CountOFHealth);
    }
    
    public IEnumerable<string> SelectNames()
    {
        return _players.Select(s => s.Name);
    }
    
    public Player MaxCountOgGold()
    {
        return _players.MaxBy(m => m.Gold);
        
    }
    
    public int CountByInjured()
    {
        return _players.Count(c => c.Status == Player.conditionOfPlayer.Injured);
    }
    
}