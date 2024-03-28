namespace CommandPattern
{
    public class FanOn : ICommand
    {
        ceilingFan Fan { get; set; }
        public FanOn(ceilingFan fan)
        {
            Fan = fan;
        }
        public void execute()
        {
            Fan.On();

        }

        public void undo()
        {
            Fan.Off();
        }
    }
}