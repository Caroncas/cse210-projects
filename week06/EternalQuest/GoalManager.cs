public class GoalManager
{
    //Attributes:
    //_goals (List<Goal>)
    //_score (int)
    List<Goal> _goals = new List<Goal>();
    int _score;

    //Methods:
    //Start
    //DisplayPlayerInfo (current score)
    //ListGoalNames
    //ListGoalDetails
    //CreateGoal (ask user for new goal info, & add to list)
    //RecordEvent (calls individual goal classes)
    //SaveGoals
    //LoadGoals

    //Constructor:
    //Do we need one?
    public GoalManager()
    {
        _score = 0;
    }
}