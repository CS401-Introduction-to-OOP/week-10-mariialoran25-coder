using System.Collections;

namespace Week10;

public class EventLog : IEnumerable<Action>
{
    private List<Action> _actions = new List<Action>();
    public void AddAction(Action action)
    {
        _actions.Add(action);
    }
    
    public IEnumerable<Action> GetChronology()
    {
        foreach (var action in _actions)
        {
            yield return action;
        }
    }
    

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    
    
    public IEnumerable<Action> GetActionSomeType(string type)
    {
        foreach (var action in _actions)
        {
            if (action.TypeOfAction == type)
            {
                yield return action;
            }
        }
    }
    
    public IEnumerator<Action> GetEnumerator()
    {
        foreach (var action in _actions)
        {
            yield return action;
        }
    }

    
    

}