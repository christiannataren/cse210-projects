abstract class Responser
{

    public static int GetIntAnswer()
    {
        int answer;
        int.TryParse(Console.ReadLine(), out answer);
        return answer;
    }

    public static int GetIntAnswer(String question)
    {
        Console.Write($"{question} ");
        return Responser.GetIntAnswer();
    }

    public static String GetResponse(String question)
    {
        Console.Write($"{question} ");
        return Console.ReadLine();
    }

    public static int GetOption(List<String> options)
    {
        int i = 1;
        foreach (String file in options)
        {

            Console.WriteLine($"{i}. {file}");
            i += 1;

        }
        int response = Responser.GetIntAnswer("Select an option: ");
        if (response == 0 || response > options.Count())
        {
            Console.WriteLine("ERRROR: Option invalid");
            return GetOption(options);
        }
        return response;
    }

}