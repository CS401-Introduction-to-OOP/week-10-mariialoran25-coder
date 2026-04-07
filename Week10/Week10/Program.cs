namespace Week10;

public class Program
{
    static void Main()
    {
        Player player1 = new Player("Mariia","Luxery", "Strategy",9,2,Player.conditionOfPlayer.Active, 150);
        Player player2 = new Player("Taisa","Luxery", "Support",9,3,Player.conditionOfPlayer.Active,300);
        Player player3 = new Player("Oleg","Simple", "Tank",5,0,Player.conditionOfPlayer.Passive,650);

        Console.WriteLine("All people who register:");
        Console.WriteLine(player1);
        Console.WriteLine(player2);
        Console.WriteLine(player3);
        
        
        
        Party party = new Party();
        party.AddPlayer(player1);
        party.AddPlayer(player2);
        party.AddPlayer(player3);

        Console.WriteLine();
        Console.WriteLine("All player who joined the game");
        foreach (var addplayer in party)
        {
            Console.WriteLine(addplayer);
        }
        
        Console.WriteLine();

        Console.WriteLine("All active players");
        foreach (var active in party.GetActiveEnumerable())
        {
            Console.WriteLine(active);
        }


        Console.WriteLine();
        Console.WriteLine($"All players who have under 2 Hp ");
        foreach (var hp in party.GetHpUnderValue(2))
        {
            Console.WriteLine(hp);
        }


        Console.WriteLine();
        Console.WriteLine("LINQ and Lambda");
        var level = party.FilterLevel(10);
        Console.WriteLine($"Players have more level than 10: {level.GetEnumerator()}");
        
        var names = party.SelectNames();
        Console.WriteLine($"Names of player {names}");

        var max = party.MaxCountOgGold();
        Console.WriteLine($"Player: {max}");

        var count = party.CountByInjured();
        Console.WriteLine($"Count of player who injured:  {count}");
        
        
        
      

        Action action1 = new Action(6, "Doing 2 move to killer", "Tank", "Boxer");
        Action action2 = new Action(7, "Kill makaruntangu", "Fight", "Tank");
        EventLog log = new EventLog();
        
        log.AddAction(action1);
        log.AddAction(action2);

        Console.WriteLine();
        Console.WriteLine("Chronology of events");
        foreach (var chr in log.GetChronology())
        {
            Console.WriteLine(chr);
        }

        Console.WriteLine();
        Console.WriteLine("Some type of action");
        foreach (var type in log.GetActionSomeType("Tank"))
        {
            Console.WriteLine($"Type: {type.TypeOfAction}, Description: {type.Description}");
        }
    }
}

