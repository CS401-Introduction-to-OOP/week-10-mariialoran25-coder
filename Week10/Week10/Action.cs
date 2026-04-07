namespace Week10;

public class Action
{
    public int NumOfMove { get; set; }
    public string Description { get; set; }
    public string TypeOfAction {get;set;}
    public string ChangeCharactiristics {get;set;}

    public Action(int numOfMove, string description, string typeOfAction, string changeCharactiristics)
    {
        NumOfMove = numOfMove;
        Description = description;
        TypeOfAction = typeOfAction;
        ChangeCharactiristics = changeCharactiristics;
    }
    
}