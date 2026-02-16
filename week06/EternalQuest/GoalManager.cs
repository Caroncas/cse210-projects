using System.IO; 
public class GoalManager
{
    //Attributes:
    //_goals (List<Goal>)
    //_score (int)
    List<Goal> _goals = new List<Goal>();
    int _score;

    //Methods:
    //Start (runs the menu loop)
    //DisplayPlayerInfo (current score)
    //ListGoalNames (lists names of each goal)
    //ListGoalDetails (lists details & completion checkboxes for each goal)
    //CreateGoal (ask user for new goal info, & add to list)
    //RecordEvent (calls individual goal classes to record the event)
    //SaveGoals 
    //LoadGoals
    public void Start()
    {
        //Gonna have to add the "display score" in later
        int menuNumber;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. Remove Goal");
            Console.WriteLine("\t3. List Goals");
            Console.WriteLine("\t4. Save Goals");
            Console.WriteLine("\t5. Load Goals");
            Console.WriteLine("\t6. Record Event");
            Console.WriteLine("\t7. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            menuNumber = int.Parse(menuChoice);
            if (menuNumber == 1)
            {
                //Create New Goal
                /*
                    1. Simple Goal (one time)
                    2. Eternal Goal (never complete, but they get points still)
                    3. Checklist Goal (complete it x amount of times)
                */
                CreateGoal();
            }
            else if (menuNumber == 2)
            {
                DeleteGoal();
                Console.WriteLine("Goal has been removed successfully!");
            }
            else if (menuNumber == 3)
            {
                //List Goals
                Console.Clear();
                ListGoalDetails();
            }
            else if (menuNumber == 4)
            {
                //Save Goals
                SaveGoals();
            }
            else if (menuNumber == 5)
            {
                //Load Goals
                LoadGoals();
            }
            else if (menuNumber == 6)
            {
                //Record Event
                RecordEvent();
            }
            else if (menuNumber != 7)
            {
                Console.WriteLine("Please enter a valid menu number.\n");
            }
        }
        while (menuNumber != 7);
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Goal Options:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("What kind of goal would you like to create? ");
        string goalChoice = Console.ReadLine();
        int goalNumber = int.Parse(goalChoice);
        Console.Write("\nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goaldescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();
        int goalPointNumber = int.Parse(goalPoints);

        if (goalNumber == 1)
        {
            _goals.Add(new SimpleGoal(goalName, goaldescription, goalPointNumber));
        }
        else if (goalNumber == 2)
        {
            _goals.Add(new EternalGoal(goalName, goaldescription, goalPointNumber, 0));
        }
        else if (goalNumber == 3)
        {
            Console.Write("How many times will this goal need to be accomplished for a bonus? ");
            string times = Console.ReadLine();
            int timesAmount = int.Parse(times);
            Console.Write($"What is the bonus for accomplishing it {timesAmount} times? ");
            string bonus = Console.ReadLine();
            int bonusAmount = int.Parse(bonus);
            _goals.Add(new ChecklistGoal(goalName, goaldescription, goalPointNumber, bonusAmount, timesAmount, 0));
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        } 
    }

    public void DeleteGoal()
    {
        Console.Clear();
        ListGoalNames();
        Console.WriteLine("Which goal would you like removed? ");
        string remove = Console.ReadLine();
        int removeNumber = int.Parse(remove);
        removeNumber--;
        _goals.Remove(_goals[removeNumber]);
        Console.WriteLine("Goal removed successfully.");
    }

    public void ListGoalNames()
    {
        Console.Clear();
        int numberToAdd = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{numberToAdd++}. {goal.GetStringName()}");            
        }
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        int numberToAdd = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{numberToAdd++}. {goal.GetDetailString()}");
        }
        Console.WriteLine($"Score: {_score}");
    }

    public void RecordEvent()
    {
        Console.Clear();
        ListGoalNames();
        Console.WriteLine("Which goal would you like to record for? ");
        string toRecord = Console.ReadLine();
        int numberToRecord = int.Parse(toRecord);
        numberToRecord--;
        int addedPoints = _goals[numberToRecord].RecordEvent();
        _score += addedPoints;
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("What file would you like to save your goals to? ");  
        string textFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(textFile))
        {
            //line 1 = score
            //following lines format "GoalType:Name,Details,Points,Etc."
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("What file would you like to load your goals from? ");  
        string textFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(textFile);
        // int goalNumber = 1;
        string score = lines[0];
        _score = int.Parse(score);
        foreach (string line in lines)
        {
            if (line != lines[0])
            {
                string[] parts = line.Split("~");
                string goalType = parts[0];
                string goalName = parts[1];
                string goalDetails = parts[2];
                string points = parts[3];
                int numberPoints = int.Parse(points);
                if (goalType == "SimpleGoal")
                {
                    string boolean = parts[4];
                    bool isComplete = bool.Parse(boolean);
                    _goals.Add(new SimpleGoal(goalName, goalDetails, numberPoints, isComplete));
                }
                else if (goalType == "EternalGoal")
                {
                    string counter = parts[4];
                    int completedCounter = int.Parse(counter);
                    _goals.Add(new EternalGoal(goalName, goalDetails, numberPoints, completedCounter));
                }
                else if (goalType == "ChecklistGoal")
                {
                    string bonus = parts[4];
                    int bonusPoints = int.Parse(bonus);
                    string target = parts[5];
                    int targetNumber = int.Parse(target);
                    string completed = parts[6];
                    int numberCompleted = int.Parse(completed);
                    _goals.Add(new ChecklistGoal(goalName, goalDetails, numberPoints, bonusPoints, targetNumber, numberCompleted));
                }
            }
        }
    }

    //Constructor:
    //Do we need one?
    public GoalManager()
    {
        _score = 0;
    }
}