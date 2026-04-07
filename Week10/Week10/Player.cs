namespace Week10;

public class Player
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public int CountOFHealth { get; set; }
    public string ConditionOfPlayer { get; set; }

    public Player(string name, string role, int level, int countOfHealth, string conditionOfPlayer)
    {
        Name = name;
        Role = role;
        Level = level;
        CountOFHealth = countOfHealth;
        ConditionOfPlayer = conditionOfPlayer;
        
    }
}