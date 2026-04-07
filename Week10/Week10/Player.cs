namespace Week10;

public class Player
{
    public string Name { get; set; }
    public string Classs { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public int CountOFHealth { get; set; }
    public int Gold { get; set; }

    public enum conditionOfPlayer
    {
        Active,
        Passive,
        Injured
    }
    public conditionOfPlayer Status { get; set; }

    public Player(string name,string classs, string role, int level, int countOfHealth,conditionOfPlayer status , int gold)
    {
        Name = name;
        Classs = classs;
        Role = role;
        Level = level;
        CountOFHealth = countOfHealth;
        Status = status;
        Gold = gold;
    }


    public override string ToString()
    {
        return $"Name: {Name}, Role: {Role},Level {Level},Count OF Health: {CountOFHealth}" ;
    }
}