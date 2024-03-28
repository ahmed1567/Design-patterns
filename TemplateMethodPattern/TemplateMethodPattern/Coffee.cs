namespace TemplateMethodPattern;

public class Coffee : CaffeineBeverage
{
     public override void brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }
    public override void addCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }

    private string GetUserInput()
    {
        Console.WriteLine("Would you like milk and sugar with your coffee(y/n) ? ");
        string answer = Console.ReadLine();
        return answer;
    }

    public override bool CustomerWantsCondiments()
    {
        string answer = GetUserInput();

        if (answer.ToUpper().StartsWith("Y"))
        {
            return true;
        }else if (answer.ToUpper().StartsWith("N"))
        {
            return false;
        }
        return false;
    }
}