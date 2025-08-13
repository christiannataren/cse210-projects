class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public static GoalManager me;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
        me = this;
    }


    private void print(String message)
    {
        Console.WriteLine(message);
    }

    private void MenuOptions()
    {
        print("Menu Options:");
        print(" 1. Create New Goal");
        print(" 2. List Goals");
        print(" 3. Save Goals");
        print(" 4. Load Goals");
        print(" 5. Delete Goals");
        print(" 6. Record Events");
        print(" 7. Quit");
        Console.Write("Select a choice from the menu: ");

    }
    private void ShowMenu()
    {
        DisplayPlayerInfo();
        MenuOptions();
        HandleAnswer();
    }



    private void HandleAnswer()
    {
        int answer = Responser.GetIntAnswer();
        switch (answer)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalDetails();
                break;
            case 3:
                SaveGoals();

                break;
            case 4:
                LoadGoals();
                break;
            case 5:
                DeleteGoals();
                break;
            case 6:
                RecordEvent();
                break;

            case 7:
                Environment.Exit(0);
                break;
            default:
                print("Invalid option");
                break;
        }
    }

    private void DeleteGoals()
    {
        List<string> lists = Saver.ExistingProjects();
        print($"You have {lists.Count()} saved lists.");
        print("Select one to delete:");
        if (lists.Count() > 0)
        {
            int option = Responser.GetOption(lists);
            Saver.DeleteGoals(lists[option - 1]);
        }
    }

    public void Start()
    {
        while (true)
        {
            ShowMenu();
        }

    }

    private void DisplayPlayerInfo()
    {
        print("");
        print($"You have {_score} points");
        print("");

    }
    private void ListGoalNames()
    {
        List<string> names = _goals.Select(goal => goal.GetName()).ToList();
        int option = Responser.GetOption(names);
        _goals[option - 1].RecordEvent();
    }
    private void ListGoalDetails()
    {
        print("The goals are: ");
        int i = 1;

        foreach (Goal goal in _goals)
        {
            print($"{i}. {goal.GetDetailsString()}");
            i += 1;
        }

    }
    private void DisplayCreatingMenu()
    {
        print("The types of Goals are: ");
        print(" 1. Simple Goal");
        print(" 2. Eternal Goal");
        print(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }

    public void AddScore(int score)
    {
        _score += score;
        print($"Congratulations! You have earned {score} points!");
        print($"You now have {_score} points!");
    }
    private void HandleCreationAnswer()
    {
        int answer = Responser.GetIntAnswer();
        switch (answer)
        {
            case 1:
                CreateSimpleGoal();
                break;
            case 2:
                CreateEternalGoal();
                break;
            case 3:
                CreateChecklistGoal();
                break;
        }
    }


    private void CreateChecklistGoal()
    {
        string[] data = GetNameDescriptionPoints();
        string name = data[0];
        string description = data[1];
        int points;
        int.TryParse(data[2], out points);
        int timeBonus = Responser.GetIntAnswer("How many times does this goal need to be accomplished for a bonus?");
        int bonusPoints = Responser.GetIntAnswer("What is the bonus for accomplishing it that many times?");

        _goals.Add(new ChecklistGoal(name, description, points, timeBonus, bonusPoints));
    }
    private void CreateEternalGoal()
    {
        string[] data = GetNameDescriptionPoints();
        string name = data[0];
        string description = data[1];
        int points;
        int.TryParse(data[2], out points);
        _goals.Add(new EternalGoal(name, description, points));

    }
    private String[] GetNameDescriptionPoints()
    {
        //return name,description,points
        String[] data = [
            Responser.GetResponse("What is the name of your goal?"),
            Responser.GetResponse("What is a short description of it?"),
            Responser.GetResponse("What is the amount of points associated with this goal?"),
        ];

        return data;
    }
    private void CreateSimpleGoal()
    {
        string[] data = GetNameDescriptionPoints();
        string name = data[0];
        string description = data[1];
        int points;
        int.TryParse(data[2], out points);
        SimpleGoal simple = new SimpleGoal(name, description, points);
        _goals.Add(simple);

    }

    private void CreateGoal()
    {
        DisplayCreatingMenu();
        HandleCreationAnswer();

    }
    private void RecordEvent()
    {
        if (_goals.Count() <= 0)
        {
            print("There are not Goals.");
        }
        else
        {
            print("The goals are:");
            ListGoalNames();
        }


    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
    private void SaveGoals()
    {
        if (_goals.Count() > 0)
        {
            String name = Responser.GetResponse("Give a name to your Goal List: ");
            Saver.Save(this, name);
        }
        else
        {

            print("You can not save an empty list.");
        }


    }

    private void LoadGoals()
    {
        List<string> lists = Saver.ExistingProjects();
        print($"You have {lists.Count()} saved lists.");
        print("Select one to load:");
        if (lists.Count() > 0)
        {
            int option = Responser.GetOption(lists);
            Saver.Load(lists[option - 1], this);
        }

    }

    public void SetScore(int points)
    {
        _score = points;
    }
    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    internal int GetScore()
    {
        return _score;
    }
}