using System.Collections;
using System.Reflection;

abstract class Saver
{
    private static string code = "<1222>", extension = ".gls";


    public static void Save(GoalManager manager, String filename)
    {

        List<Goal> goals = manager.GetGoals();
        // manager.
        int score = manager.GetScore();
        String text = $"{score}\n";
        foreach (Goal goal in goals)
        {
            String line = "";
            List<string> data = goal.GetStringRepresentation();
            foreach (String attr in data)
            {
                line += $"{attr}{code}";
            }
            line += "\n";
            text += line;
        }
        File.WriteAllText($"{filename}{extension}", text);


    }

    public static int ParseInt(String text)
    {
        int data;
        int.TryParse(text, out data);
        return data;
    }
    public static void Load(String filename, GoalManager goalManager)
    {
        List<Goal> goals = new List<Goal>();
        String text = File.ReadAllText($"{filename}{extension}");
        // Console.WriteLine($"TEXTFILE: {text}");
        String[] lineas = text.Split("\n");
        bool firstLine = false;
        foreach (String linea in lineas)
        {
            if (!firstLine)
            {
                int score;
                int.TryParse(linea, out score);
                goalManager.SetScore(score);
                firstLine = true;
                continue;
            }
            String[] data = linea.Split(code);
            String type = data[0];
            switch (type)
            {
                case "SimpleGoal":
                    bool IsComplete;
                    Boolean.TryParse(data[4], out IsComplete);
                    goals.Add(new SimpleGoal(data[1], data[2], ParseInt(data[3]), IsComplete));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(data[1], data[2], ParseInt(data[3])));
                    break;
                case "CheckListGoal":
                    goals.Add(new ChecklistGoal(data[1], data[2], ParseInt(data[3]), ParseInt(data[5]), ParseInt(data[4]), ParseInt(data[6])));
                    break;

            }

        }
        goalManager.SetGoals(goals);
    }



    public static List<String> ExistingProjects()
    {
        List<String> files = new List<String>();

        foreach (string file in Directory.GetFiles("./", $"*{extension}"))
        {
            files.Add(file.Replace("./", "").Replace(extension, ""));
            // Console.WriteLine(file);
        }
        return files;
    }

    public static Boolean DeleteGoals(string filename)
    {
        try
        {
            File.Delete($"{filename}{extension}");
            return true;

        }
        catch (Exception e)
        {

        }
        return false;
    }
}