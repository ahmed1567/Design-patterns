namespace CommandPattern
{
    public class DoorOn : ICommand
    {
        garageDoor Door { get; set; }
        public DoorOn(garageDoor door)
        {
            Door = door;
        }
        public void execute()
        {
            Door.On();

        }

        public void undo()
        {
            Door.Off();

            
        }
    }
}