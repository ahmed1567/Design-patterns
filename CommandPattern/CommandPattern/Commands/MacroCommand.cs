namespace CommandPattern
{
    public class MacroCommand : ICommand
    {
   
        ICommand[] Commands;
        public MacroCommand(ICommand[] commands)
        {
            Commands = commands;
            
        }

        public void execute()
        {
        for (int i = 0; i < Commands.Length; i++)
        {
            Commands[i].execute();
        }
    }

        public void undo()
        {
        for (int i = 0; i < Commands.Length; i++)
        {
            Commands[i].undo();
        }
    }
    }
}