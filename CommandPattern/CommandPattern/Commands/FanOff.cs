namespace CommandPattern
{
    public class FanOff : ICommand
    {
        ceilingFan Fan { get; set; }
        public FanOff(ceilingFan fan)
        {
            Fan = fan;
        }
        public void execute()
        {
            Fan.Off();

        }

        public void undo()
        {
            Fan.On();
        }
    }
}