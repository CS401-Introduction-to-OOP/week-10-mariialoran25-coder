namespace Week10;

public class Program
{
    static void Main()
    {
        Player player1 = new Player("Mariia","Luxery", "Strategy",9,2,Player.conditionOfPlayer.Active, 150);
        Player player2 = new Player("Taisa","Luxery", "Support",9,3,Player.conditionOfPlayer.Active,300);
        Player player3 = new Player("Oleg","Simple", "Tank",5,0,Player.conditionOfPlayer.Passive,650);

        Console.WriteLine(player1);
        Console.WriteLine(player2);
        Console.WriteLine(player3);
        
        
        
        Party party = new Party();
        party.AddPlayer(player1);
        party.AddPlayer(player2);
        party.AddPlayer(player3);
        
        
        
        
        
        
        
        var enumerator = party.GetEnumerator();
        enumerator.ToString();
        
        party.GetActiveEnumerable();
        party.GetHpUnderValue(2);

        Action action1 = new Action(6, "Doing 2 move to killer", "Tank", "Boxer");
        Action action2 = new Action(7, "Kill makaruntangu", "Fight", "Tank");



    }
}

