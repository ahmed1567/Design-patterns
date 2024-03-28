using System.Text;
namespace CommandPattern
{
    public class RemoteControl  // Invoker
    {
        ICommand[] onCommands;
        ICommand[] offCommands;

        ICommand undoCommand;
        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            undoCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];

        }
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }

        public override String ToString()
        {
            
            StringBuilder str = new StringBuilder();
            str.Append("\n------ Remote Control------ -\n");
            str.Append("slot Num \t-        OnCommand  \t-\t \t OffCommand \n ");

            for (int i = 0; i < 7; i++)
            {
                str.Append($"slot {i} \t-\t {onCommands[i].GetType()}  \t-\t {offCommands[i].GetType()} \n ");
            }
            str.Append($" undo is ----->   {undoCommand.GetType()}");

            return str.ToString();
            
        }

    }
}