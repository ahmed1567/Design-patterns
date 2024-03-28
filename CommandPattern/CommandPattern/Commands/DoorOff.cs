namespace CommandPattern
{
    public class DoorOff : ICommand
    {
        garageDoor Door { get; set; }
        public DoorOff(garageDoor door)
        {
            Door = door;
        }
        public void execute()
        {
            Door.Off();

        }

        public void undo()
        {
            Door.On();
        }
    }
}