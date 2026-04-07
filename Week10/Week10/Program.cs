namespace Week10;

public class Program
{
    static void Main()
    {
        Player player1 = new Player("Mariia","Luxery", "Strategy",9,2,Player.conditionOfPlayer.Active, 150);
        Player player2 = new Player("Taisa","Luxery", "Support",9,3,Player.conditionOfPlayer.Active,300);
        Player player3 = new Player("Oleg","Simple", "Tank",5,0,Player.conditionOfPlayer.Passive,650);

        Party party = new Party();
        party.AddPlayer(player1);
        party.AddPlayer(player2);
        party.AddPlayer(player3);
        
        Action action1 = new Action(6, "Doing 2 move to killer", "Tank", "Boxer");
        Action action2 = new Action(7, "Kill makaruntangu", "Fight", "Tank");
        EventLog log = new EventLog();
        
        log.AddAction(action1);
        log.AddAction(action2);
        while (true)
        {
            Console.WriteLine("MENU: enter only number\n" +
                              "1-Show registered people,\n" +
                              "2-Show All player who joined the game,\n" +
                              "3-All active players,\n" +
                              "4-All players who have under 2 Hp,\n" +
                              "5-FilterLevel, \n" +
                              "6-SelectNames,\n" +
                              "7-MaxCountOgGold,\n" +
                              "8-Count of player who injured,\n" +
                              "9-Chronology of events,\n" +
                              "10-Some type of action");
            Console.WriteLine();
            Console.Write("Your choise is : ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine();
                Console.WriteLine("All people who register:");
                Console.WriteLine(player1);
                Console.WriteLine(player2);
                Console.WriteLine(player3);
            }

            if (input == "2")
            {
                Console.WriteLine();
                Console.WriteLine("All player who joined the game");
                foreach (var addplayer in party)
                {
                    Console.WriteLine(addplayer);
                }
            }

            if (input == "3")
            {
                Console.WriteLine();
                Console.WriteLine("All active players");
                foreach (var active in party.GetActiveEnumerable())
                {
                    Console.WriteLine(active);
                }
            }

            if (input == "4")
            {
                
                Console.WriteLine();
                Console.WriteLine($"All players who have under 2 Hp ");
                foreach (var hp in party.GetHpUnderValue(2))
                {
                    Console.WriteLine(hp);
                }
            }

            if (input == "5")
            {
                var level = party.FilterLevel(10);
                Console.WriteLine($"Players have more level than 10: {level.GetEnumerator()}");
            }

            if (input == "6")
            {
                var names = party.SelectNames();
                Console.WriteLine($"Names of player {names}");

            }

            if (input == "7")
            {
                var max = party.MaxCountOgGold();
                Console.WriteLine($"Player: {max}");

            }

            if (input == "8")
            {
                var count = party.CountByInjured();
                Console.WriteLine($"Count of player who injured:  {count}");
            }

            if (input == "9")
            {
                Console.WriteLine();
                Console.WriteLine("Chronology of events");
                foreach (var chr in log.GetChronology())
                {
                    Console.WriteLine(chr);
                }
            }

            if (input == "10")
            {
                Console.WriteLine();
                Console.WriteLine("Some type of action");
                foreach (var type in log.GetActionSomeType("Tank"))
                {
                    Console.WriteLine($"Type: {type.TypeOfAction}, Description: {type.Description}");
                } 
            }

        }
    }
}

