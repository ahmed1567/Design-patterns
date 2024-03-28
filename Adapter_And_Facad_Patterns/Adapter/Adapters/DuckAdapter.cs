namespace AdapterPattern;

public class DuckAdapter : ITurkey
{
    IDuck Duck { get; set; }

    Random rand = new Random();


    public DuckAdapter( IDuck duck)
    {
        Duck = duck;
    }
    public void fly()
    {

        if (rand.Next(5) == 0)
        {
            Duck.fly(); // the duck has a 20% chance of flying since 1 out of 5 possible values results in true
        }
    }

    public void gobble()
    {
        Duck.quack();
    }
}