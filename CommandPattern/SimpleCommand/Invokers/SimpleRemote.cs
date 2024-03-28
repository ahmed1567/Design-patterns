namespace CommandPattern
{
    public class SimpleRemote  // Invoker
    {
        ICommand slot;
        public void setCommand(ICommand command)
        {
            slot = command;
        }
        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}