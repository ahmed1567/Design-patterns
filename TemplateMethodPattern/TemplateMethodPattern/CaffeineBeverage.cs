// See https://aka.ms/new-console-template for more information
namespace TemplateMethodPattern;
public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        boilWater();
        brew();
        pourInCup();
        if (CustomerWantsCondiments())
        {
            addCondiments();
        }
    }
    public abstract void brew();
    public abstract void addCondiments();
    void boilWater()
    {
        Console.WriteLine("Boiling water");
    }
    void pourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
    public virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}