using System.ComponentModel;
using System.IO.Compression;
using System.IO;

public class Manager
{
    private List<Goals> _goals = new List<Goals>();
    private int _score = 0;

    public Manager()
    {

    }

    public void Start()
    {
        Console.Clear();
        DisplayPlayerInfo();
        Console.Write("\nMenu Options:\n" + 
                      "     1. Create New Goal\n" + 
                      "     2. List Goals\n" +
                      "     3. Save Goals\n" +
                      "     4. Load Goals\n" +
                      "     5. Record Event\n" +
                      "     6. Quit\n" +
                      "Select a choice from the menu: ");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            CreateGoal();
        }
        else if (userInput == "2")
        {
            int i = 0;
            foreach (Goals goal in _goals)
            {
                Console.WriteLine($"{i = i + 1}. {goal.GetStringRepresentation()}");
            }
            Console.Write("\nPress enter to return to menu.");
            Console.ReadLine();
            Start();
        }
        else if (userInput == "3")
        {
            Console.Write("What is the file name for the goal file? ");
            string fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(_score);
                foreach (Goals goal in _goals)
                {
                    outputFile.WriteLine($"{goal}: {goal.GetDetails()}");
                }
            }
            Start();
        }
        else if (userInput == "4")
        {
            
        }
        else if (userInput == "5")
        {
            
        }
        else if (userInput == "6")
        {
            
        }
        else
        {
            Console.Write("ERROR, Invalid Input. Press enter to continue.");
            Console.Read();
            Start();
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.Write("\nThe types of Goals are:\n" +
                      "     1. Simple Goal\n" +
                      "     2. Eternal Goal\n" +
                      "     3. Checklist Goal\n" +
                      "     4. Back to Menu\n" +
                      "What type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        if(goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points are associated with this goal? ");
            string points = Console.ReadLine();
            Simple sG = new Simple(name, description, points);
            _goals.Add(sG);
            Start();
        }
        else if (goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points are associated with this goal? ");
            string points = Console.ReadLine();
            Eternal eG = new Eternal(name, description, points);
            _goals.Add(eG);
            Start();
        }
        else if (goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points are associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string target = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();
            Checklist chG = new Checklist(name, description, points, int.Parse(target), int.Parse(bonus));
            _goals.Add(chG);
            Start();
        }
        else if (goalType == "4")
        {
            Start();
        }
        else
        {
            Console.Write("\nERROR Invalid Input. Press enter to continue.");
            Console.Read();
            CreateGoal();
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }
}