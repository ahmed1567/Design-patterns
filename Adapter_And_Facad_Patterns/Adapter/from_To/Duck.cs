namespace AdapterPattern
{
    public class Duck : IDuck
    {
        public void fly()
        {
            Console.WriteLine("fly long distance"); ;
        }

        public void quack()
        {
            Console.WriteLine("quack quack !!!"); ;
        }
    }
}