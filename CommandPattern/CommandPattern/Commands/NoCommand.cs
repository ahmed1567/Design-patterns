namespace CommandPattern
{
    public class NoCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("noCommand");


        }

        public void undo()
        {
            Console.WriteLine("noCommand");
        }
    }
}