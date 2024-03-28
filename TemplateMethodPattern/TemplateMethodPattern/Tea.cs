namespace TemplateMethodPattern;

public class Tea : CaffeineBeverage
{


    public override void brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    public override void addCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }


    private string GetUserInput()
    {
        Console.WriteLine("Would you like lemon with your Tea (y/n) ?");
        string answer = Console.ReadLine();
        return answer;
    }

    public override bool CustomerWantsCondiments()
    {
        string answer = GetUserInput();

        if (answer.ToUpper().StartsWith("Y"))
        {
            return true;
        }
        else if (answer.ToUpper().StartsWith("N"))
        {
            return false;
        }
        return false;
    }
}
